namespace CCG_TechnicalTest_GFoster
{
    public interface IConsoleManager
    {
        void Write(string value);
        void WriteLine(string value);
        ConsoleKeyInfo ReadKey();
        string ReadLine();
        void Clear();
    }
}
