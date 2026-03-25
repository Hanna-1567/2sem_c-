namespace kr1._2_sem2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Directory.GetCurrentDirectory());

            var publisher = new MessagePublisher();
            var logger = new FileLogger();

            publisher.OnMessageSent += logger.OnMessageReceived;

            Console.WriteLine("Введіть 4 повідомлення:");

            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"{i}: ");
                string input = Console.ReadLine();

                publisher.Send(input);
            }

            Console.WriteLine("\nЗапис завершено. Перевірте файл logPD23.txt");
            Console.ReadKey();
        }
    }
}
