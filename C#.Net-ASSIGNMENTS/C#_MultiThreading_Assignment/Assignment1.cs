namespace C__MultiThreading_Assignment
{
    internal class Assignment1
    {
        
            static int[] partialSums = new int[5];

            static void Main()
            {
                List<int> numbers = new List<int>();

                for (int i = 1; i <= 50; i++)
                {
                    numbers.Add(i);
                }

                Thread[] threads = new Thread[5];

                for (int i = 0; i < 5; i++)
                {
                    int start = i * 10;   
                    int end = start + 10; 
                    int threadIndex = i;

                    threads[i] = new Thread(() =>
                    {
                        int sum = 0;

                        Console.WriteLine($"\nThread {threadIndex + 1} processing:");

                        Console.WriteLine();


                        for (int j = start; j < end; j++)
                        {
                            Console.Write(numbers[j] + " ");

                            Console.WriteLine();
                            sum += numbers[j];
                        }

                        partialSums[threadIndex] = sum;

                        Console.WriteLine($"\nThread {threadIndex + 1} Sum: {sum}");
                    });

                    Console.WriteLine();

                    threads[i].Start();
                }

                for (int i = 0; i < 5; i++)
                {
                    threads[i].Join();
                }

                int finalSum = 0;
                foreach (var s in partialSums)
                {
                    finalSum += s;
                }

                Console.WriteLine("\nFinal Sum: " + finalSum);

            }
        
    }

}
