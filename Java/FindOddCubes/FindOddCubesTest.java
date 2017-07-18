import static org.junit.Assert.*;

import org.junit.Test;

public class FindOddCubesTest {

  @Test
  public void itWillReturnZeroWhenEmpty() {
    assertEquals(0, FindOddCubes.cubeOdd(new int[] {}));
  }

  @Test
  public void itWillReturnZeroWhenEvenNums() {
    assertEquals(0, FindOddCubes.cubeOdd(new int[] {2, 4, 6, 8}));
  }

  @Test
  public void itReturnsCubeForOneOddNum () {
    assertEquals(27, FindOddCubes.cubeOdd(new int[] {2, 3, 4}));
  }

  @Test
  public void itPassesCodeWarsTests () {
    assertEquals(0, FindOddCubes.cubeOdd(new int[] {-5, -5, 5, 5}));
    assertEquals(28, FindOddCubes.cubeOdd(new int[] {1, 2, 3, 4}));
    assertEquals(0, FindOddCubes.cubeOdd(new int[] {-3, -2, 2, 3}));
  }
}
