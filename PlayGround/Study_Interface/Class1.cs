namespace Study_Interface
{
    interface ISouce
    {
        int GetResult();
    }
    public class Study_Interface : ISouce
    {
        public int GetResult() { return 10; }
    }
}