namespace Easy
{
    public class EasyProgram : _001___Two_Sum
    {
        public static void Main()
        {
            Console.WriteLine("Hello world");
            int[] example = { 1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1 };

            int[] output = TwoSum_2(example, 11);
            foreach (int i in output)
            {
                Console.WriteLine($"{i}: {example[i]}");
            }
        }


        public static string GetClass()
        {
            return "Easy";
        }
    }
}