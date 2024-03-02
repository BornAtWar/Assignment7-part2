using System.Reflection.Metadata.Ecma335;

namespace Assignment7_part2
    //Author: Demetrius Richards
    //Course: COMP003A-L01
    //Purpose: Assignment 7
{
    class Program
    {
        static void Main()
        {






            static void
            SectionSeparator(string input)
            {

            }

            static int CharacterCounter(char characterInput, string word)
            {
                int count = 0;
                foreach (char c in word.ToLower())
                {
                    if (char.ToLower(c) == characterInput)
                    {
                        count++;
                    }
                }
                return count;

            }

            static bool IsPalindrome(string word)
            {
                string reversedWord = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversedWord += char.ToLower(word[i]);
                }
                return word.ToLower() == reversedWord;
            }

            static void TraverseList(List<string> list)
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(list[i]);
                }
            }
            

            static void TraverseListReverse(List<string> list)
            {

                for (int i = list.Count - 1; i >= 0; i--)
                {
                    string reversedItem = (list[i]);
                    Console.WriteLine(reversedItem);
                }
            }

           
            Console.WriteLine("************************************");
            Console.WriteLine("Array - CharacterCounter Section");
            Console.WriteLine("************************************");
            Console.WriteLine("Enter a single letter: ");
            char userLetter = Console.ReadLine()[0]; //Read first letter entered by user
            Console.WriteLine("Enter a word: ");
            string userWord = Console.ReadLine();
            int count = CharacterCounter(userLetter, userWord); //Calling method
            Console.WriteLine($"The character '{userLetter}' appears {count} time(s) in the word '{userWord}'.");

            Console.WriteLine("***********************************");
            Console.WriteLine("Array - IsPalindrome Section");
            Console.WriteLine("***********************************");
            Console.WriteLine("Enter a word: ");
            string userPalindrome = Console.ReadLine(); 
            bool isPal = IsPalindrome(userPalindrome); //Calling method
            Console.WriteLine($"Is the word '{userPalindrome}' a palindrome? {isPal}"); //Output should be true or false

            Console.WriteLine("**********************************");
            Console.WriteLine("List - Add Section");
            Console.WriteLine("**********************************");
            List<string> names = new List<string>();
            char userInput = default;
            do
            {
                Console.WriteLine("Enter a name: ");
                string name = Console.ReadLine();
                names.Add(name);
                Console.WriteLine("Press (e) to add more or any key to exit");
                userInput = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (userInput == 'e');

            Console.WriteLine("*********************************");
            Console.WriteLine("List - Traversal Section");
            Console.WriteLine("*********************************");
            TraverseList(names);

            Console.WriteLine("*********************************");
            Console.WriteLine("List - Reverse Traversal Section");
            Console.WriteLine("*********************************");
            TraverseListReverse(names);

        } 
    }   
     

}
