void PrintArray(int[] array2){
System.Console.WriteLine("[" + string.Join(", ", array2) + "]");
}

System.Console.WriteLine("Введите число от 1 до 100 000:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 100000)
    System.Console.WriteLine("Число выходит за заданный диапазон");
else{
    int tempNumber = number;
    int count = 1;
    while (tempNumber / 10 > 0){
        count++;
        tempNumber = tempNumber / 10;
    }
    System.Console.WriteLine($"В числе {count} цифр");

    int[] array = new int[count];

    for( int i = 0; i < array.Length; i++){
        array[array.Length - 1 - i] = number % 10;
        number = number / 10;
    }
    System.Console.WriteLine("Массив из цифр числа");
    PrintArray(array);
}