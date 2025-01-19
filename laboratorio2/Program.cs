using System;

namespace StringOperationsApp
{
  
    class Lab2
    {
        static void Main(string[] args)
        {
          
            StringProcessor processor = new StringProcessor("New processor");
            Console.WriteLine("Valor Sting con el que se creo processor" + processor.InputString);
            string joinedString = processor.SplitAndJoin();
            Console.WriteLine("Dividido y unido: " + joinedString);
            string substring = processor.GetSubstring(0, 5);
            Console.WriteLine("Substring: " + substring);
            bool comparisonResult = processor.CompareStrings("Old processor");
            Console.WriteLine((comparisonResult ? "Igual" : "Diferente"));
            bool contains = processor.ContainsSubstring("New");
            Console.WriteLine( (contains ? "Sí" : "No"));
        }
    }
    class StringProcessor
    {
        private string inputString;
        public string InputString
        {
            get { return inputString; }
            set { inputString = value; }
        }
        public StringProcessor(string input)
        {
            inputString = input;
        }
        ~StringProcessor()
        {
            Console.WriteLine("Instancia de StringProcessor destruida.");
        }
        public string SplitAndJoin()
        {
            char[] charArray = inputString.ToCharArray();
            return new string(charArray); 
        }
        public string GetSubstring(int startIndex, int length)
        {
            if (startIndex >= 0 && startIndex + length <= inputString.Length)
            {
                return inputString.Substring(startIndex, length);
            }
            return "Índice inválido";
        }
        public bool CompareStrings(string otherString)
        {
            return inputString.Equals(otherString);
        }
        public bool ContainsSubstring(string substring)
        {
            return inputString.Contains(substring);
        }
    }
}
