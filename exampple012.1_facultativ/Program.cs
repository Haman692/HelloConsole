void FindChar(string[] collection, string anyString)
{
    int len = collection.Length;
    int index = 0;

    string flag = "Такой нет";
    while(index < len)
    {
        if(collection[index] == anyString) 
        {   
            flag = "Да нашли";
            break;
        }
        index++;
    }
     Console.WriteLine(flag);

}


string[] array = {"a", "b", "c", "d", "e","f" };

FindChar(array, "g");