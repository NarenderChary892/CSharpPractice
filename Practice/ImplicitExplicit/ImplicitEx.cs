using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ImplicitExplicit {
  class ImplicitEx {

    public void ImplicitMethod() {
      string strNum = "110";
      int Result = 0;
      bool IsConversion = int.TryParse( strNum, out Result );

      if ( IsConversion ) {
        Console.WriteLine( Result );
      }
      else {
        Console.WriteLine( "Please enter valid number" );
      }
    }

    public void lossOfData() {
      try {
        string getNum = "892UN";
        int i = int.Parse( getNum );
        Console.WriteLine( i );
      }
      catch ( FormatException ex ) {
        Console.WriteLine( ex.Message );
        Console.WriteLine( ex.StackTrace );
      }
    }

  }

}

