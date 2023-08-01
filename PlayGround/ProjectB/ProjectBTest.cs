using Interface;

namespace ProjectB
{
    public class ProjectBTest : IProjectTest
    {
        public void Play()
        {
            Console.WriteLine("ProjectB 입니다.");
        }
    }
}