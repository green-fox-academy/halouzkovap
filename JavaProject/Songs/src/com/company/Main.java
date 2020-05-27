package com.company;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.*;
import java.util.function.Function;
import java.util.stream.Collectors;
import java.util.stream.Stream;

public class Main {

    public static void main(String[] args) {
        try {
            File myObj = new File("songs.txt");
            Scanner myReader = new Scanner(myObj);
            ArrayList<String> years = new ArrayList<String>();

            while (myReader.hasNextLine()) {
                String data = myReader.nextLine();
                var index = data.length() - 4;
                var year = data.substring(index);
                years.add(year);

            }
            findMostCommon(years);
            myReader.close();
        } catch (FileNotFoundException e) {
            System.out.println("An error occurred.");
            e.printStackTrace();
        }
    }

    public static void findMostCommon(List<String> list) {
        Collections.sort(list);
        String mostCommon = null;
        String last = null;
        int mostCount = 0;
        int lastCount = 0;
        for (String x : list) {
            if (x.equals(last)) {
                lastCount++;
            } else if (lastCount > mostCount) {
                mostCount = lastCount;
                mostCommon = last;
            }
            last = x;
        }
        System.out.println(mostCommon);
    }

}
