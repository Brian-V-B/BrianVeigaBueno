using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{
    public int NumberA = 1;
    public int NumberB = 50;
    public int NumberC = 75;


    private void Start() {
        int[] sortedNumbers = ReturnSortedNumbers(new int[]{NumberA, NumberB, NumberC}); // Se llama el método abajo.
        foreach (int n in sortedNumbers) {
            Debug.Log(n); // Se pasa por cada número devuelto y se hace un log de cada uno.
        }
    }

    // Para simplificar, simplemente se transforman las tres variables en un array y se hace este método.
    private int[] ReturnSortedNumbers(int[] numbers) {
        for (int i = 0; i < numbers.Length; i++) { // Se hace un primer loop, que es el que modificará el array
            for (int j = i + 1; j < numbers.Length; j++) { // Este segundo loop compara desde i hasta el final...
                if (numbers[j] > numbers[i]) {
                    int temp = numbers[i];
                    numbers[i] = numbers[j]; // ...y si el número en j es mayor, se cambia el número en i.
                    numbers[j] = temp;
                }
            }
        }
        return numbers; // Y se devuelve el array!
    }
}
