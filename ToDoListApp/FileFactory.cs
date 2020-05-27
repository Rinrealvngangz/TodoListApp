using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ToDoListApp
{
   public class FileFactory
    {
      
        public static void SaveFile(List<UserControl1> csdl, string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
                foreach (UserControl1 item in csdl)
                {
                    string line = item.text;
                    sw.WriteLine(line);
                }
                sw.Close();
             
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        public static List<UserControl1> ReadFile (string path)
        {
            List<UserControl1> listcsdl = new List<UserControl1>();
            try
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);

              
                string line = sr.ReadLine();

                while (line !=null)
                {
                    UserControl1 item = new UserControl1();
                    item.text = line;
                    listcsdl.Add(item);
                    line = sr.ReadLine();
                }
                sr.Close();
               
            }catch(Exception er)
            {
                throw er;
            }
            return listcsdl;
        }

    }
}
