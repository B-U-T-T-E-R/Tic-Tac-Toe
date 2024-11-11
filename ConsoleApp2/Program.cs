char[,] map =
{
     {'_', '_', '_'},
     {'_', '_', '_'},
     {'_', '_', '_'}
};

bool isX = true;

FileStreamOptions options = new FileStreamOptions();

StreamWriter sw = new StreamWriter(@"score.txt", true);

Console.WriteLine("Ход X");

while(true)
{
    
    for(int x = 0; x < 3; x++)
    {
        for(int y = 0; y < 3; y++)
        {
            Console.Write(map[x, y] + " ");
        }
        Console.WriteLine();
    }
    int player = int.Parse(Console.ReadLine());

    if (player <= 0)
        break;

    switch (player)
    {
        case 1: 
            if(isX && (map[0,0] != 'X' || map[0,0] != 'O')) 
                map[0, 0] = 'X';
            else
                map[0, 0] = 'O'; 
            break;
        case 2:
            if (isX && (map[0, 1] != 'X' || map[0, 1] != 'O'))
                map[0, 1] = 'X';
            else
                map[0, 1] = 'O';
            break;
        case 3:
            if (isX && (map[0, 2] != 'X' || map[0, 2] != 'O'))
                map[0, 2] = 'X';
            else
                map[0, 2] = 'O';
            break;
        case 4:
            if (isX && (map[1, 0] != 'X' || map[1, 0] != 'O'))
                map[1, 0] = 'X';
            else
                map[1, 0] = 'O';
            break;
        case 5:
            if (isX && (map[1, 1] != 'X' || map[1, 1] != 'O'))
                map[1, 1] = 'X';
            else
                map[1, 1] = 'O';
            break;
        case 6:
            if (isX && (map[1, 2] != 'X' || map[1, 2] != 'O'))
                map[1, 2] = 'X';
            else
                map[1, 2] = 'O';
            break;
        case 7:
            if (isX && (map[2, 0] != 'X' || map[2, 0] != 'O'))
                map[2, 0] = 'X';
            else
                map[2, 0] = 'O';
            break;
        case 8:
            if (isX && (map[2, 1] != 'X' || map[2, 1] != 'O'))
                map[2, 1] = 'X';
            else
                map[2, 1] = 'O';
            break;
        case 9:
            if (isX && (map[2, 2] != 'X' || map[2, 2] != 'O'))
                map[2, 2] = 'X';
            else
                map[2, 2] = 'O';
            break;

        default:
            Console.WriteLine("Вы ввели неверную позицию");
            Console.WriteLine("Штраф: Вы пропускаете ход");
            break;
    }


    int win = isWin(map);

    if (win == 1)
    {
        Console.WriteLine("Выиграл Первый игрок!!");
        Console.Write("Введите ваш ник: ");
        sw.WriteLine(Console.ReadLine());
        break;
    }
    else if (win == 2)
    {
        Console.WriteLine("Выиграл Второй игрок!!");
        Console.Write("Введите ваш ник: ");
        sw.WriteLine(Console.ReadLine());
        break;
    }

    isX = !isX;
    if(isX)
        Console.WriteLine("Ход X");
    else
        Console.WriteLine("Ход O");
}

sw.Close();

int isWin(char[,] c)
{
    //Проверка ходов для X
    if ((c[0, 0] == 'X'))
    {
        if (c[1, 0] == 'X')
        {
            if (c[2, 0] == 'X')
                return 1;
        }

        if (c[1, 1] == 'X')
        {
            if (c[2, 2] == 'X')
                return 1;
        }

        if(c[0, 1] == 'X')
        {
            if (c[0, 2] == 'X')
                return 1;
        }
    }
    if ((c[1, 1] == 'X'))
    {
        if (c[0, 1] == 'X')
        {
            if (c[2, 1] == 'X')
                return 1;
        }

        if (c[0, 2] == 'X')
        {
            if (c[2, 2] == 'X')
                return 1;
        }

        if( c[1, 0] == 'X')
        {
            if (c[1, 2] == 'X')
                return 1;
        }
    }
    if (c[2, 2] == 'X')
    {
        if (c[2, 0] == 'X')
        {
            if (c[2, 1] == 'X')
                return 1;
        }
        
        if(c[0, 2] == 'X')
        {
            if (c[1, 2] == 'X')
                return 1;
        }
    }
    //Закончена проверка для X и начата проверка O
    if ((c[0, 0] == 'O'))
    {
        if (c[1, 0] == 'O')
        {
            if (c[2, 0] == 'O')
                return 2;
        }

        if (c[1, 1] == 'O')
        {
            if (c[2, 2] == 'O')
                return 2;
        }

        if (c[0, 1] == 'O')
        {
            if (c[0, 2] == 'O')
                return 2;
        }
    }
    if ((c[1, 1] == 'O'))
    {
        if (c[0, 1] == 'O')
        {
            if (c[2, 1] == 'O')
                return 2;
        }

        if (c[0, 2] == 'O')
        {
            if (c[2, 2] == 'O')
                return 2;
        }

        if (c[1, 0] == 'O')
        {
            if (c[1, 2] == 'O')
                return 2;
        }
    }
    if (c[2, 2] == 'O')
    {
        if (c[2, 0] == 'O')
        {
            if (c[2, 1] == 'O')
                return 2;
        }

        if (c[0, 2] == 'O')
        {
            if (c[1, 2] == 'O')
                return 2;
        }
    }
    //Закончена проверка для O
    return 0;
}