using System;

namespace PierreBakery.ModelsP
{

  public class Pastry
  {
    public static int costSolver(int num)
    {

       if (num % 3 == 0) {
       return num * (5 - 2);
     } else {
       return num *  (5 - 2 );
     }


    }
    }
  }