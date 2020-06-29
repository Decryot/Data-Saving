package Java;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Data {

    static int loadedData;
    static Scanner fileScanner;

    public static void main(String[] args) throws FileNotFoundException {
        loadedData = loadData("Data.txt");
        System.out.println(loadedData);
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