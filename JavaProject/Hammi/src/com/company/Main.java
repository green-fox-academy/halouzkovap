package com.company;

import java.util.ArrayList;

public class Main {


    public static void main(String[] args) {
        String inputOne = "apple";
        String[] inputArray = {"apple", "apply", "tuple", "alter"};

        String inputTwo ="monkey";
        String[] input2={"donkey", "monday", "shaker"};

        MyMethod(inputOne, inputArray);
        MyMethod(inputTwo, input2);

    }

    static void MyMethod(String input, String[] arrays) {
        ArrayList<String> output = new ArrayList<String>();

        for (String i : arrays
        ) {
            int k = 0, count = 0;
            while (k < input.length()) {
                if (input.charAt(k) != i.charAt(k))
                    count++;
                k++;
            }
            if (count <= 3) {
                output.add(i);
            }

        }
        System.out.println(output);
    }
}

