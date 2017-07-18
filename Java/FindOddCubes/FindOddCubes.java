//refactor
import java.util.Arrays;

public class FindOddCubes {

  public static int cubeOdd(int arr[]) {
    return Arrays.stream(arr)
      .filter(num -> num % 2 != 0)
      .map(num -> num * num * num)
      .sum();
  }
}

// initial attempt
// public class FindOddCubes {

// public static int cubeOdd(int arr[]) {
//   int sum = 0;

//   for(int x : arr) {
//     if(x % 2 != 0) {
//       sum += Math.pow(x, 3);
//     };
//   }
//   return sum;
//  }
// }
