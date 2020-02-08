using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandsOn
{

    enum MyEnum
    {
        jan = 5,
        april,
        dec,
    }
    class Enum
    {

        
        public enum MyClubsEnum
        {
            ManUtd,
            Chelsea,
            Arsenal
        }

        public void printEnum()
        {
            Console.WriteLine("Manchester United: {0}\nChelsea: {1}\nArsenal: {2}", MyClubsEnum.ManUtd, MyClubsEnum.Chelsea, MyClubsEnum.Arsenal);
           
        }

    }

    class EnumRunner
    {
        public static void Main2(string[] args)
        {
            Enum myEnumObject = new Enum();
            Console.WriteLine("Jan: {0}\nApril: {1}\nDecember: {2}", (int)MyEnum.jan, (int)MyEnum.april, (int)MyEnum.dec);
            Console.WriteLine("*******************************************************");
            Console.WriteLine("Manchester United: {0}\nChelsea: {1}\nArsenal: {2}", (int)Enum.MyClubsEnum.ManUtd, Enum.MyClubsEnum.Chelsea, Enum.MyClubsEnum.Arsenal);
            Console.WriteLine("*******************************************************");
            Console.WriteLine("Calling From Enum Runner class:\n");
            
            Console.ReadKey();
            
        }
    }

    
}
