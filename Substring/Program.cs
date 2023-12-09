string subStringToRemove = Console.ReadLine();
string stringToManipulate = Console.ReadLine();

for (int i = 0; i < stringToManipulate.Length; i++)
{
    if (i + (subStringToRemove.Length - 1) > stringToManipulate.Length - 1)
    {
        break;
    }
    else
    {
        string substring = stringToManipulate.Substring(i, subStringToRemove.Length);

        if (substring == subStringToRemove)
        {
            stringToManipulate = stringToManipulate.Remove(i, subStringToRemove.Length);
            i = -1;
        }
    }
}

Console.WriteLine(stringToManipulate);