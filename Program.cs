using System.Diagnostics.Tracing;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace Lesson_2C
{
    enum Status
    {
        ofline,online,unknown
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //string[] statusEnum = Enum.GetNames(typeof(Status));

            //foreach(string status in statusEnum)
            //{
            //    Console.WriteLine(status);
            //}

            //Status userstatus = Status.online;

            //StringBuilder sb = new StringBuilder();

            //Console.WriteLine(sb.Capacity);
            //Console.WriteLine(sb.Length);
            //Console.WriteLine(sb.MaxCapacity);

            //sb.Append("Hello");
            //sb.Append("World");

            //string str = sb.ToString();

            //string str = "";
            //str += "Hello";
            //str += " World";

            //string str = "   Hello     "

            //Console.WriteLine(str);
            //Console.WriteLine(str.Trim());
            //Console.WriteLine(str.TrimStart());
            //Console.WriteLine(str.TrimEnd());

            //int[] number = { 20, 10, 40, 1 };
            //string numStr = string.Join(' ', number);
            //Console.WriteLine(numStr);

            //string str = "Hello world";

            //string str2 = "Hello" + " " + "World";
            //Console.WriteLine(str2);

            //Console.WriteLine(str.ToLower());
            //Console.WriteLine(str.Insert(5,"SUBSTR"));
            //string[] words = str.Split(' ');
            //Console.WriteLine(words.Length);

            //Console.WriteLine(str[0]);

            //str = str.Replace('H', 'D');



            //str.Replace('H', 'D');
            //str.Remove();
            //str.Replace();

            //string str1 = "";
            //string str2 = null;

            //string str3 = new string('c', 10);
            ////string str4 = new string();

            //Console.WriteLine(str);


            //int[] number = { 20, 10, 40, 1 };
            //Console.WriteLine(number.Sum());
            //Console.WriteLine(number.Max());
            //Console.WriteLine(number.Min());
            //Console.WriteLine(number.Average());
            //Console.WriteLine(number.Contains(40));

            //int[] copy = new int[4];
            //number.CopyTo(copy,0);

            //copy[0] = -5;

            //foreach (int i in number)
            //{
            //  Console.WriteLine($"{i}");
            //}

            //Array.Sort(number);

            //int index = Array.BinarySearch(number, 1);

            //Console.WriteLine(index);

            //foreach(int i in number)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //Console.WriteLine();

            ////Array.Reverse(number);
            ////Array.Clear(number);

            //foreach (int i in number)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //int[,] arr2d =
            //{
            //    {1,2,3},
            //    {1,2,3}
            //};

            //int[,,] arr3d = new int[1,1,3]
            //{
            //    {
            //        {1,2,3},
            //    }
            //};

            //Console.WriteLine(arr2d.Rank);
            //Console.WriteLine(arr2d.Length);

            //Console.WriteLine(arr2d.GetLength(0));

            //Console.WriteLine(arr2d[0,2]);

            //object[] obj = { 1, 6.8, true, 'c', "text" };

            //object obj = null;

            //Console.WriteLine(obj.ToString());

            //int[] number = { 10, 20, 30, 40 };
            //int[] number = new int[10];

            //Console.WriteLine(number.Length);
            //Console.WriteLine(number[0].ToString());

            //Console.WriteLine(number.ToString());


            //number.Reverse();

            //foreach (int i in number)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(number[0]);
        }
    }
}
