interface NondestructiveSet<T> : ISet<T>
{
    NondestructiveSet<T> Intersection(NondestructiveSet<T> other);
    NondestructiveSet<T> Union(NondestructiveSet<T> other);
    NondestructiveSet<T> Difference(NondestructiveSet<T> other);
}

class NondestructiveHashSet<T> : HashSet<T>, NondestructiveSet<T>
{
    public NondestructiveHashSet() { }
    public NondestructiveHashSet(T[] elements)
    {
        foreach (T element in elements)
        {
            Add(element);
        }
    }
    public NondestructiveSet<T> Intersection(NondestructiveSet<T> other)
    {
        NondestructiveSet<T> result = new NondestructiveHashSet<T>();
        result.UnionWith(this);
        result.IntersectWith(other);
        return result;
    }
    public NondestructiveSet<T> Union(NondestructiveSet<T> other)
    {
        NondestructiveSet<T> result = new NondestructiveHashSet<T>();
        result.UnionWith(this);
        result.UnionWith(other);
        return result;
    }
    public NondestructiveSet<T> Difference(NondestructiveSet<T> other)
    {
        NondestructiveSet<T> result = new NondestructiveHashSet<T>();
        result.UnionWith(this);
        result.ExceptWith(other);
        return result;
    }
    public override string ToString()
    {
        return "{" + string.Join(", ", this) + "}";
    }
}
class NondestructiveHashSetTest
{
    static void Main(string[] args)
    {
        int[] asArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] bsArray = { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        NondestructiveSet<int> a = new NondestructiveHashSet<int>(asArray);
        NondestructiveSet<int> b = new NondestructiveHashSet<int>(bsArray);
        NondestructiveSet<int> a_intersection_b = a.Intersection(b);
        NondestructiveSet<int> b_intersection_a = b.Intersection(a);
        NondestructiveSet<int> a_union_b = a.Union(b);
        NondestructiveSet<int> b_union_a = b.Union(a);
        NondestructiveSet<int> a_difference_b = a.Difference(b);
        NondestructiveSet<int> b_difference_a = b.Difference(a);
        Console.WriteLine("Intersections:");
        Console.WriteLine(" • A  B: " + a_intersection_b);
        Console.WriteLine(" • B  A: " + b_intersection_a);
        Console.WriteLine("");
        Console.WriteLine("Unions:");
        Console.WriteLine(" • A U B: " + a_union_b);
        Console.WriteLine(" • B U A: " + b_union_a);
        Console.WriteLine("");
        Console.WriteLine("Differences:");
        Console.WriteLine(" • A - B: " + a_difference_b);
        Console.WriteLine(" • B - A: " + b_difference_a);
    }
}

