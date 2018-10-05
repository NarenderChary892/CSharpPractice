using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ExcelReader {
  class ServiceStatus {
    public void GetRunningServices() {

      string filepath = ( @"C:\Users\Operations01\Desktop\Data.csv" );
      const Int32 bufferSize = 128;
      int count = 0;
      string StatusName;
      //string run = "\"Running\"";
      bool IsFirstRow = true;
      using ( var fileStream = File.OpenRead( filepath ) ) {
        using ( var streamReader = new StreamReader( fileStream, Encoding.UTF8, true, bufferSize ) ) {
          string line;
          while (( line = streamReader.ReadLine()) != null ) {
            if ( IsFirstRow ) {
              IsFirstRow = false;
            }
            else {
              var data = line.Split(',');
              if ( !string.IsNullOrEmpty( data[0] ) ) {
                StatusName = data[0];
                //Console.WriteLine( StatusName );
                if (StatusName.Equals( "\"Running\"" ) ) {
                  Console.WriteLine("{0}{1}{2}", data[0], data[1], data[2] );
                  count++;
                }
              }

            }
            
          }
          Console.WriteLine( "Total Running Services:{0}", count );
        }
      }
    }
  }
}
