namespace challenges_csharp;

public class Challenges {
    public int[] ArrayOfMultiples(int num, int multiple)
    {
        int[] arr = new int[multiple];
        int n = 1;
        
        for (int i = 0; i < multiple; i++)
        {
            arr[i] = num * n++;
        }

        return arr;
    }
}