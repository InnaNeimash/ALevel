namespace Homework_3_5
{
    internal class Program
    {
        static async Task Main()
        {
            string combinedText = await ConcatenateTextAsync();
            Console.WriteLine("Concatenated text:" + combinedText);
        }
        static async Task<string>ConcatenateTextAsync()
        {
            Task<string> helloTask = ReadFileAsync("Hello.txt");
            Task<string> worldTask = ReadFileAsync("World.txt");
            string helloText = await helloTask;
            string worldText = await worldTask;
            return helloText + "" + worldText;
        }
        static async Task<string>ReadFileAsync(string fileName)
        {
            using StreamReader reader = new StreamReader(fileName);
            return await reader.ReadToEndAsync();
        }
    }
}
