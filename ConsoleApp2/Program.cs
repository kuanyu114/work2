

using System.Collections.Generic;

int[] list = new int[] { 1, 2, 4, 7, 0, 0, 7, 5 };
int[] list1 = new int[] { 1, 0, 2, 4, 0, 5, 7 };
int[] list2 = new int[] { 1, 7, 2, 0, 4, 5, 0 };
int[] list3 = new int[] { 1, 7, 2, 7, 4, 5, 0 };

bool result = new newFunction().checkArry(list);
Console.WriteLine("result1" + result);
result = new newFunction().checkArry(list1);
Console.WriteLine("result2" + result);
result = new newFunction().checkArry(list2);
Console.WriteLine("result3" + result);
result = new newFunction().checkArry(list3);
Console.WriteLine("result4" + result);

public class newFunction
{
    public bool checkArry(int[] ints)
    {
        int[] checklist = new int[] { 0, 0, 7 };
        bool result = false;
        int count = 0;
        int index = 0;
        foreach (var item in checklist)
        {
            for (int i = index; i < ints.Length; i++)
            {
                if (ints[i] == item)
                {
                    count++;
                    index= i;
                    break;
                }
            }
        }
        if(count == 3)
            result= true;
        return result;
    }
}
