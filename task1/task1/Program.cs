namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of studient");
            int studientnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of subject");
            int subjectnumber = Convert.ToInt32(Console.ReadLine());
            int[,] clas = new int[studientnumber, subjectnumber];

            for (int i = 0; i < studientnumber; i++)
            {
                for (int j = 0; j < subjectnumber; j++)
                {
                    Console.WriteLine($"enter the mark of studient {i + 1} in subject {j + 1}");
                    clas[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("calulating the average mark of each subject:");
            int[] sum = new int[subjectnumber];
            int[] average = new int[subjectnumber];
            for (int j = 0; j < subjectnumber; j++)
            {
                for (int i = 0; i < studientnumber; i++)
                {
                    sum[j] += clas[i, j];
                }
                average[j] = sum[j] / studientnumber;
                Console.WriteLine($"the average mark of subject {j + 1} is {average[j]}");


            }

            Console.WriteLine("calulating the sum  of each mark for studient:");

            int[] sumofstudient = new int[studientnumber];
            for (int i = 0; i < studientnumber; i++)
            {
                for (int j = 0; j < subjectnumber; j++)
                {
                    sumofstudient[i] += clas[i, j];
                }
                Console.WriteLine($"the sum of marks for studient {i + 1} is {sumofstudient[i]}");
            }
        }
    }
}
