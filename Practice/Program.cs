using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using Practice.ImplicitExplicit;
using Practice.Constructors;
using Practice.StaticInstance;
using Practice.Inheritance;
using Practice.Interface;
using Practice.Enum;
using Practice.Polymorphism;
using Practice.Enum.Enum2;
using Practice.EmailVerification;
using Practice.MethodOverrideHiding;
using Practice.Generics;
using Practice.Dictionaries;
using Practice.List;
using Practice.List.NewEx;
using Practice.List.Sorting;
using Practice.DictionaryOverList;
using Practice.CSVReader;
using Practice.CSVReader.NewData;
using Practice.WebScraping;
using Practice.SearchingAlgo;
using Practice.ExcelReader;
using Practice.AppVeyorTesting;

namespace Practice
{

    class Program
    {
        static void Main(string[] args)
        {
      //      //ImplicitExplicit
      //      ImplicitEx implicitEx = new ImplicitEx();
      //      implicitEx.ImplicitMethod();
      //      // implicitEx.lossOfData();

      //      //Constructors
      //      Names name = new Names("Narender", "Chary");
      //      name.getFullname();

      //      //Static Instance
      //      Circle circle = new Circle(3);
      //      circle.CalculateArea();

      //      Circle1 circle1 = new Circle1(3);
      //      circle1.CalculateArea1();

      //      // Inheritance
      //      FullTimeDetails emp = new FullTimeDetails();
      //      emp.getFullTimeEmployeeDetails();
      //      PartTimeDetails pt = new PartTimeDetails();
      //      pt.getPartTimeEmployeeDetails();

      //      // Interface
      //      SumClass sum = new SumClass();
      //      sum.Print();

      //      // Enum
      //      Weeks weeks = new Weeks();
      //      weeks.GetEnums();

      //      EmployeeMainClass employeeMainClass = new EmployeeMainClass();
      //      employeeMainClass.GetEmployee();

      //      // Polymorphism
      //      EmployeeDetails employeeDetails = new EmployeeDetails();
      //      employeeDetails.GetEmployeeDetails();


      //      // EmailVerification
      //      //EmailSender email = new EmailSender ();
      //      //email.SendEmail();
      //      //email.SendEmail2();

      //      // CSV Reader
      //      CsvReader csvReader = new CsvReader();
      //      csvReader.GetCSVDetails();

      //      ExcelDataReader excelDataReader = new ExcelDataReader();
      //      excelDataReader.GetExcelData();



      //      //Method Hiding & Override
      //      MainClass mainClass = new MainClass();
      //      mainClass.GetMethods();


      //      // Generics
      //      GenericsUsage gen = new GenericsUsage();
      //      GenericsUsage.GetGenerics();


      //      //Dictionaries
      //      CustomerInfo cust = new CustomerInfo();
      //      cust.GetCustomerInfo();
      //      ArrayToDictionary ArrToDict = new ArrayToDictionary();
      //      ArrToDict.ArrayToDict();

      //      // List
      //      StudentInfo studentInfo = new StudentInfo();
      //      studentInfo.GetStudentInfo();

      //      ArrToList arrToList = new ArrToList();
      //      arrToList.GetArrToList();


      //      NewCustomerInfo customerInfo = new NewCustomerInfo();
      //      customerInfo.GetCustomerInfo();

      //      //Sorting
      //      Numbers numbers = new Numbers();
      //      numbers.GetNumbersSorting();

      //      Alphabets alpha = new Alphabets();
      //      alpha.GetAlphabetsSorting();

      //      // DictionaryOverList
      //      CountryDetailsUsingList countryDetails = new CountryDetailsUsingList();
      //     // countryDetails.GetCountryDetailsUsingList();

      //      CountryDetailsUsingDictionary countryDetailsUsingDictionary = new CountryDetailsUsingDictionary();
      ////countryDetailsUsingDictionary.GetCountryDetailsUsingDictionary();

      // WebScraping
      //WebScrap webScrap = new WebScrap();
      //WebScrap.GetWebData();


      // Searching Algorithm
      // LinearSearch linear = new LinearSearch();
      //linear.Linearsearch();

      // Running Services status
     // ServiceStatus status = new ServiceStatus();
      //status.GetRunningServices();

      // Appveyor Testing
      AppVeyorTest appVeyor = new AppVeyorTest();
      appVeyor.TestAppVeyor();



            Console.ReadKey();
        }

    }

}