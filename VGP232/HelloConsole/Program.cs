using System; // namespace

namespace HelloConsole
{
    class Program
    {
        static void Main(string[] args) // main
        {
            Car car1 = new Car() { Doors = 10, Milege = 99 };

            Console.WriteLine(car1);

            bool isAwesome = false;

            //string importantName = "";

            //if (isAwesome)
            //{
            //    importantName = "Rick";
            //}
            //else
            //{
            //    importantName = "Neil";
            //}

            string importantName = isAwesome ? "Rick" : "Neil";
            int count = 2;
            count += 2;
            count = count + 2;
            string message = string.Format("{0} has {1} {2}", "Bob", count, count > 1 ? "messages" : "message");


            // this is comment
            Console.WriteLine("Hello VGP232");

            string name = "Lawrence";

            Console.WriteLine(name);

            char character = 'L';

            string path = "C:\\temp\\\"no thing\"\\";
            string path2 = @"C:\temp\'no thing'";

            for (int i = 0; i < 1000; i++)
            {
                path += i;
            }

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append(path);
            for (int i = 0; i < 10; i++)
            {
                sb.Append(i);
            }
            sb.ToString();

            // printf("%s %d", "hello", 10);\
            // itoa
            // atoi, scanf(buffer, "%d", &number)

            int someNumber = 10;
            string stringNumber = "1000";
            int newNumber = int.Parse(stringNumber);
            
            //int anotherNumber = (int)stringNumber;

            Console.WriteLine("{0} {1} {1}", path2, someNumber.ToString());


            path += "batman.exe";
            Console.WriteLine(path2);

            Console.WriteLine(path.ToUpper());
            Console.WriteLine(path);
            //path[0] = 'E';
            Console.WriteLine(path[5]);



            Console.WriteLine(character);

            int uNumber = 0;
            MakeChangesToThis(ref uNumber);

            MakeSomething(out uNumber);

            Foo(1);
            Foo(1, 1.1f);

            SomeFunctionA(price: 12, number: 1);

            Console.ReadKey();
        }

        static void Foo(int number, float price = 0.1f)
        {

        }

        static void SomeFunctionA(int number, float price = 0.0f, float something = 0.0f, float something2 = 0.0f)
        {

        }


        static void MakeChangesToThis(ref int someNumber)
        {

        }

        static void MakeSomething(out int someNumber)
        {
            someNumber = 10;
        }

        }
    }
