using System;

namespace AbilityScore_Calc
{
    class Program
    {
        static int ReadInt(int LastUsedValue ,string prompt)
        {
            Console.Write("{0} [{1}]", prompt, LastUsedValue);
            string line = Console.ReadLine();

            if (int.TryParse(line, out int value))
            {
                Console.WriteLine("      Using value {0}", value);
                return value;
            }
            else
            {
                Console.WriteLine("      Using value {0}",LastUsedValue);
                return LastUsedValue;
            }
        }
        static double ReadDouble(double LastUsedValue ,string prompt)
        {
            Console.Write("{0} [{1}]", prompt, LastUsedValue);
            string line = Console.ReadLine();
            if (double.TryParse(line, out double value))
            {
                Console.WriteLine("      Using value {0}", value);
                return value;
            }
            else
            {
                Console.WriteLine("      Using defult value {0}", LastUsedValue);
                return LastUsedValue;
            }
        }        
        static void Main(string[] args)
        {
            CalculateAbilityScore calculator = new CalculateAbilityScore();
            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "starting 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add Amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScoree();
                Console.WriteLine("Calculated ability score :{0}", calculator.score);
                Console.WriteLine("Press Q To Quit , Any other key to Continue");
                char KeyChar = Console.ReadKey(true).KeyChar;
                if ((KeyChar == 'Q') || (KeyChar == 'q')) return;
            }
        }
    }
    class CalculateAbilityScore
    {
        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int score;

        public void CalculateAbilityScoree()
        {
            double divided = RollResult / DivideBy;

            int added = AddAmount += (int)divided;

            if (added < Minimum)
            {
                score = Minimum;
            }
            else
            {
                score = added;
            }           
        }
    }
}
