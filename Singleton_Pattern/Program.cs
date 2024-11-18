namespace Singleton_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get the only object available
            SingleObject ob = SingleObject.GetInstance();

            //show the message
            ob.ShowMessage();
            ob.ShowMessage();
            ob = SingleObject.GetInstance();
            ob.ShowMessage();
            ob = SingleObject.GetInstance();
            ob.ShowMessage();

            //If we create instance multiple times then shows the same value, it's called singleton. 
        }
    }
}
