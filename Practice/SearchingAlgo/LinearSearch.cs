using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.SearchingAlgo {
  class LinearSearch {
    public void Linearsearch() {

      Console.WriteLine( "Enter no.of elements:" );
      int n =int.Parse(Console.ReadLine());

      int[] arr = new int[n];
        
       for(int i=0; i< n;i++ ) {
        string ele = Console.ReadLine();
        arr[i] =Int32.Parse( ele );
      }
      
       foreach(int val in arr ) {
        Console.WriteLine( val );
      }
      Console.WriteLine( "enter Search element:" );
      int searchEle = int.Parse(Console.ReadLine());

      for(int j=0; j< n;j++ ) {
        if(searchEle == arr[j] ) {
          Console.WriteLine( "Element found" );
        }
       

      }
      Console.WriteLine( "element not found" );

    }
  }
}
