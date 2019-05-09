using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
	class DynamicTab
	{
		public static string[] MyNewArray(string[] incArray, int increase)
		{
			for(int i = 0; i < increase; i++)
			{
				Array.Resize(ref incArray, incArray.Length + 1);
			}
			return incArray;
		}
	}
}
