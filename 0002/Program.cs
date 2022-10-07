

Console.WriteLine(" сколько чисел нужно внести");
    int countofNumbers = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    int[] numbers = new int[countofNumbers];
    for (int i = 0; i < countofNumbers; i++)
    {
        Console.WriteLine($"Введите {i} число");
        int inputNumbers = Convert.ToInt32(Console.ReadLine());
        numbers[i - 1] = inputNumbers;
        if (inputNumbers > 0) count++;

    }
    Console.WriteLine("Положительных чисел введено" + count);
