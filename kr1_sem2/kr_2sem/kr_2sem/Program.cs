using static kr_2sem.Operation;

namespace kr_2sem
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Directory.GetCurrentDirectory());

            string inputFile = "textPD23.txt";
            string outputFile = "resultPD23.txt";

            File.WriteAllText(outputFile, "");

            ProcessFiles processor = new ProcessFiles();

            processor.ProcessFile(inputFile, outputFile, TextOperations.ToUpperCase);
            processor.ProcessFile(inputFile, outputFile, TextOperations.CountCharacters);
            processor.ProcessFile(inputFile, outputFile, TextOperations.CountWords);
        }
    }
}
