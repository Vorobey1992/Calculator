using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
        
        double num1 , num2 ;
        string sign;
           
        Console.WriteLine("Enter your first number: ");
            
       num1 = double.Parse(Console.ReadLine());
            
       Console.WriteLine("Select function '+','-','*','/' ");
       
       sign = Console.ReadLine();
       
       Console.WriteLine("Enter your second number:");  
            
       num2 = double.Parse(Console.ReadLine());
       
       
       if (sign=="+")
       {
       Console.WriteLine("The sum is : " +(num1+num2));
       }
       
       else if (sign=="-") 
       {
       Console.WriteLine("The different is : " + (num1-num2));
       }
       else if (sign=="*")
       {
       Console.WriteLine("The multiplication is: "+(num1*num2));
       }
       else if (sign=="/")
       {
            if (num2==0)                            
       Console.WriteLine(num1+"/"+num2+"="+0);    
            else 
       Console.WriteLine("The division is: "+(num1/num2));
       }
       
       else 
       {
    Console.WriteLine("Error, check mistakes");
       }
         
          
            
        }
    }
}
