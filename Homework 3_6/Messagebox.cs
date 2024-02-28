namespace Homework_3_6
{
    public class Messagebox
    {
        public event EventHandler<State>
        WindowClosed;
        public async void Open()
        {
            Console.WriteLine("Window is open");
            await Task.Delay(3000);
            Console.WriteLine("Window was closed by the user");
            Random rand = new Random();
            State randState = (State)rand.Next(Enum.GetNames(typeof(State)).Length);
            WindowClosed?.Invoke(this, randState);
        }
    }
}
