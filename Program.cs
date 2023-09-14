namespace MyFirstProgram
{
    internal class Program
    {
        //Viktoria Wallström .NET23
        static void Main(string[] args)
        {
            //Declare an integer variable. 
            int Number = 15;

            // Check if the value of "Number" is greater than 10.
            if (Number > 10)
            { 
                //If "Number" is greater than 10, print this message. 
                Console.WriteLine("Talet är stort!");
            }
            //Check if "Number" is less than 10.
            else if (Number < 10)
            {
                //If "Number" is less than 10, print this message. 
                Console.WriteLine("Talet är lågt.");
            }
           
            //Ask for user input
            Console.WriteLine("Vad heter du?");

            //Read the user input and store it in the "Name" variable.
            string userName = Console.ReadLine();

            //Print "Hej" and the user name. 
            Console.WriteLine("Hej " + userName + ("!"));

            //Use a for loop to iterate from 0 up to 15.
            for (int i = 0; i <= Number; i++)
            {
            
                //Print the current value of "i".
                Console.WriteLine(i);
            
            }

        }
    }
}