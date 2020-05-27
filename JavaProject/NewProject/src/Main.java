import java.util.Arrays;
import java.util.Collection;
import java.util.List;
import java.util.stream.Stream;

public class Main {


    public static void main(String[] args) {
        //greetinFunction = () -> System.out.print("Hello");
        //intNumberFunction = (int a) -> a * 2;

        List<Integer> myList = Arrays.asList(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

        // solving it with good old for loop
        for (int i = 0; i < myList.size(); i++) {
            if (myList.get(i) > 3) {
                System.out.println(myList.get(i));
            }
        }

        // solving it with magic
        myList.stream().filter(x -> x > 3).forEach(System.out::println);
    }
}
