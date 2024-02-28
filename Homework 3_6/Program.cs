namespace Homework_3_6
{
    internal class Program
    {
        static void Main()
        {
            Messagebox messagebox = new Messagebox();
            messagebox.WindowClosed += (sender, state) =>
            {
                if (state == State.Ok)
                { Console.WriteLine("The operation has been confirmed"); }
                else if (state == State.Cancel)
                {
                    Console.WriteLine("The operation was rejected");
                }
            };
            messagebox.Open();
        }
    }
}
