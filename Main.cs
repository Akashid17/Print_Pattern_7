
using System;

class PatternX
{
	public void Display(int iNo)
	{
		if(iNo < 0)
		{
			iNo = -iNo;
		}

		int iCnt = 1;

		do
		{
			Console.Write(iCnt*2+"\t");
			iCnt++;

		} while(iCnt <= iNo);

		Console.WriteLine();
	}
}

class main
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter Number");
		int iValue = Convert.ToInt32(Console.ReadLine());

		PatternX pobj = new PatternX();
		pobj.Display(iValue);
	}
}