using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Constructors {
  public class Names {
    string _fname;
    string _lname;


    public Names( string fname, string lname ) {
      _fname = fname;
      _lname = lname;
    }

    public void getFullname()
    {
      Console.WriteLine( "Fullname = {0} ", _fname + " " + _lname );
    }
  }
}

