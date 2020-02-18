
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LinqExercise10
{
    static void Main(string[] args)
    {
        int j = 0;
        int memberslist, s, m;
        List<int> templist = new List<int>();
        Console.Write("\nLINQ : Accept the members of a list and display the members more than a specific value : ");
        Console.Write("\n-------------------------------------------------------------------\n");

        Console.Write("Input the number of members on the List : ");
        m = Convert.ToInt32(Console.ReadLine());

        for (j = 0; j < m; j++)
        {
            Console.Write("Member {0} : ", j);
            memberslist = Convert.ToInt32(Console.ReadLine());
            templist.Add(memberslist);
        }

        Console.Write("\nInput the value above you want to display the members of the List : ");
        m = Convert.ToInt32(Console.ReadLine());

        List<int> FilterList = templist.FindAll(x => x > m ? true : false);
        Console.WriteLine("\nThe numbers greater than {0} are : ", m);
        foreach (var num in FilterList)
        {
            Console.WriteLine(num);
        }

        Console.ReadLine();
    }
}
