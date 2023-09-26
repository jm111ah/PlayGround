


Study_Interface st = new Study_Interface();


st.test();


interface ISouce
{
    int GetResult();
}
public class Study_Interface : ISouce
{
    public int GetResult() { return 10; }

    public void test()
    {
        Target target = new Target();
        target.Do(this);
    }    
}

class Target
{
    public void Do(ISouce obj)
    {
        Console.WriteLine(obj.GetResult()); 
    }
}