using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CompareFiles
{
    public class FileWorker
    {
        public string[] File1 { get; private set; } = File.ReadAllLines("File1.txt");
        public string[] File2 { get; private set; } = File.ReadAllLines("File2.txt");

        int CheckLargeLength()
        {
            if (File1.Length <= File2.Length)
                return File2.Length;
            else
                return File1.Length;
        }
        int CheckLargeLength(char[] mas1, char[] mas2)
        {
            if (mas1.Length <= mas2.Length)
                return mas2.Length;
            else
                return mas1.Length;
        }
        int CheckSmallLength()
        {
            if (File1.Length <= File2.Length)
                return File1.Length;
            else
                return File2.Length;
        }
        int CheckSmallLength(char[] mas1, char[] mas2)
        {
            if (mas1.Length <= mas2.Length)
                return mas1.Length;
            else
                return mas2.Length;
        }
        string AddDelString(string str, string fileString)
        {
            if (str != fileString)
            {
                if (!ChangeString(str, fileString))
                {
                    if (!str.Contains(File2.ToString()))
                        return $"+{str}";
                    else
                        return $"-{str}";
                }
            }
            return "";
        }
        bool ChangeString(string str, string str2)
        {
            char[] mas1 = str.ToCharArray();
            char[] mas2 = str2.ToCharArray();

            int matches = 0;
            for (int j = 0; j < CheckLargeLength(mas1, mas2); j++)
            {
                if (j >= CheckSmallLength(mas1, mas2))
                    continue;
                else
                {
                    if (mas1[j] == mas2[j])
                        matches++;
                }
            }
            if ((matches / 2) > 0.5)
                return true;
            else
                return false;
        }
        public string Compare()
        {
            string[] output = new string[CheckLargeLength()];

            int i = 0;
            while (i < CheckLargeLength())
            {
                for (int k = 0; k < CheckSmallLength(); k++)
                {
                    if (AddDelString(File2[k], File1[i]) == "")
                    {
                        output[i] = $"~{File2[k]}";
                        i++;
                    }
                    else
                    {
                        if (!File2[k].Contains(File1.ToString()))
                        {
                            output[i] = $"+{File2[k]}";
                        }
                        else if ((!File1[i].Contains(File2.ToString())))
                        {
                            output[i] = $"-{File1[i]}";
                        }
                    }
                }
                i++;
            }
            foreach (string elem in output)
            {
                Console.WriteLine(elem);
            }

            return "";
        }
    }
} 














































//public int CheckLength()
//{
//    if (File1.Length >= File2.Length)
//        return File1.Length;
//    else
//        return File2.Length;
//}
//public int CheckLength(string str1, string str2)
//{
//    if (str1.Length >= str2.Length)
//        return str1.Length;
//    else
//        return str2.Length;
//}
//public string[] ReturnLarger()
//{
//    if (CheckLength() == File1.Length)
//        return File1;
//    else
//        return File2;
//}
//public string ReturnLarger(string str1, string str2)
//{
//    if (CheckLength(str1, str2) == str1.Length)
//        return str1;
//    else
//        return str2;
//}
//public string[] ReturnSmaller()
//{
//    if (CheckLength() == File1.Length)
//        return File2;
//    else
//        return File1;
//}
//public string ReturnSmaller(string str1, string str2)
//{
//    if (CheckLength(str1, str2) == str1.Length)
//        return str2;
//    else
//        return str1;
//}
//public bool FindRemote(string origin)
//{
//    bool fl = false;
//    for (int i = 0; i < File2.Length; i++)
//    {
//        if (File2[i] == origin)
//            fl = true;
//    }
//    return fl;
//}
//public string Compare()
//{
//    string[] change = new string[CheckLength()];
//    string[] remote = new string[CheckLength()];
//    string[] add = new string[CheckLength()];


//    for (int i = 0; i < CheckLength(); i++)
//    {
//        string line1 = File1[i];
//        string line2 = File2[i];

//        if (line1 == line2)
//            continue;
//        else
//        {
//            if (line1[0] != line2[0])
//            {

//            }
//            bool coincidence = false;
//            int k = 0;
//            while (k < CheckLength(line1, line2))
//            {
//                if (line1[0] != line2[0])
//                {
//                    if (File1[i] == File2[i + 1])
//                        add[i] = File2[i + 1];
//                }
//                try
//                {
//                    if (line1[k] == line2[k])
//                        coincidence = true;
//                    else
//                    {

//                    }
//                    k++;
//                }
//                catch (IndexOutOfRangeException)
//                {
//                    if (coincidence)
//                        change[i] = line2;
//                }
//            }

//        }
//    }
//    return "";
//}