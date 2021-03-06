//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;
using System.Collections.Generic;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            var train = new Train("-1");
            train.StartEngines();
            Console.WriteLine("\nHello World!\n");

            var trains = new List<Train>();
            for (var i = 0; i < 100; i++)
            {
                var newTrain = new Train(i.ToString());
                trains.Add(newTrain);
            }
            Console.WriteLine($"{Train.InstanceCounter}");
        }
    }
}