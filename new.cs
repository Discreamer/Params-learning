using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace IHateSharp
{
	
    class Program
    {
		//params позволяет перебрать неизвестное кол-во входных переменных
		public static int Summa(params int[] args)
		{
			int Summ=0;
			for (int i=0;i<args.Length;i++)
			{
				Summ+=args[i];
			}
			return Summ;
		}
        static void Main(string[] args)
        {
			int[] ar = new int[]{1,1,2,66,5,4,5,6,5,5,5,5,5};
			Console.WriteLine(Summa(ar));
        }
	}
}

