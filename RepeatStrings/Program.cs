string[] inputArr = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

string output = string.Empty;

for (int i = 0; i < inputArr.Length; i++)
{
    int wordLenght = inputArr[i].Length;

    for (int j = 0; j < wordLenght; j++)
    {
        output += inputArr[i];
    }
}

Console.WriteLine(output);