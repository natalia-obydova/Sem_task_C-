// По заданному с клавиатуры номеру дня недели вывести его название

string[] week = { "Mon", "Tue", "Wen", "Th", "Fr", "Sun", "Sat"};
        string dayStr;
        Console.Write("Enter day of week: ");
        dayStr = Console.ReadLine();
        int day = Convert.ToInt32(dayStr);
        if (day > 0 & day < 8) {
            Console.WriteLine (week[day - 1]);
        } else {
            Console.WriteLine ("Incorrect number");
        }