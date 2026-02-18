// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

const int repetitions = 1000;


//UseSystemThreading();
//UseSystemThreadingTasks();
UseAsync();


//static void UseSystemThreading()
//{
//    // Create thread and associate method
//    ThreadStart threadStart = DoWork;    // ThreadStart Delegate
//    Thread plusThread = new Thread(threadStart);
//    // Start thread
//    plusThread.Start();
//    //
//    for (int count = 0; count < repetitions; count++)
//    {
//        Console.Write('-');
//    }
//    // Wait for plusThread to terminate
//    plusThread.Join();
//}

static void DoWork()
{
    for (int count = 0; count < repetitions; count++)
    {
        Console.Write('+');
    }
}

static void UseSystemThreadingTasks()
{
    // Create and start task
    Task plusTask = Task.Run(() =>
    {
        for (int count = 0; count < repetitions; count++)
        {
            Console.Write('+');
        }
    });
    Debug.WriteLine("Plus task status: " + plusTask.Status);

    for (int count = 0; count < repetitions; count++)
    {
        Console.Write('-');
    }
    // Wait for task to complete
    plusTask.Wait();
    Debug.WriteLine("Plus task status: " + plusTask.Status);
}

static async Task UseAsync()
{
    // 1. Call DoWorkAsync()
    // 2. Print minuses
    Task doWorkTask = DoWorkAsync();
    for (int count = 0; count < repetitions; count++)
        {
            Console.Write('-');
        };
    await doWorkTask;
}

static async Task DoWorkAsync()
{
    // Start code:
    await Task.Run(() => {
        for (int count = 0; count < repetitions; count++)
        {
            Console.Write('+');
        }
    });
}


