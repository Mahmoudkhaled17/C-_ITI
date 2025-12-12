namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The number of class of the school");
            int numberOfClasses = int.Parse(Console.ReadLine());

            int[][] school = new int[numberOfClasses][];
            Console.WriteLine($"Enter the number of students in Each class");
            for (int i=0;i<numberOfClasses;i++)
            {
                Console.Write($"Class {i + 1} number of studient: ");
                int numberOfStudents = int.Parse(Console.ReadLine());
                school[i] = new int[numberOfStudents];
                for (int j=0;j<numberOfStudents;j++)
                {
                    Console.Write($"Enter the marks of Student {j + 1} in class{i+1}: ");
                    school[i][j] = int.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("get average of each class:");

            for(int i=0;i<numberOfClasses;i++)
            {
                int sum = 0;
                for(int j=0;j<school[i].Length;j++)
                {
                    sum += school[i][j];
                }
                double average = (double)sum / school[i].Length;
                Console.WriteLine($"Average marks of class {i + 1}: {average}");
            }





        }
    }
}
