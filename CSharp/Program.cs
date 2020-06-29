using System;
using System.IO;

namespace CsharpDataSaving
{
    class FileCreator {
        string pathToFolder = Directory.GetCurrentDirectory();
        string folderName = "DATA";

        public FileCreator() {
            if (!Directory.Exists(pathToFolder + "/" + folderName)) {
                Directory.CreateDirectory(pathToFolder + "/" + folderName);
            }

            if (!Directory.Exists(pathToFolder + "/" + folderName + "/data.txt")) {

                try { 
                    TextWriter writer = new StreamWriter(pathToFolder+"/"+folderName+"/data.txt", true);

                    writer.Write("10");
                    writer.Flush();
                    writer.Close();
                }
                catch (Exception e) { Console.WriteLine(e); }
            }
        }

        public int getData() {

            int loadedData = 0;
            TextReader reader = new StreamReader(pathToFolder+"/"+folderName+"/data.txt", true);

            string line = reader.ReadLine();
            loadedData = Int32.Parse(line);
            return loadedData;
        }
    }

    class Program {

        static FileCreator fileCreator;
        static int data = 0;

        public static void Main(string[] args) {

            fileCreator = new FileCreator();
            data = fileCreator.getData();
            Console.Write(data);
        }
    }
}
