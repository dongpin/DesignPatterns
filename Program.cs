﻿using System;
using System.Collections.Generic;

namespace com.quansheng.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            RunSingletonPattern();

            RunAdapterPattern();

            RunStrategyPattern();
            RunObserverPattern(); 
            RunCommandPattern();      
            RunIteratorPattern();
        }

        #region Creational Design Patterns
        private static void RunSingletonPattern()
        {
            PrintOutputTitle("Singleton");
            var instance = Singleton.Product.Instance();
            instance = Singleton.Product.Instance();
        }
        #endregion

        #region Structural Design Patterns
        private static void RunAdapterPattern()
        {
            PrintOutputTitle("Adapter");
            var instance = new Adapter.Adapter();
            instance.Request();
        }
        #endregion

        #region Behavioral Design Patterns
        public static void RunStrategyPattern()
        {
            PrintOutputTitle("Strategy");
            var averageMethod = new Strategy.AverageByMean();
            var values = new List<int>(){1, 2, 3};
            var result = Strategy.Calculator.AverageFor(values, averageMethod);

            Console.WriteLine("Output: {0}", result);
        }

        public static void RunObserverPattern()
        {
            PrintOutputTitle("Observer");
            var subject = new Observer.ConcreteSubject();
            var ob1 = new Observer.Observer(5);
            var ob2 = new Observer.Observer(10);
            var ob3 = new Observer.Observer(20);
            subject.Add(ob1);
            subject.Add(ob2);
            subject.Add(ob3);

            subject.State = 0;
        }

        private static void RunCommandPattern()
        {
            PrintOutputTitle("Command");
            var receiver = new Command.FirstReceiver();
            var command = new Command.FirstCommand(receiver);
            var invoker = new Command.Invoker(command);

            invoker.ExecuteCommand();
        }

        private static void RunIteratorPattern()
        {
            PrintOutputTitle("Iterator");
            var aggregate = new Iterator.ConcreteAggregate();
            aggregate[0] = "A";
            aggregate[1] = "B";
            aggregate[2] = "C";

            Iterator.Iterator iterator = aggregate.CreateIterator();

            Console.WriteLine($"Item {iterator.First()}");
            while (!iterator.IsDone())
            {
                Console.WriteLine($"Item {iterator.Next()}");
            }          
        }
        #endregion

        #region helper methods
        private static void PrintOutputTitle(string patternName)
        {
            Console.WriteLine();
            Console.WriteLine("##### {0} Pattern #####", patternName);
        }
        #endregion
    }
}
