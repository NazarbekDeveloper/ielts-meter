namespace IeltsMaster
{
    public class Printer
    {
        public void PrintLine(string str = "\n")
        {
            Console.WriteLine(str);
        }
        public void Print(string str = "")
        {
            Console.Write(str);
        }
    }
}