// Find the largest value in an array of ints

int[] arr = [1, 3, 2, 5, 0, 2];
int largest = 0;
int largestNum = 0;

// Run a for loop as long as the array length
for (int i = 0; i < arr.GetLength(0); i++) {
    // Check if the largest variable is smaller than the current value.
    if (largest < arr[i]) {
        largest = i;
        largestNum = arr[i];
    }
}
Console.WriteLine("Length: " + arr.GetLength(0));

Console.WriteLine("Index of largest: " + largest);
Console.WriteLine("Largest number in array: " + largestNum);
