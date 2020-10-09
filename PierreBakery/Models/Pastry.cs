namespace PierreBakery.Models
{
  public class Pastry 
{
  
  public int Num { get; set; }
  
    public  static int pastryCost(int num)  
    {
      int Num = num;
      int price = 2;
      
      if (Num == 1) {
        return num * price;
      } else if (Num % 3 == 0) {
        return (Num / 3) * 5;
      } else if (Num % 3 == 1){
        return (Num - 1) / 3 * 5 + price;
      } else if (Num % 3 == price) {
        return (Num - price) / 3 * 5 + price + price ;
      } else {
        return 0;
      }
    }
  }
}






