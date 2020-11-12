namespace Dotnet5Issue
{
    public interface ITest
    {

    }

    public class Test
    {
        public Test(ITest test = null)
        {

        }

        public string Print()
        {
            return "Hello World";
        }
    }
}