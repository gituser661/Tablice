using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
	class Program
	{
		static void Main(string[] args)
		{
			//____________________________________________1
			//int t1 = 50;
			//int t2 = 50;
			//int t3 = 200;
			//int t4 = 20;
			//int dane = 0;

			////tablica dwówymiarowa
			//int[,] myTab = new int[t1, t2];

			//for (int i = 0; i < t1; i++)
			//{
			//	for (int j = 0; j < t2; j++)
			//	{
			//		myTab[i, j] = ++dane;
			//	}
			//}

			//____________________________________________2
			////tablica wielowymiarowa - ta zajmuje dużo pamięci
			//ulong[,,,,,,,] myTab1 = new ulong[10, 10, 10, 10, 10, 10, 10, 10];


			//____________________________________________3
			////tablica tablic
			////deklaracja tablicy
			//int[,][,] myTabTab = new int[t1,t2][,];
			////deklaracja tablic
			//dane = 0;
			//for(int i = 0; i < t1; i++)
			//{
			//	for(int j = 0; j < t2; j++)
			//	{
			//		myTabTab[i, j] = new int[t3, t4];
			//	}
			//}

			////wstawianie danych do tablicy tablic
			//dane = 0;
			//for (int i = 0; i < t1; i++)
			//{
			//	for (int j = 0; j < t2; j++)
			//	{
			//		for(int k = 0; k < t3; k++)
			//		{
			//			for(int l = 0; l < t4; l++)
			//			{
			//				myTabTab[i, j][k, l] = ++dane;
			//			}
			//		}
			//	}
			//}
			//Console.WriteLine("Wstawione dane do tablicy tablic - " + dane);


			//____________________________________________4
			//AddTableToTable addTableToTable = new AddTableToTable();
			//Console.WriteLine(AddTableToTable.SumTwoTable());


			//dynamiczna tablica /tylko jednowymiarowa
			string[] newArray = new string[0];
			int increase = 5;
			newArray = DynamicTab.MyNewArray(newArray, increase);


			//____________________________________________
			Console.ReadKey();
			//+ zmiana1 na Dev
			//+ zmiana2 na Dev
		}
	}
}
