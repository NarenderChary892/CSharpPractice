using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.StaticInstance {
  class Circle1 {
    static float _pi;
    int _radius;

    static Circle1() {
      Circle1._pi = 3.141F;
    }
    public Circle1( int radius ) {
      this._radius = radius;
    }

    public void CalculateArea1() {
      float area = Circle1._pi * this._radius * this._radius;
      Console.WriteLine( "Circle Area:: {0}", area );
    }
  }
}
