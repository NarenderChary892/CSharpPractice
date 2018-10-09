#addin nuget:?package=Cake.Git

// Cake script
// Relies on environment variables
// Recommend to use with an orchestrator, e.g. AppVeyor.

//var solution1 = "./Code/ImportFramework/ImportFramework.sln";
//var solution2 = "./Code\Quote-Extensions/Quote-Extensions/Quote-Extensions.sln";
// var ProjectSolutions = new string[] { "./Code/ImportFramework/ImportFramework.sln", "./CodeQuote-Extensions/Quote-Extensions/Quote-Extensions.sln"};

// foreach(var solution in ProjectSoltions){
 
var solution = "./CSharpLearning/CSharpPractice/Practice.sln";
var ArtifactPath = System.Environment.CurrentDirectory + "/artifacts";

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument( "target", "Build" );

// Specifies package version directly, setting
// major, minor and patch versions plus suffix
var tag = Argument<string>( "tag", EnvironmentVariable( "APPVEYOR_REPO_TAG_NAME" ) );
var buildId = Argument( "build", "0" );
var commit = Argument( "commit", "" );
var configuration = Argument( "configuration", "Release" );
var majorVersion = "0";
var minorVersion = "0";
var patchVersion = "0";
var buildType = "<none>";
var externalPublish = false; // If true and build type "release" then publish packages to nuget feed
var suffix = Argument( "suffix", "" );

// Initialize variables according to the Git tag
SetupFromTag( tag );

//////////////////////////////////////////////////////////////////////
// PROCEDURES AND FUNCTIONS
//////////////////////////////////////////////////////////////////////

// Set the environment and the variables according to the tag it is running on
void SetupFromTag( string tag ) {
    commit = GitLogTip( "." ).Sha;

    var releasePattern = new System.Text.RegularExpressions.Regex( @"((?<type>.+)/)?(?<major>[0-9]+)\.(?<minor>[0-9]+)\.(?<patch>[0-9]+)(?<suffix>-.+)?" );

    if ( releasePattern.IsMatch( tag ?? string.Empty ) ) {
        Information( "Release detected, setting package version..." );
        var matches = releasePattern.Match( tag ?? string.Empty );
        buildType = matches.Groups["type"].Value;
        majorVersion = matches.Groups["major"].Value;
        minorVersion = matches.Groups["minor"].Value;
        patchVersion = matches.Groups["patch"].Value;
        suffix = matches.Groups["suffix"].Value;
        if (!string.IsNullOrEmpty(suffix) && suffix.StartsWith("-")) {
            suffix = suffix.Substring(1);
        }
        if( string.IsNullOrEmpty(suffix) || suffix.StartsWith("preview") ) {
            externalPublish = true;
        }
    }

    Information( "Package version=" + majorVersion + "." + minorVersion + "." + patchVersion);
    Information( "Version suffix=" + suffix );
    Information( "Build Type=" + buildType );
    Information( "Publish externally=" + externalPublish );
}

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

// Clean
Task( "Clean" )
    .Does( () =>
    {
        foreach ( var dir in GetDirectories( "**/obj/*" ) ) {
            CleanDirectory( dir );
        }
        foreach ( var dir in GetDirectories( "**/bin/*" ) ) {
            CleanDirectory( dir );
        }
        CleanDirectory( ArtifactPath );
    });

// RestoreOnly
Task( "RestoreOnly" )
    .Does( () =>
    {
        NuGetRestore( solution );
    });

// BuildOnly
Task( "BuildOnly" )
    .Does( () =>
    {

        Information("Build solution");
        MSBuild( solution, settings =>
            settings
                .SetVerbosity( Verbosity.Quiet )
                .SetConfiguration( configuration )
                .WithProperty( "MajorVersion", majorVersion )
                .WithProperty( "MinorVersion", minorVersion )
                .WithProperty( "PatchVersion", patchVersion )
                .WithProperty( "BuildVersion", buildId )
                .WithProperty( "VersionSuffix", suffix )
                .WithProperty( "Commit", commit )
        );

    });

// TestOnly
Task( "TestOnly" )
    .Does( () =>
    {
        var projects = GetFiles("./test/**/*.csproj");
        /*foreach(var project in projects)
        {
            DotNetCoreTest(
                project.FullPath,
                new DotNetCoreTestSettings()
                {
                    Configuration = configuration,
                    NoBuild = true
                });
        }*/

    });

//////////////////////////////////////////////////////////////////////
// TASKS WITH DEPENDENCIES
//////////////////////////////////////////////////////////////////////

// Restore solution
Task( "Restore" )
    .IsDependentOn( "Clean" )
    .IsDependentOn( "RestoreOnly" )
    .Does( () => { } );

// Restore and Build solution
Task( "Build" )
    .IsDependentOn( "Restore" )
    .IsDependentOn( "BuildOnly" ).Does( () => { } );

// Restore, Build and Test solution
Task( "Test" )
    .IsDependentOn( "Build" )
    .IsDependentOn( "TestOnly" )
    .Does( () =>{ } );

// Run target task
RunTarget( target );
