using System;

namespace PierreBakery.ModelsP
{

  public class Pastry
  {
    public static int costSolver(int num) 
    {
      if (num == 1) {
        return 2;
      } else if (num == 2) {
        return 4;
      } else {
        return num * 5;
      }
    }

  }
}