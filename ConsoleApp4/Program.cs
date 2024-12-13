namespace ConsoleApp4
{
    internal class Program
    {
        class Box
        {
            public int Value;
        }
        static void Main(string[] args)
        {
            #region
            //Console.WriteLine("please enter number");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 3 == 0 && num % 4 == 0)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}
            #endregion
            #region
            //Console.WriteLine("please enter number");
            //int num = int.Parse(Console.ReadLine());
            //if (num <0)
            //{
            //    Console.WriteLine("number is negaive");
            //}
            //else
            //{
            //    Console.WriteLine("number is positive");
            //}
            #endregion
            #region
            //Console.WriteLine("please enter three numbers");
            //int[] num = new int[3];
            //for (int i = 0; i < num.Length; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    num[i] = number;
            //}

            //Console.WriteLine($"max element =  {num.Max()} " );
            //Console.WriteLine($"max element =  {num.Min()} ");


            #endregion
            #region
            //    Console.WriteLine("please enter number");
            //    int num = int.Parse(Console.ReadLine());
            //    if (num % 2 == 0 )
            //    {
            //        Console.WriteLine("even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("odd");
            //}
            #endregion
            #region
            //Console.WriteLine("please enter letter");
            //   char letter =char.Parse( (Console.ReadLine()));
            //  letter = char.ToLower(letter);
            //    if (letter  == 'o'|| letter == 'i' || letter == 'a' || letter == 'u' || letter == 'e' )
            //    {
            //       Console.WriteLine("vowels");
            //   }
            //   else
            //   {
            //      Console.WriteLine("Consonant");
            //}
            #endregion

            #region
            //Console.WriteLine("please enter number");
            //int num = int.Parse( (Console.ReadLine()));
            //    int[]number = new int[12];
            //for (int i = 0; i < number.Length; i++)
            //{
            //    number[i]= num*(i+1);
            //    Console.WriteLine(number[i]);
            //}

            #endregion
            //int result = 1;
            //Console.WriteLine("please enter number one");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("please enter number two");
            //int num2 = int.Parse(Console.ReadLine());
            //for (int i = 0; i < num2; i++)
            //{
            //    result = result * num1;
            //}
            //Console.WriteLine(result);

            #region
            //int sum=0; 
            //Console.WriteLine("please enter grade of five subjects");

            //for (int i = 0; i < 5; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    sum += number;
            //}
            //Console.WriteLine($"total = {sum }");
            //Console.WriteLine($"average = {sum/5}");
            //Console.WriteLine($"persentage = {sum / 5} %");

            #endregion
            #region
            //Console.WriteLine("please number of month");
            //int monthnumber = int.Parse(Console.ReadLine());
            //if (monthnumber == 1 || monthnumber == 3 || monthnumber == 5 || monthnumber == 7 || monthnumber == 8 || monthnumber == 10 || monthnumber == 12)
            //{
            //    Console.WriteLine("this month has 31 days");
            //}
            //else if (monthnumber == 2)
            //{
            //    Console.WriteLine("this month has 28 days");
            //}
            //else if (monthnumber == 4 || monthnumber == 6 || monthnumber == 9 || monthnumber == 11)
            //{
            //    Console.WriteLine("this month has 30 days");
            //}
            //else {
            //    Console.WriteLine("please enter a valid month number");
            //}

            #endregion
            #region
            //Console.WriteLine("Enter coordinates of the first point (x1, y1):");
            //Console.Write("x1: ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("y1: ");
            //double y1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter coordinates of the second point (x2, y2):");
            //Console.Write("x2: ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("y2: ");
            //double y2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter coordinates of the third point (x3, y3):");
            //Console.Write("x3: ");
            //double x3 = double.Parse(Console.ReadLine());
            //Console.Write("y3: ");
            //double y3 = double.Parse(Console.ReadLine());

            //if ((x2 - x1) * (y3 - y2) == (x3 - x2) * (y2 - y1))
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a single straight line.");
            //}
            #endregion
            #region
            //double duration = double.Parse(Console.ReadLine());
            //if (duration >= 2 && duration <=3)
            //{
            //    Console.WriteLine("highly efficient");
            //}
            //else if (duration > 3 && duration <= 4)
            //{
            //    Console.WriteLine("they are instructed to increase their speed");
            //}
            //else if (duration > 4 && duration <=5)
            //{
            //    Console.WriteLine(" they are provided with training to enhance their speed.");

            //}
            //else if (duration > 5)
            //{
            //    Console.WriteLine("The worker is required to leave the company.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. duration must be 2 hours or more.");
            //}
            #endregion
            #region
            //when i change value of num1, the value of num2 will still same
            //int num1 = 10;
            //int num2 = num1;

            //Console.WriteLine("Before modifying:");
            //Console.WriteLine($"firstNumber: {num1}");
            //Console.WriteLine($"secondNumber: {num2}");

            //num1 = 20;

            //Console.WriteLine("After modifying firstNumber:");
            //Console.WriteLine($"firstNumber: {num1}");
            //Console.WriteLine($"secondNumber: {num2}");
            #endregion
            #region
            //when i change value of box2 , the value of box1 will be changed also
            //Box box1 = new Box { Value = 10 };
            //Box box2 = box1;

            //Console.WriteLine("Before modifying:");
            //Console.WriteLine($"box1.Value: {box1.Value}");
            //Console.WriteLine($"box2.Value: {box2.Value}");
            //box2.Value = 20;
            //Console.WriteLine("After modifying box2.Value:");
            //Console.WriteLine($"box1.Value: {box1.Value}");
            //Console.WriteLine($"box2.Value: {box2.Value}");
            #endregion

            #region
            // answer will be (A value 1 will be assigned to d).
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d);
            #endregion
            #region
            // the answer will be (6 1) .
            //Console.WriteLine(13 / 2 + " " + 13 % 2);

            #endregion
            #region
            // answer will be (7 7)
            int num = 1, z = 5;


            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);
            #endregion
        }
    }
}
