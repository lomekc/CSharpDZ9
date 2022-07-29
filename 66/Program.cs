int SumOfNaturalElem(int I, int J)
{
    if (i < j)
    {
        while (i != j)
            return i + SumOfNaturalElem(i + 1, j);
    }

    if (i > j)
    {
        while (i != j)
            return i + SumOfNaturalElem(i - 1, j);
    }

    return i;
}

Console.Write("введите 1 число: ");
int I = Convert.ToInt32(Console.ReadLine());

Console.Write("введите 2 число: ");
int J = Convert.ToInt32(Console.ReadLine());

Console.Write("сумма натуральных элементов в указанном промежутке: " + SumOfNaturalElem(I, J));