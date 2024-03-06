using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Week12_Day2___Random_Password_Generator
{
    static class PasswordGenerator
    {
        public static string[] GeneratePasswords(int length, int count, bool includeSymbols, bool duplicateCharacters = true)
        {
            // ASCII values from 48-57 represent numbers, 65-90 represent UPPER CASE LETTERS and 97-122 represent lower case letters
            // ASCII values from 32-126 represent all symbols, numbers, and UPPER/lower case letters
            string[] passwords = new string[count];

            if (includeSymbols)
            {
                for (int i = 0; i < count; i++)
                {
                    List<int> possibleValues = new List<int>();
                    possibleValues.AddRange(Enumerable.Range(32, 95));              // Second number is count, 126 - 32 = 94 (+1 since last number isn't included)
                    char[] password = new char[length];

                    for (int character=0; character < length; character++)
                    {
                        int rand = new Random().Next(0, possibleValues.Count);
                        password[character] = (char)possibleValues[rand];           // All values
                        if (!duplicateCharacters)
                        {
                            possibleValues.RemoveAt(rand);
                        }
                    }
                    passwords[i] = new string(password);
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    List<int> possibleValues = new List<int>();
                    possibleValues.AddRange(Enumerable.Range(48, 10).ToArray());    // Numbers
                    possibleValues.AddRange(Enumerable.Range(65, 26).ToArray());    // UPPER CASE
                    possibleValues.AddRange(Enumerable.Range(97, 26).ToArray());    // lower case
                    char[] password = new char[length];

                    for (int character = 0; character <length; character++)
                    {
                        int rand = new Random().Next(0, possibleValues.Count);
                        password[character] = (char)possibleValues[rand];
                        if (!duplicateCharacters)
                        {
                            possibleValues.RemoveAt(rand);
                        }
                    }
                    passwords[i] = new string(password);
                }
            }

            return passwords;
        }

        public static string[] GeneratePasswordsWithNoDuplicateCharacters(int length, int count, bool includeSymbols)
        {
            return GeneratePasswords(length, count, includeSymbols, false);
        }
    }
}
