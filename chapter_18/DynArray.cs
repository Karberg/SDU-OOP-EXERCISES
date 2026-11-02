class DynArray<T> : IDynArray<T>
{
    // Attributes
    T[] data = new T[1];

    // Constructors
    public DynArray() { }
    public DynArray(T[] data)
    {
        this.data = data;
    }

    // Methods
    public void Append(T data)
    {

    }

    public void Insert(int value, T data)
    {

    }

    public void Remove(int value)
    {

    }

    public void Set(int value, T data)
    {

    }

    public T Get(int value)
    {
        return data[value];
    }

    public int GetFill()
    {
        return data.Length;
    }

}