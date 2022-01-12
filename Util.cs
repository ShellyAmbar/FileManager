using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PackageJsonManager
{
    internal class Util
    {
       

        public static string GetProjectDirectory() {
            string workingDirectory = Environment.CurrentDirectory;
            // or: Directory.GetCurrentDirectory() gives the same result
            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            return projectDirectory;
        }
        public static void UpdateObject(string fileName, string key , string value)
        {
            string filePath = "";
            string jsonString = "";
            JObject jsObject = new JObject();
            if (fileName == null || fileName.Length == 0)
            {
                throw new ArgumentNullException("FileName");

            }
            filePath = Path.Combine(GetProjectDirectory(), fileName);


            Console.WriteLine("file full path is : {0}", filePath);
            if (filePath == null ) { throw new Exception("File not exist"); }
            jsonString = File.ReadAllText(filePath);
            try {
                jsObject = JObject.Parse(jsonString);

                if (jsObject != null)
                {
                   
                    jsObject[key] = value;
                    string newJsonResult = JsonConvert.SerializeObject(jsObject, Formatting.Indented);
                    Console.WriteLine(newJsonResult);
                    File.WriteAllText(filePath, newJsonResult);

                }
                else
                {
                    throw new Exception("Couldn't parsing to object");
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

           


        }

        public static void saveObjectToFile(Object obj, string filePath)
        {
           

        }



    }
}
