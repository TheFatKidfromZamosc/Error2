// Program counts the lenghs of the string
// Input : aaa
// Output : 3
namespace licznik_stringa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string :");
            string s = Console.ReadLine();

            Console.WriteLine("The string lenght is : " + (s.Length+3));
        }
    }
}
