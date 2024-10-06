#region tapsırıq-1
int[] arr = { 1, 2, 3, 10, 11, 15, 20, 21, 50, 101, 210 };
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 2; j < arr[i]; j++)
    {
        if (arr[i] % j == 0)
        {
            Console.WriteLine(arr[i]);
            break;
        }
    }
}

#endregion

#region tapsiriq-2
int[] arr1 = { 1, 2, 5, 10, 15 };
int[] arr2 = { 1, 5, 7, 9, 10 };
for (int i = 0; i < arr1.Length; i++)
{
    for (int j = 0; j < arr2.Length; j++)
    {
        if (arr1[i] == arr2[j])
        {
            Console.WriteLine(arr1[i]);
            //Console.WriteLine(arr2[j]);
        }
    }
}
#endregion

#region tapsiriq-3
int[] arr3 = { 2, 1, 4, 6, 10, 15 };
int max = arr3[0];
int min = arr3[0];

for (int i = 0; i < arr3.Length; i++)
{
    if (arr3[i] > max)
    {
        max = arr3[i];
        max = i;
    }
    else if (arr3[i] < max)
    {
        min = arr3[i];
        min = i;
    }
}
Console.WriteLine("en kiciyin indexi:" + min);
Console.WriteLine("en boyuyun indexi:" + max);
#endregion

#region tapsiriq-4
int eded = 26;
int cem = 0;
do
{
    cem += eded % 10;
    eded /= 10;
}
while (eded > 0);
Console.WriteLine(cem);
#endregion






