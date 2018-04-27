using System;

namespace week_1_capstone_pig_latin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool swither = true;
            while (swither)
            {
                Console.WriteLine("\t\t\tWelcome to the Pig latin Translator!\n");
                // take the input
                Console.Write("Enter a Line to be translated: ");

                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                string userinput = Console.ReadLine();
                int index = userinput.ToLower().IndexOfAny(vowels);
                string part1 = userinput.Split(vowels)[0];

                if (index == 0)
                {
                    Console.WriteLine(userinput + "way");
                }
                else
                {
                    userinput = userinput.Replace(part1, "");
                    Console.WriteLine(userinput + part1 + "ya");
                }
                Console.WriteLine("translat anthor word ? (y/n)");
                string yorn = Console.ReadLine().ToLower();

                if (yorn != "n")
                {
                    continue;
                }
                else
                {
                    swither = false;
                }
            }
        }
   
    }
}