

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;

public class Data {

    static int loadedData;
    static Scanner fileScanner;
    static PrintWriter fileWriter;

    public static void main(String[] args) throws FileNotFoundException {
        saveData(100, "Data.txt");
        loadedData = loadData("Data.txt");
        
        System.out.println(loadedData);
    }

    static void saveData(int data, String fileName) throws FileNotFoundException {
        File dataFile = new File(fileName);
        if (dataFile.exists()) {
            fileWriter = new PrintWriter(dataFile);
            fileWriter.println(data);
            fileWriter.flush();
            fileWriter.close();
        }
    }

    static int loadData(String fileName) throws FileNotFoundException {

        int dataReceived = 0;

        File dataFile = new File(fileName);
        if (dataFile.exists()) {
            fileScanner = new Scanner(dataFile);
            while (fileScanner.hasNext()) {
                dataReceived = fileScanner.nextInt();
                System.out.println("scanned");
            }
        }
        else System.err.println("The file: " + fileName + " doesn't exist. ");

        return dataReceived;
    }
}