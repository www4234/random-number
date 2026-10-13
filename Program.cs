// Инициализируем генератор случайных чисел и переменные
Random random = new Random();
int attempts = 7;
// Загадываем число от 1 до 100 (можно изменить диапазон)
int num = random.Next(1, 101); 

Console.WriteLine("Программа загадала число от 1 до 100. Угадайте его (у вас 7 попыток)");
Console.Write("> ");

while (true)
{
    // Безопасно считываем строку и конвертируем в число
    string? inputStr = Console.ReadLine();
    if (!int.TryParse(inputStr, out int input))
    {
        Console.WriteLine("Пожалуйста, введите корректное число.");
        Console.Write("> ");
        continue;
    }

    // Уменьшаем счетчик попыток за каждое введенное число
    attempts--;

    if (input == num)
    {
        Console.WriteLine("Ты угадал число! Поздравляем!");
        break;
    }
    else if (attempts > 0)
    {
        // Подсказка игроку (опционально, но делает игру лучше)
        if (input < num) Console.WriteLine("Загаданное число больше.");
        else Console.WriteLine("Загаданное число меньше.");

        Console.WriteLine($"Не угадал. Осталось попыток: {attempts}. Попробуй еще раз");
        Console.Write("> ");
    }
    else
    {
        Console.WriteLine($"Попытки закончились. Программа загадала число {num}");
        break;
    }
}