using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr1._2_sem2
{
    public class FileLogger
    {
        private const string FilePath = "logPD23.txt";

        public void OnMessageReceived(string message)
        {
            string logEntry = $"[{DateTime.Now:G}] {message}";

            File.AppendAllText(FilePath, logEntry + Environment.NewLine);
        }
    }
}
