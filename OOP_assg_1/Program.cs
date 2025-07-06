using OOP_assg_1.Enum;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Q1
        //foreach (WeekDays days in Enum.GetValues(typeof(WeekDays)))
        //{
        //    Console.Write(days);
        //} 
        #endregion
        #region Q2
        //season s = new season();
        //object sea;
        //bool isParsed;
        //do
        //{
        //    Console.WriteLine("eneter name of season");
        //    isParsed = Enum.TryParse(typeof(Seas_on), Console.ReadLine(), true, out sea);
        //} while (!isParsed);
        //s.name = sea.ToString();
        //s.name = sea switch
        //{
        //    Seas_on.Spring => "march to may",
        //    Seas_on.Summer => "june to august",
        //    Seas_on.Autumn => "september to november",
        //    Seas_on.Winter => "december to february",
        //    _ => "unknown"
        //};
        //s.display();
        #endregion
        #region Q3
        //user u = new user();
        //u.per |= Permissions.read;
        //Console.WriteLine(u.per);//add read
        ////u.per |= Permissions.write;
        ////Console.WriteLine(u.per);//add write
        ////u.per ^= Permissions.read;
        ////Console.WriteLine(u.per);//delete read keep write
        //if ((u.per & Permissions.read) == Permissions.read)
        //{
        //    Console.WriteLine("found");
        //}
        //else {
        //    Console.WriteLine("not found");
        //}
        #endregion
        #region Q4
        //Colors c;
        //bool isParsed;
        //do
        //{
        //    Console.WriteLine("enter color");
        //    isParsed = Enum.TryParse<Colors>(Console.ReadLine(), true, out c);
        //} while (!isParsed);
        //foreach (Colors color in Enum.GetValues(typeof(Colors)))
        //{
        //    if (c == color)
        //    {
        //        Console.WriteLine($"{c} primary color");
        //        break;
        //    }

        //    else
        //    {
        //        Console.WriteLine($"{c} not primary color");
        //        break;
        //    }
        //}
        #endregion

    }
}