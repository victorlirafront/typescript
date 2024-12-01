using System;

class Program {
    static int MaxSubArraySum(int[] arr) {
        int maxSoFar = arr[0], maxEndingHere = arr[0];

        for (int i = 1; i < arr.Length; i++) {
            maxEndingHere = Math.Max(arr[i], maxEndingHere + arr[i]);
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }

        return maxSoFar;
    }

    static void Main() {
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        Console.WriteLine($"A soma máxima do subarray é: {MaxSubArraySum(arr)}");
    }
}
