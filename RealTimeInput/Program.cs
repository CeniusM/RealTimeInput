using RealTimeInput;

Console.CursorVisible = false;

while (true)
{
    int lines = 0;
    for (int i = 0; i < 256; i++)
    {
        if (Keyboard.IsKeyDown(i))
        {
            Console.WriteLine(i + " down");
            lines++;
        }
    }

    Thread.Sleep(100);

    Console.SetCursorPosition(0, 0);

    for (int i = 0; i < lines; i++)
        Console.WriteLine(new string(' ', 8));

    Console.SetCursorPosition(0, 0);
}