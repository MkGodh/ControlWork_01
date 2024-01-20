string[] array1 = new string[8] {"Hey", "321", "Madara", "Uchiha", "777", "22", "Shinobi", "Est"};
string[] array2 = new string[array1.Length];

void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}   