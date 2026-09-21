// Initialize array and variable for holding largest value in array
int[] arr = [-6, -4, 0, 19, -8, -29];
int largest = arr[0];

// Find the largest negative value in an array
for (int i = 0; i < arr.Length; i++)
{
    // If the value is below zero and bigger than current largest
    if (arr[i] < 0 && arr[i] > largest)
    {
        largest = arr[i];
    }
}

// Print the largest value
Console.WriteLine(largest);