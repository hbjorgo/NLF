namespace HeboTech.NLF.Loggers.Writers
{
    public class DebugWriter : IWriter
    {
        public void Write(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }
    }
}
