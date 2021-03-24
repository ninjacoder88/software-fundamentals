namespace ForLoops
{
    public class ForLoopsDemo
    {
        public void Example()
        {
            for(int i = 0; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                    continue;
                }
            }
        }
    }
}