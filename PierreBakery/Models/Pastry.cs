using System;

namespace PierreBakery.ModelsP
{

  public class Pastry 
  {
  
 public int Num { get; set; }
  
    public  static int costSolver(int num)  
    {
      int Num = num;
      
      if (Num == 1) {
        return 2;
      } else if (Num == 2) {
        return 4;
      } else if (Num % 3 == 0) {
        return (Num / 3) * 5;
      } else if (Num % 3 == 1){
        return (Num - 1) / 3 * 5 + 2;
      } else if (Num % 3 == 2) {
        return (Num - 2) / 3 * 5 + 2 + 2 ;
      } else {
        return 0;
      }
    }
  }
}






