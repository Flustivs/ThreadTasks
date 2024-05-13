using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Quic;
class program
{
    public int _alarmCount;
    public char _char = '*';

    /// <summary>
    /// Method that just writes a line 5 times
    /// </summary>
    public void WorkThreadFunction()
    {
        for (int i = 0; i < 5; i++)
        {
            Thread.Sleep(1000); // Thread waits for 1 sec
            Console.WriteLine("C#-trådning er nemt!");
        }
    }
    /// <summary>
    /// Method that writes another line 5 times
    /// </summary>
    public void MoreThreadFunction()
    {
        for (int i = 0; i < 5; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine(" Også med flere tråde …");
        }
    }
    /// <summary>
    /// Gets a random tempurature from -20 to 120, if that tempurature is under 0 or over 100
    /// than it tells you an alarm and saying the tempurature
    /// </summary>
    public void RandomTemp()
    {
        Random rnd = new Random();

        while (_alarmCount < 3)
        {
            int temp = rnd.Next(-20, 120);

            if (temp < 0 || temp > 100)
            {
                Console.WriteLine("Alarm. Temperaturen er: " + temp);
                _alarmCount++;
            }
            else
            {
                Console.WriteLine("Tempuraturen er: " + temp);
            }
            Thread.Sleep(1500);
        }
    }

    public void WriteChar()
    {
        while (true)
        {
            Console.Write(_char);
            Thread.Sleep(15);
        }
    }
    public void ReadChar()
    {
        while (true)
        {
            ConsoleKeyInfo input = Console.ReadKey();
            _char = input.KeyChar;
        }
    }
}
class ThreadTasks
{
    public static void Main()
    {
        program pg = new program();
        // Opgave 0 / 1
        /*
        Thread workThread = new Thread(new ThreadStart(pg.WorkThreadFunction));
        workThread.Start();
        Console.WriteLine("Current Thread name: " + Thread.CurrentThread.Name);
        */
        // Opgave 2
        /*
        Thread moreThreads = new Thread(new ThreadStart(pg.MoreThreadFunction));
        moreThreads.Start();
        */
        // Opgave 3
        /*
        Thread tempThread = new Thread(new ThreadStart(pg.RandomTemp)); // makes the RandomTemp method a entrypoint for this thread
        tempThread.Start();
        while (tempThread.IsAlive)
        {
            Thread.Sleep(10000);
            Console.WriteLine("Alarm-tråd lever");
        }
        if (!tempThread.IsAlive)
        {
            Console.WriteLine("Alarm-tråd termineret!");
        }
        */
        // Opgave 4
        /*
        Thread readThread = new Thread(new ThreadStart(pg.ReadChar));
        Thread writeThread = new Thread(new ThreadStart(pg.WriteChar));

        Console.WriteLine("Tryk enter for at starte");
        ConsoleKeyInfo start = Console.ReadKey(); // Reads the users input

        if (start.Key == ConsoleKey.Enter)
        {
            readThread.Start();
            writeThread.Start();
        }
        */
    }
}

//Udvid programmet så det indeh