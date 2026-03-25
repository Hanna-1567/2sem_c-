using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr_2sem
{
    public class ProcessFiles
    {
        public void ProcessFile(string inputPath, string outputPath, Operation.TextOperation operation) 
        {
            var lines = File.ReadAllLines(inputPath);

            foreach (var line in lines)
            {
                var result = operation(line);
                File.AppendAllText(outputPath, result + System.Environment.NewLine);
            }

            File.AppendAllText(outputPath, "----------------------" + System.Environment.NewLine);
        }
    }
}
