string [] arrayString = {"job", "work", "git", "help", "2"};
int len = arrayString.Length;
int count1 = 0;



for (int i = 0; i < len; i++)
{
    string a = arrayString[i];
    if (a.Length <= 3)
    {
        count1++;
    } 
}

string [] arrNew = new string[count1];
int count2 = 0;

for (int i = 0; i < len; i++)
{
    string a = arrayString[i];
    if (a.Length <= 3)
    {
        for (int j = 0; j < count1; j++)
        {
            arrNew[count2] = a;
        }
        count2++;
    }
}

Console.WriteLine("[" + string.Join(", ", arrayString) + "]" + " - " + "[" + string.Join(", ", arrNew) + "]");