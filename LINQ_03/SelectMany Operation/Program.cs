

internal class Program
{
    private static void Main(string[] args)
    {
        RunExample01();

        Console.ReadKey();
    }
        static void RunExample01()
        {
        string[] sentences = {
                "I love asp.net core",
                "I like sql server also",
                "in general i love programming"
        };

            var words = sentences.Select(x => x.Split(' '));
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    
}