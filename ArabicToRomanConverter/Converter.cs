namespace ArabicToRomanConverter
{
	public class Converter
	{
		public string ToRomain(int arabicNumber)
		{
			string romanNumber = "";
			// Intiution 10, 20 30 => X XX XXX
			var rank10 = arabicNumber / 10;
			if (rank10 != 0)
			{
				romanNumber += new string('X', rank10);
				arabicNumber = arabicNumber - (10 * rank10);
			}
			//if (arabicNumber >= 20)
			//{
			//	romanNumber += "XX";
			//	arabicNumber -= 20;
			//}

			//if (arabicNumber >= 10)
			//{
			//	romanNumber += "X";
			//	arabicNumber -= 10;
			//}
			
			if (arabicNumber == 9)
			{
				romanNumber += "IX";
			}
			else if (arabicNumber >= 5)
			{
				romanNumber += "V";
				arabicNumber -= 5;
			}
			else if (arabicNumber == 4)
			{
				romanNumber += "IV";
			}
			
			if(arabicNumber < 4)
			{
				romanNumber += new string('I', arabicNumber);
			}
			
			return romanNumber;
		}
	}
}