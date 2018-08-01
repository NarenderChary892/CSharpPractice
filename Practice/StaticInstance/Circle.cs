using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.StaticInstance {
  class Circle {

    float pi = 3.141F;
    int _radius;

    public Circle(int radius ) {
      this._radius = radius;
    }

    public void CalculateArea() {
      float area = pi * this._radius * this._radius;
      Console.WriteLine("Circle Area:: {0}",area);
    }
  }
}
