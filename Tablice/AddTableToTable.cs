using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
	class AddTableToTable
	{
		private static int t1 = 5;
		private static int t2 = 7;
		private static int[] SumTab1 = new int[t1];
		private static int[] SumTab2 = new int[t2];

		public static int[] SumTwoTable() //metoda statyczna, dla wywołania nie trzeba tworzyć obiektu
		{
			//int t1 = 5;
			//int t2 = 7;
			//int[] SumTab1 = new int[t1];
			//int[] SumTab2 = new int[t2];

			for (int i = 0; i < t1; i++)
			{
				SumTab1[i] = i;
			}

			for (int i = 0; i < t2; i++)
			{
				SumTab2[i] = (t1) + i;
			}

			int[] SumTab = SumTab1.Concat(SumTab2).ToArray();  //złączenie dwóch tablic array /0, 1, 2, 3 ......, 11/
			return SumTab;
		}


		public int[][] SumTwoTable2()
		{
			//int t1 = 5;
			//int t2 = 7;
			//int[] SumTab1 = new int[t1];
			//int[] SumTab2 = new int[t2];

			for(int i=0; i<t1; i++)
			{
				SumTab1[i] = i;
			}

			for(int i = 0; i<t2; i++)
			{
				SumTab2[i] = (t1) + i;
			}

			var SumTab = new [] { SumTab1, SumTab2 }; //powstanie tablicy 2 wymiarowej [0][5] i [1][7]
			return SumTab;
		}
	}
}
