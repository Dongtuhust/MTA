using System;

class MainClass {
  public static void Main (string[] args) {
        int i = 1;
        int sum = 0;
        while(i <= 100)
        {
            sum = sum + i;
            i++;
        }
        ///////////
        int j = 20;
        string rs = "";
        while (j <= 50)
        {
            if (j % 3 == 0) rs = rs + j + " ";
            j++;
        }
        Console.WriteLine("SUM 1 to 100: " + sum);
        Console.WriteLine("The list is divisible 3 from 20-50: " + rs);
        String val;
        Console.Write("Enter Account Type: ");
        val = Console.ReadLine();
        Console.WriteLine(val);
        int type = Convert.ToInt32(val);
        Console.Write("Enter Minus: ");
        val = Console.ReadLine();
        Console.WriteLine(val);
        int minus = Convert.ToInt32(val);
        float cost = phoneCost(minus,type);
        Console.WriteLine("Phone Cost: "+ (cost+27000)*110/100 + "đ");
        Console.WriteLine("VAT: "+ (cost+27000)*10/100 + "đ");
  }

  public static float phoneCost(int minus, int type){
    float cost = 0;
    if(type==0 && minus <= 50){
      return 0;
    }
    if(minus>400){
      cost = (minus-400)*40 + (minus-(minus-400)-200)*80 + (minus-(minus-(minus-400)-200))*120;
    }else if(minus>200){
      cost = (minus-200)*80 + (minus-(minus-200))*120;
    }else if(minus<200 && minus >0){
      cost = minus*120;
    }
    if(type==0){
      cost=cost-50*120;
    }
    return cost;
  }
}
