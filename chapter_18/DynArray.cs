using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;

class DynArray<T> : IDynArray<T>
{
    // Attributes
    T[] data;
    int capacity;
    int fill;

    public DynArray()
    {
        data = new T[0];
        capacity = 0;
        fill = 0;
    }

    // Methods
    public void Append(T element)
    {
        if (fill >= capacity)
        {
            Expand();
        }

        data[fill] = element;
        fill++;
    }

    public void Insert(int i, T element)
    {
        if (fill >= capacity)
        {
            Expand();
        }

        if (fill < capacity)
        {
            T[] newData = new T[capacity];

            for (int j = 0; j < i; j++)
            {
                newData[j] = data[j];
            }

            newData[i] = element;

            for (int j = i + 1; j < capacity; j++)
            {
                newData[j] = data[j - 1];
            }
            data = newData;
            fill++;
            return;
        }
    }

    public void Remove(int i)
    {
        if (data[i] != null)
        {
            // Shift the entire array to the left from the removed index
            for (int j = i; j < fill - 1; j++)
            {
                data[j] = data[j + 1];
            }
            // Handle the last element in the array
            data[fill] = default;
            fill--;
        }
        else
        {
            throw new Exception("The position doesn't have a value ");
        }

        if (fill < capacity / 2)
        {
            capacity = capacity <= 1 ? 1 : capacity / 2;

            T[] newData = new T[capacity];

            for (int j = 0; j < capacity; j++)
            {
                newData[j] = data[j];
            }

            data = newData;
        }
    }

    public void Set(int i, T element)
    {
        data[i] = element;
    }

    public T Get(int i)
    {
        return data[i];
    }

    public int GetFill()
    {
        return fill;
    }

    void Expand()
    {
        capacity = capacity == 0 ? 1 : capacity * 2;

        T[] newData = new T[capacity];

        for (int i = 0; i < fill; i++)
        {
            newData[i] = data[i];
        }

        data = newData;
    }

    public override string ToString()
    {
        string str = "";

        for (int i = 0; i < data.Length; i++)
        {
            str = string.Concat(str, data[i], ", ");
        }
        return str.TrimEnd(',', ' ');
    }



}