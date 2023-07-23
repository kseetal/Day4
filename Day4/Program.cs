#region Part 1
public class Day3
{
    public static void Main()
    {
        string line;
        string[] groups, group1Params, group2Params;
        int count = 0;
        while ((line = Console.ReadLine()) != string.Empty)
        {
            groups = line.Split(",");
            group1Params = groups[0].Split("-");
            group2Params = groups[1].Split("-");
            var decodedG1 = new List<int>();
            var decodedG2 = new List<int>();
            int group1Start = int.Parse(group1Params[0]);
            int group1End = int.Parse(group1Params[1]);
            if (group1Start == group1End)
            {
                decodedG1.Add(group1Start);
            }
            else { 
                for (int i = group1Start; i <= group1End; i++)
                {
                    decodedG1.Add(i);
                }
            }

            int group2Start = int.Parse(group2Params[0]);
            int group2End = int.Parse(group2Params[1]);
            if (group2Start == group2End)
            {
                decodedG2.Add(group2Start);
            }
            else
            {
                for (int i = group2Start; i <= group2End; i++)
                {
                    decodedG2.Add(i);
                }
            }

            bool found = true;
            if (decodedG1.Count >= decodedG2.Count)
            {
                foreach (int value in decodedG2)
                {
                    if (!decodedG1.Contains(value))
                    {
                        found = false;
                    }
                    if (!found)
                    {
                        break;
                    }
                }

                if (found)
                    count++;
            } else
            {
                foreach (int value in decodedG1)
                {
                    if (!decodedG2.Contains(value))
                    {
                        found = false;
                    }
                    if (!found)
                        break;
                }

                if (found)
                    count++;
            }
        }

        Console.WriteLine(count);
    }
}

#endregion

#region Part 2
//public class Day3
//{
//    public static void Main()
//    {
//        string line;
//        string[] groups, group1Params, group2Params;
//        int count = 0;
//        while ((line = Console.ReadLine()) != string.Empty)
//        {
//            groups = line.Split(",");
//            group1Params = groups[0].Split("-");
//            group2Params = groups[1].Split("-");
//            var decodedG1 = new List<int>();
//            var decodedG2 = new List<int>();
//            int group1Start = int.Parse(group1Params[0]);
//            int group1End = int.Parse(group1Params[1]);
//            if (group1Start == group1End)
//            {
//                decodedG1.Add(group1Start);
//            }
//            else
//            {
//                for (int i = group1Start; i <= group1End; i++)
//                {
//                    decodedG1.Add(i);
//                }
//            }

//            int group2Start = int.Parse(group2Params[0]);
//            int group2End = int.Parse(group2Params[1]);
//            if (group2Start == group2End)
//            {
//                decodedG2.Add(group2Start);
//            }
//            else
//            {
//                for (int i = group2Start; i <= group2End; i++)
//                {
//                    decodedG2.Add(i);
//                }
//            }

//            bool found = false;
//            if (decodedG1.Count >= decodedG2.Count)
//            {
//                foreach (int value in decodedG2)
//                {
//                    if (decodedG1.Contains(value))
//                    {
//                        found = true;
//                    }
//                    if (found)
//                    {
//                        break;
//                    }
//                }

//                if (found)
//                    count++;
//            }
//            else
//            {
//                foreach (int value in decodedG1)
//                {
//                    if (decodedG2.Contains(value))
//                    {
//                        found = true;
//                    }
//                    if (found)
//                        break;
//                }

//                if (found)
//                    count++;
//            }
//        }

//        Console.WriteLine(count);
//    }
//}

#endregion