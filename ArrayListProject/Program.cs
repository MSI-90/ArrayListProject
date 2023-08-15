namespace ArrayListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayTest<int> test = new ArrayTest<int>();
            test.Add(1);
            test.Add(29);
            test.Add(301);

            foreach (int i in test)
                Console.WriteLine(i);
        }
    }
}