
double[] GenerateArray(int size, int leftRange, int rigthRange)
{
    double[] tempArray = new double[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
        {
        tempArray[i] = Math.Round(rand.Next(leftRange, rigthRange + 1) + rand.NextDouble(),2) ;
        }
    return tempArray;
}

void PrintArray(double[] array2){
System.Console.WriteLine("[" + string.Join(", ", array2) + "]");
}

int size = 10;
double[] array = GenerateArray(size, 1, 100);
double max = array[0];
double min = array[0];
PrintArray(array);

for( int i = 1; i < array.Length; i++){
    if (array[i] > max){
        max = array[i];
    }
    if (array[i] < min){
            min = array[i];
    }
}
System.Console.WriteLine($"Разность максимального ({max}) и минимального ({min}) элементов массива равна ({max - min})");
