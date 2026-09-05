int[,] matrix = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

int n = matrix.GetLength(0);

int sum1 = 0;
long prod1 = 1;

int sum2 = 0;
long prod2 = 1;

for (int i = 0; i < n; i++)
{
    sum1 += matrix[i, i];
    prod1 *= matrix[i, i];

    sum2 += matrix[i, n - 1 - i];
    prod2 *= matrix[i, n - 1 - i];
}

Console.WriteLine("Головна діагональ: сума = " + sum1 + ", добуток = " + prod1);
Console.WriteLine("Побічна діагональ: сума = " + sum2 + ", добуток = " + prod2);