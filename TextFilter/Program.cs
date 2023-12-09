string[] bannedWords = Console.ReadLine()
                       .Split(", ")
                       .ToArray();

string textToCheck = Console.ReadLine();

for (int i = 0; i < textToCheck.Length; i++)
{
    for (int j = 0; j < bannedWords.Length; j++)
    {
        if (i + (bannedWords[j].Length - 1) > textToCheck.Length - 1)
        {
            break;
        }
        else
        {
            string currentSubString = textToCheck.Substring(i, bannedWords[j].Length);

            if (bannedWords[j] == currentSubString)
            {
                string starsToPut = string.Empty;

                for (int k = 0; k < bannedWords[j].Length; k++)
                {
                    starsToPut += "*";
                }

                textToCheck = textToCheck.Replace(currentSubString, starsToPut);
            }
        }
    }
}

Console.WriteLine(textToCheck);