namespace ArabicToRomanConverter
{
    public class Converter
    {
        public string ToRomain(int arabicNumber)
        {
            string romanNumber = "";
            // Intuition 10, 20 30 => X XX XXX

            if (arabicNumber >= 400)
            {
                romanNumber += "CD";
                arabicNumber -= 400;
            }
          
            var rank100 = arabicNumber / 100;
            if (rank100 != 0)
            {
                romanNumber += new string('C', rank100);
                arabicNumber = arabicNumber - (100 * rank100);
            }

            if (arabicNumber >= 90)
            {
                romanNumber += "XC";
                arabicNumber -= 90;
            }
          
            if (arabicNumber >= 50)
            {
                romanNumber += "L";
                arabicNumber -= 50;
            }
          
            if (arabicNumber >= 40)
            {
                romanNumber += "XL";
                arabicNumber -= 40;
            }

            var rank10 = arabicNumber / 10;
            if (rank10 != 0)
            {
                romanNumber += new string('X', rank10);
                arabicNumber = arabicNumber - (10 * rank10);
            }

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

            if (arabicNumber < 4)
            {
                romanNumber += new string('I', arabicNumber);
            }

            return romanNumber;
        }
    }
}