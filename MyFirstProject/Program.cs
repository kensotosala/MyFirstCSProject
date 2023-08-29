namespace MyFirstProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // ➖➖➖ Data Types ➖➖➖
            // 👉 Variables
            string name = "Kendall";
            int age = 19;
            float float_variable = 1.1F;
            bool student = true;

            // 👉 Arrays
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Console.WriteLine(numbers[2]);

            // 👉 Linked List
            List<int> numbersList = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // Console.WriteLine(string.Join(", ", numbers));

            // 👉 Dictionaires
            Dictionary<int, string> players = new();
            players.Add(10, "Colindres");
            players.Add(7, "Johan Venegas");
            // Console.WriteLine(players[7]);

            // 👉 Constants
            const float gravity = 9.8F;
            // Console.WriteLine(gravity);

            // 👉 Operators
            //Console.WriteLine(1 + 1);
            //Console.WriteLine(10 >= 5);
            //Console.WriteLine(1 - 3);
            //Console.WriteLine(2 * 2);
            //Console.WriteLine(10 / 2);
            //Console.WriteLine(5 == 5);
            //Console.WriteLine(2 != 5);
            //Console.WriteLine(1 < 5);

            //Console.WriteLine("--------------------------");

            //Console.WriteLine(true && false);
            //Console.WriteLine(false && true);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine("--------------------------");

            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || true);
            //Console.WriteLine(false || false);


            // 👉 User Input
            //Console.WriteLine("Enter your name: ");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("Your name is: " + nombre);


            // 👉 Conditionals
            //age = 18;

            //if (age >= 18)
            //{
            //    Console.WriteLine("You are an adult");
            //}
            //else
            //{
            //    Console.WriteLine("You are not an adult");
            //}

            // Switch
            age = 17;

            switch (age)
            {
                case 18:
                    Console.WriteLine("You are an adult.");
                    break;
                case 16:
                    Console.WriteLine("You are a teenager.");
                    break;
                default:
                    Console.WriteLine("You are a minor.");
                    break;
            }
        }
    }
}