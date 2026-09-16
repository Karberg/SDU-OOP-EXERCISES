int[,] sudoku = {
    {1,2,3},
    {3,5,6},
    {7,8,9}
};

bool[] checkedValues = new bool[9];

for (int x = 0; x < sudoku.GetLength(0); x++)
{
    for (int y = 0; y < sudoku.GetLength(1); y++)
    {
        if (sudoku[x,y] == 0)
        {
            Console.WriteLine("Not all cells are filled out");
            return;
        }
        checkedValues[sudoku[x,y] - 1] = true;
    }
}

for (int i = 0; i < checkedValues.Length; i++)
{
    Console.WriteLine(i+1 + " " + checkedValues[i]);
}