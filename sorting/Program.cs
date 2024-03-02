// See https://aka.ms/new-console-template for more information

// sorting



int[] myNumbers = new int[]
{
    5,
    1,
    8,
    9

};
Console.WriteLine("Original array");

foreach (int i in myNumbers)
{
    Console.WriteLine(i);
}
Console.WriteLine("Sorted array in ASC order");
Array.Sort(myNumbers);
foreach (int i in myNumbers)
{
    Console.Write(i + " ");
}
Console.WriteLine();
Console.WriteLine("Sorted array in DESC order");
// Sort Array in DESC order
Array.Reverse(myNumbers);
foreach (int i in myNumbers)
{
    Console.Write(i + " ");
}







//Initialize array   
/*int[] arr = new int[] { 5, 2, 8, 7, 1 };
int temp = 0;

//Displaying elements of original array  
Console.WriteLine("Elements of original array: ");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}

//Sort the array in ascending order  
for (int i = 0; i < arr.Length; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] > arr[j])
        {
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

Console.WriteLine();

//Displaying elements of array after sorting  
Console.WriteLine("Elements of array sorted in ascending order: ");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
}*/