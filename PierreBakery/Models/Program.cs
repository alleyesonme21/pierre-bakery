using System;
using PierreBakery.Models;
using PierreBakery.ModelsP;

namespace PierreBakery 
{
  public class Program
  {
    
    public static void Main()
    {
      Console.WriteLine("type your number of bread in to see your price: ");
      string input = Console.ReadLine(); 
      int inputP =  int.Parse(input);  
      Console.WriteLine("The bread's price: " + Bread.priceSolver(inputP));

    Console.WriteLine("type your number of pastry in to see your price: ");
      string result = Console.ReadLine(); 
      int resultP =  int.Parse(result);  
      Console.WriteLine($"The  pastry's price: {Pastry.costSolver(resultP)}");
      int total = Bread.priceSolver(inputP) + Pastry.costSolver(resultP);

      Console.WriteLine("The total price: " + total);

      

    }
  }
}
