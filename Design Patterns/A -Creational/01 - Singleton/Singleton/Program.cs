using Singleton;
Console.Title = "Singleton pattern";

var instanse1 = Logger.Instance;
var instanse2 = Logger.Instance;

if(instanse1 == instanse2 && instanse2== Logger.Instance)

{
    Console.WriteLine("Instance are the same");
}

instanse1.Log($"Message from {nameof(instanse1)}");
instanse1.Log($"Message from {nameof(instanse2)}");

Logger.Instance.Log($"Message from {nameof(Logger.Instance)}");

Console.ReadLine();