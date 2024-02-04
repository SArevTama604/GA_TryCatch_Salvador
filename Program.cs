namespace GA_TryCatch_Salvador
{
    internal class Program
    {
        public static object Ex { get; private set; }

        static void Main(string[] args)
        {
            int number = 0;

            try
            {
                Console.WriteLine("Please enter a whole number: ");
                String userInput = Console.ReadLine();
                number = int.Parse(userInput);
            }
            catch(FormatException fex) {

                Console.WriteLine("This was a format exception");
                number = 12;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                number = 42;
            }

            Console.WriteLine(number)


            ;
        }
    }
}
