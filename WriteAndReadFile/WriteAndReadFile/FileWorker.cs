using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.VisualBasic;

namespace WriteAndReadFile
{
    public class FileWorker
    {      
        public static string WriteLine(string path, string text)
        {
            try
            {
                StreamWriter writer = new StreamWriter(path);              
                writer.WriteLine(text);               
                writer.Close();
            }
            catch (Exception e)
            {
                return("Exception: " + e.Message);
            }          
            return "Successfully";            
        }
        public static string Reader(string path)
        {
            string line = "";
            string? buffer;
            using (StreamReader reader = new StreamReader(path))
            {

                while ((buffer = reader.ReadLine()) != null)
                {                   
                    line += (buffer + " ");
                }
                reader.Close();
            }
            return line;           
        }
        public static string WriteArrayOfString(string path, string[] text)
        {
            
            try
            {
                StreamWriter writer = new StreamWriter(path);
                for (int i = 0; i < text.Length; i++)
                {                  
                        writer.WriteLine(text[i]);
                }
                
                writer.Close();
            }
            catch (Exception e)
            {
                return ("Exception: " + e.Message);
            }
            return "Successfully";
        }
        public static string WriteStructure(string path, ValueType structure)
        {
            try
            {
                FileSystem.FileOpen(1, path, OpenMode.Random);
                FileSystem.FilePut(1, structure);
                FileSystem.FileClose();
            }
            catch (Exception e)
            {
                return ("Exception: " + e.Message);
            }
            return "Successfully";
        }
        
    }

}