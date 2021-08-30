//--------------------------------------------------------------------------------
// <copyright file="Train.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace ClassLibrary
{
    /// <summary>
    /// Esta clase representa un tren muy básico.
    /// </summary>
    public class Train
    {
        /// <summary>
        /// Obtiene un valor que indica si las maquinas del tren han sido encendidas o no.
        /// </summary>
        /// <value><c>true</c> si las máquinas fueron encendidas, <c>false</c> en caso contrario.</value>
        public bool IsEngineStarted { get; private set; }

        /// <summary>
        /// Variable de clase privada que registra la cantidad de instancias existentes.
        /// </summary>
        /// <value><c>int</c> correspondiente a la cantidad de instancias.</value>
        private static int _instanceCounter = 0;

        /// <summary>
        /// Variable de clase publica que expone el contenido de <c>_instanceCounter</c>
        /// </summary>
        /// <value><c>int</c> correspondiente a la cantidad de instancias.</value>
        public static int InstanceCounter
        { 
            get { return _instanceCounter; }
            private set { _instanceCounter = value; }
        }

        /// <summary>
        /// Identificador del tren.
        /// </summary>
        /// <value><c>string</c> que identifica a la instancia del tren.</value>
        public string TrainId { get; private set; }

        /// <summary>
        /// Constructor de la clase Train. Crea una instancia con el identificador provisto e incrementa el contador de instancias en 1.
        /// </summary>
        /// <param name="trainId">Identificador del tren que se usara para la nueva instancia.</param>
        public Train(string trainId) 
        {
            this.TrainId = trainId;
            InstanceCounter++;
        }

        /// <summary>
        /// Destructor de la clase Train. Disminuye el contador de instancias en 1.
        /// </summary>
        ~Train()
        {
            InstanceCounter--;
        }

        /// <summary>
        /// Enciende las máquinas del tren.
        /// </summary>
        /// <returns>
        /// <c>true</c> si las máquinas pueden ser encendidas, <c>false</c> en caso contrario.
        /// </returns>
        public bool StartEngines()
        {
            if (this.IsEngineStarted)
            {
                Console.Write("The engines are already running");
                return false;
            }

            this.IsEngineStarted = true;
            Console.Write("Engines on");
            return true;
        }

        /// <summary>
        /// Detiene las máquinas del tren.
        /// </summary>
        /// <returns>
        /// <c>true</c> si las máquinas pueden ser detenidas, <c>false</c> en caso contrario.
        /// </returns>
        public bool StopEngines()
        {
            if (this.IsEngineStarted)
            {
                this.IsEngineStarted = false;
                Console.Write("Engines off");
                return true;
            }

            Console.Write("The engines are already stopped");
            return this.IsEngineStarted;
        }

    }
}