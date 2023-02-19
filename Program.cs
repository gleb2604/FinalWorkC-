string[] array = new string[]   {"Twenty five again",
                                "Twe", "nty", "aga", "in", "=", "45"};

string[] newArray = new string[SearchCount()];

int SearchCount()
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
    if (array[i].Length <= 3)
        {
            count+=1;
        }
    }
    return count;
}
