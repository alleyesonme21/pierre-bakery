namespace PierreBakery.Models
{
  public class Bread
{
public int NumberOfBread { get; set; }
public  int BreadCost(int numberOfBread )
    {
      NumberOfBread =  numberOfBread;
     return  NumberOfBread  * 5;
    }
    public int TotalBread()
    {
     return NumberOfBread / 2;
    }
  }
}  











