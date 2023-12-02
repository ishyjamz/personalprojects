namespace AlgorithmsDataStructuresLearning.Arrays;

public class ManipulatingArrays
{
    public int[] AddToEndOfArray(int[] intArray, int length)
    {
        intArray[length] = 8;
        length++;
        
        return intArray;
    }
}