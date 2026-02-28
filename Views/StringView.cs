using System;
using StringProcessingApp.Services;


namespace StringProcessingApp.Views
{
    public class StringView
    {
        private StringService service = new StringService();

        public void Run()
        {
            bool running = true;

            while (running)
            {
                ShowMenu();

                Console.Write("Choose option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        EnterText();
                        break;

                    case 2:
                        ViewText();
                        break;

                    case 3:
                        service.ToUpperCase();
                        Console.WriteLine("Converted to UPPERCASE.");
                        break;

                    case 4:
                        service.ToLowerCase();
                        Console.WriteLine("Converted to lowercase.");
                        break;

                    case 5:
                        Console.WriteLine("Characters: " +
                        service.CountCharacters());
                        break;

                    case 6:
                        CheckContains();
                        break;

                    case 7:
                        ReplaceWord();
                        break;

                    case 8:
                        ExtractSubstring();
                        break;

                    case 9:
                        service.TrimSpaces();
                        Console.WriteLine("Spaces trimmed.");
                        break;

                    case 10:
                        service.ResetText();
                        Console.WriteLine("Text reset.");
                        break;

                    case 11:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.WriteLine();
            }
        }

        private void ShowMenu()
        {
            Console.WriteLine("==== STRING PROCESSING SYSTEM ====");
            Console.WriteLine("1. Enter Text");
            Console.WriteLine("2. View Current Text");
            Console.WriteLine("3. Convert to UPPERCASE");
            Console.WriteLine("4. Convert to lowercase");
            Console.WriteLine("5. Count Characters");
            Console.WriteLine("6. Check if Contains Word");
            Console.WriteLine("7. Replace Word");
            Console.WriteLine("8. Extract Substring");
            Console.WriteLine("9. Trim Spaces");
            Console.WriteLine("10. Reset Text");
            Console.WriteLine("11. Exit");
        }

        private void EnterText()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            service.SetText(text);
        }

        private void ViewText()
        {
            Console.WriteLine("Current Text: " +
            service.GetText());
        }

        private void CheckContains()
        {
            Console.Write("Enter word: ");
            string word = Console.ReadLine();

            if (service.ContainsWord(word))
                Console.WriteLine("Word found.");
            else
                Console.WriteLine("Word not found.");
        }

        private void ReplaceWord()
        {
            Console.Write("Old word: ");
            string oldWord = Console.ReadLine();

            Console.Write("New word: ");
            string newWord = Console.ReadLine();

            service.ReplaceWord(oldWord, newWord);

            Console.WriteLine("Word replaced.");
        }

        private void ExtractSubstring()
        {
            Console.Write("Start index: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            string result =
            service.ExtractSubstring(start, length);

            Console.WriteLine("Substring: " + result);
        }
    }
}
