namespace MyFirstProgram
{
    internal class Program
    {
        //Viktoria Wallström .NET23
        static void Main(string[] args)
        {
            
            int Number = 15;
            
            if (Number > 10)
            { 
                Console.WriteLine("Talet är stort!");
            }
            else if (Number < 10)
            {
                Console.WriteLine("Talet är lågt.");
            }
           
            Console.WriteLine("Vad heter du?");

            string name = Console.ReadLine();

            Console.WriteLine("Hej " + name + ("!"));

            
            for (int i = 0; i<16; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}