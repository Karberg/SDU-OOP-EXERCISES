Kitten[] kittens = new Kitten[10];

for (int i = 0; i < kittens.Length; i++)
{
    kittens[i] = new Kitten(10 * i);
    Console.WriteLine(kittens[i].cuteness);
    Console.WriteLine(Kitten.count);
}


class Kitten
{
    public double cuteness;
    public static int count = 0;

    public Kitten(double cuteness)
    {
        this.cuteness = cuteness;
        count++;
    }
}