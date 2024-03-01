namespace Hello_World
{

    /// <summary>
    /// Represents a class for displaying greetings.
    /// </summary>
    public class Hello
    {
        /// <summary>
        /// Displays the "Hello, World!" greeting.
        /// </summary>
        public static void DisplayGreeting()
        {
            Console.WriteLine("Hello, World!");
        }
    }

    /// <summary>
    /// The main class of the program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The entry point of the program.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            ArgumentNullException.ThrowIfNull(args);
            // Creates an instance of the Hello class.
            Hello hello = new();
            // Calls the method to display the greeting.
            Hello.DisplayGreeting();
        }
    }
}