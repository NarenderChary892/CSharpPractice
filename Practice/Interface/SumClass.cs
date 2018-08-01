using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Interface {
  interface ISumClass {
    void Print();  
    }
  interface ISumClass2 {
    void Print2();
  }
  class SumClass : ISumClass {
    public void Print() {
      Console.WriteLine("Method");
    }
  }
  }


