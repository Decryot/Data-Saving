using System;
using System.IO;

namespace CsharpDataSaving
{
    class FileCreator {
        
        // the data.txt file will be parented in the bin/Debug/DATA folder
        string pathToFolder = Directory.GetCurrentDirectory();
        string folderName = "DATA";

        string dataFolderName = "data.txt";

        public FileCreator() {
            // CREATING DATA FOLDER / FILE
            if (!Directory.Exists(pathToFolder + "/" + folderName)) {
                Directory.CreateDirectory(pathToFolder + "/" + folderName);
            }

            if (!Directory.Exists(pathToFolder + "/" + folderName + "/" + dataFolderName)) {

                try { 
                    TextWriter writer = new StreamWriter(pathToFolder+"/"+folderName+"/"+dataFolderName, true);

                    writer.Write("");
                    writer.Flush();
                    writer.Close();
                }
                catch (Exception e) { Console.WriteLine(e); }
            }
        }

        // SAVING DATA
        public void saveData(int dataToSave)
        {
            TextWriter writer = new StreamWriter(pathToFolder + "/" + folderName + "/" + dataFolderName, true);

            writer.Write(dataToSave.ToString());
            writer.Flush();
            writer.Close();
        }

        // LOADING DATA
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
            fileCreator.saveData(100);
            data = fileCreator.getData();
            Console.Write(data);
        }
    }
}
