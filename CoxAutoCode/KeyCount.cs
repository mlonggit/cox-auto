using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace CoxAutoCode
{
    public class KeyCount
    {
        //list to store KeyValuePair
        static List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
        static List<KeyValuePair<string, int>> list2 = new List<KeyValuePair<string, int>>();
        //read inputs from filepath-/CoxAutoCode/KeyValueInput.txt
        static string filePath = (Directory.GetCurrentDirectory().Replace("bin\\Debug", "KeyValueInput.txt"));

        public static void myKeyValuePair()
        {
            if (File.Exists(filePath))
            {
                checkKeyPairValue();
            }
            else
            {
                Console.WriteLine("The file does not exists.");
            }

        }//KeyValuePair

        private static void checkKeyPairValue()
        {
            list.Clear();//clear list
            list2.Clear();
            var reader = new StreamReader(File.OpenRead(filePath));
            
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                list.Add(new KeyValuePair<string, int>(values[0], int.Parse(values[1])));
            }

            //shows what was read
            Console.WriteLine("\tThe elements are :");
            foreach (var element in list)
            {
                Console.WriteLine("\t{0}", element);
            }
            Console.WriteLine("\tList count : {0}", list.Count);
            Console.WriteLine(Environment.NewLine);

            //sort list  
            list = list.OrderBy(x => x.Key).ToList();
            //foreach (var element in list)
            //{
            //    Console.WriteLine("\t{0}", element);
            //}
         
            //get first row from list into list2
            list2.Add(new KeyValuePair<string, int>(list[0].Key, list[0].Value));

            for (int i = 0; i < list.Count - 1; i++)
            {
                int j = list2.Count - 1;
                if (list[i + 1].Key == list2[j].Key)
                {
                    //if exist in list2 update else add new to list2
                    var idx = list2.FindIndex(n => n.Key.Equals(list2[j].Key));
                    if (idx != -1)//idx found return indexAt, not found return -1
                    {
                        var item1 = list2[idx].Value; //existing value found, add to list2
                        var item2 = list[i + 1].Value;//new value to add to sum
                        var item3 = item1 + item2;//sum
                        var addKeyValue = new KeyValuePair<string, int>(list2[j].Key, item3);
                        list2[idx] = addKeyValue;
                    }
                    else
                    {
                        //add new entry to list2
                        list2.Add(list2[i]);
                    }
                }
                else
                {
                    list2.Add(new KeyValuePair<string, int>(list[i + 1].Key, list[i + 1].Value));
                }
            }//for

            //print out total for each keyValuepair
            foreach (KeyValuePair<string, int> item in list2)
            {
                Console.WriteLine("\tThe total for {0} is {1}", item.Key, item.Value);
            }
            Console.WriteLine("\r\n");
        }
    }
}
