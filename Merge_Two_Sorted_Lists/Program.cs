class Task
{
    public static void Main (string[] args)
    {
        List<int> list1 = new List<int> { 4, 5, 6 };
        List<int> list2 = new List<int> { 12, 16, 18, 21 };
        List<int> mergeList = Logic.MergeList(list1, list2);

        //print all numbers in column
        int number = 0;
        foreach (int item in mergeList)
        {
            Console.WriteLine($"Number {number} from merged list: {item}");
            number++;
        }
        // print in one line separeted with coma
        Console.WriteLine("");
        string oneLineResults = string.Join(",", mergeList);
        Console.WriteLine($"Printed in one line {oneLineResults}" );

        // print reversed list
        Console.WriteLine("");
        ReverseList reverseList = new ReverseList();
        List<string> reversedResults = reverseList.Reverse(oneLineResults.Split(',').ToList());

        string reversedString = string.Join(", ", reversedResults);
        Console.WriteLine($"Reversed list: {reversedString}");

        //Print sum of reversed list values
        Console.WriteLine("");
        SumOfList sumOfList = new SumOfList();
     int total = sumOfList.SumOfValuesFromList(mergeList);
        Console.WriteLine($"Sum of reversed values = {total}");
    }
}

public class Logic
{
    public static List<T> MergeList<T>(List<T> list1, List<T> list2)
    {
        List<T> result = new List<T>(list1);
        result.AddRange(list2);
        return result;
    }
}

public class ReverseList 
{  
   public List<T> Reverse<T>(List<T> list)
    {
     list.Reverse();
        return list;
    }
}

public class SumOfList
{
    public dynamic SumOfValuesFromList<T>(List<T> list) 
    {
        
        dynamic result =0;
        foreach(T line in list)
        {
            result += (dynamic)line;
        }
        return result;
    }
}