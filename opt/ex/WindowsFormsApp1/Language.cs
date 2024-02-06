using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    public static class Language
    {
        public class cLanguage
        {
            public string Name;
            public List<string> Data;
            public cLanguage()
            {
                Name = "";
                Data = new List<string>();
            }
            public cLanguage(string name)
            {
                Name = name;
                Data = new List<string>();
            }
        }

        public static List<cLanguage> LanguageData = new List<cLanguage>();

        public static int LanguageDataLoad(string Language)
        {
            ////0:OK 1:!Exist 2:wrong file 3:error
            int ret = 0;

            string path = ".\\Language\\" + Language;
            
            FileInfo fi = new FileInfo(path);
            if(!fi.Exists)
            {
                ret = 1;
                return ret;
            }
            StreamReader sr = new StreamReader(path, Encoding.Unicode);
            try
            {
                int lineCnt = 0;
                int sectionCnt = 0;
                while (true)
                {
                    if(sr.EndOfStream)
                    {
                        break;
                    }
                    string data = sr.ReadLine();
                    if(lineCnt == 0)
                    {
                        if(data != "Z-TEC Cycler Language File(Monitor)")
                        {
                            ret = 2;
                            break;
                        }
                        lineCnt++;
                        continue;
                    }
                    if(data.Contains("{"))
                    {
                        if (lineCnt > 1)
                        { sectionCnt++; }
                        data = data.Replace("{", "");
                        data = data.Replace("}", "");
                        cLanguage temp = new cLanguage(data);
                        LanguageData.Add(temp);
                        continue;
                    }
                    data = data.Remove(0, data.IndexOf("=") + 1);
                    LanguageData[sectionCnt].Data.Add(data);
                    lineCnt++;
                }                
            }
            catch(Exception e)
            {
                string ee = e.Message;
                ret = 3;
                sr.Close();
                return ret;
            }
            sr.Close();
            return ret;
        }

        public static int getIndexFromName(string name)
        {
            int ret = 0;

            for(int i = 0; i < LanguageData.Count; i++)
            {
                if(LanguageData[i].Name == name)
                {
                    ret = i;
                    break;
                }
            }

            return ret;
        }

       

       
    }
}
