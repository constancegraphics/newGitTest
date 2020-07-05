using System;
namespace MyApplication
{
  class Program
  {
    static void checkMood(string mood)
    {
      if (mood == nice)
      {
        Console.WriteLine("pame volta");
      }
      else
      {
        Console.WriteLine("menoume mesa");
      }
    }
    static void Main (string[] args)
    {
      checkMood("bad");
    }
  }
}
