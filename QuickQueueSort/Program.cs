﻿using System;
using System.Diagnostics;

namespace QuickQueueSort
{
  class Program
  {
    static void Main(string[] args)
    {
      //кол-во элементов очереди
      int _digitsCount = 300;

      var time = new Stopwatch();

      //хранилище ключей
      int[] key = new int[_digitsCount];
      
      //встроенный класс очереди
      Sort queue = new Sort();

      Random rnd = new Random();

      //for (int j = 0; j < 3000; j++)
      //{
      //  key[j] = rnd.Next(3000);
      //}

      for (int i = 0; i < 10; i++)
      {
        int N_op = 0;
        //заполняем очередь и хранилище ключей рандомными целыми числами
        for (int j = 0; j < _digitsCount; j++)
        {
          queue.Enqueue(rnd.Next(3000));
        }
        //начало отсчета времени
        time.Start();

        //вызов сортировки
        queue.QuickSort(1, _digitsCount);

        //конец отсета времени
        time.Stop();

        TimeSpan interval = TimeSpan.FromMilliseconds((double)time.ElapsedMilliseconds);
        Console.WriteLine($"Sorting number: {i + 1}");
        Console.WriteLine($"\tNumber of sorted items: {_digitsCount};");
        Console.WriteLine($"\tSorting time (h.m.s.ms): {interval.Hours}, {interval.Minutes}, {interval.Seconds}, {interval.Milliseconds};");
        Console.WriteLine($"\tThe number of operations (N_op): {N_op}");
        Console.WriteLine();


        _digitsCount += 300;
        N_op = 0;
        //очищаем очередь для последующей сортировки с большим кол-вом элементов
        queue.Clear();
        time.Reset();
      }      

      //Console.WriteLine("_________________________________________________________");
      //Console.WriteLine($"Count of items in the queue: {queue.Count}");
      //Console.WriteLine("_________________________________________________________");

      //Console.WriteLine("Unsorted queue:");
      //for (int i = 0; i < _digitsCount; i++)
      //  Console.Write("{0,6}", key[i

      //Console.WriteLine("\nSorted queue:");
      //for (int i = 0; i < _digitsCount; i++)
      //  Console.Write("{0,6}", queue.Dequeue());

      Console.ReadLine();
    }
  }
}