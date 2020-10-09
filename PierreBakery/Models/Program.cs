using System;
using PierreBakery.Models;

namespace PierreBakery 
{
  public class Program
{
    
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery: One bread for $5 and one pastry for $2");

      Console.WriteLine("type your number of bread in to see your price: ");
      string input = Console.ReadLine(); 
      int inputP =  int.Parse(input);
      
      Bread myBreadOrder = new Bread();  
      Console.WriteLine($"The bread's price: {myBreadOrder.BreadCost(inputP)}  and  get { myBreadOrder.NumberOfBread / 2} free");

      Console.WriteLine("type your number of pastry in to see your price: ");
      string result = Console.ReadLine(); 
      int resultP =  int.Parse(result);

      Console.WriteLine($"The  pastry's price: {Pastry.pastryCost(resultP)}");
      int total = myBreadOrder.BreadCost(inputP) + Pastry.pastryCost(resultP);
      Console.WriteLine("The total price: " + total);
    }
  }
}
