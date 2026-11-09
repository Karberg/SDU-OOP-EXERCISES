using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;




class Matrix
{
    public double[][] Data;

    public Matrix(string fileName)
    {
        StreamReader file = new StreamReader(fileName);
        // Create the file if it doesn't exist
        if (!File.Exists(fileName + ".csv"))
        {
            throw new Exception("The file doesn't exist");
        }

        // Split by line break
        string[] lines = file.Read().ToString().Split('\n');

        try
        {
            // Create data array
            Data = new double[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                Data[i] = new double[values.Length];
                for (int j = 0; j < values.Length; j++)
                {
                    Data[i][j] = double.Parse(values[j]);
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Unable to parse");
        }
    }

    public Matrix(int x, int y)
    {
        Data = new double[y][];
        for (int i = 0; i < y; i++)
        {
            Data[i] = new double[x];
        }
    }

    public int GetHeight()
    {
        return Data.Length;
    }
    public int GetWidth()
    {
        return Data[0].Length;
    }

    public bool Save(string fileName)
    {
        try
        {
            StreamWriter writer = new StreamWriter(fileName);

            foreach (double[] row in Data)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    double cell = row[i];
                    writer.Write((i == 0 ? "" : ",") + cell);
                }
                writer.WriteLine();
            }
            writer.Close();
            return true;
        }
        catch (IOException)
        {
            return false;
        }
    }

    public static void Main(string[] args)
    {
        string m1_filename = "m1.csv";
        string m2_filename = "m2.csv";
        Matrix m1 = new Matrix(4, 6);
        m1.Save(m1_filename);
        Matrix m2 = new Matrix(m1_filename);
        for (int i = 0; i < Math.Min(m2.GetHeight(), m2.GetWidth()); i++)
        {
            m2.Data[i][i] += 1;
        }
        m2.Save(m2_filename);
    }
}

