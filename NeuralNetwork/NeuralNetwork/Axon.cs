﻿using ArtificialNeuralNetwork.ActivationFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialNeuralNetwork
{
    public class Axon : IAxon
    {
        private readonly IList<Synapse> _terminals;
        private readonly IActivationFunction _activationFunction;

        public Axon(IList<Synapse> terminals, IActivationFunction activationFunction)
        {
            _activationFunction = activationFunction;
            _terminals = terminals;
        }

        public void ProcessSignal(double signal)
        {
            updateTerminals(calculateActivation(signal));
        }

        internal double calculateActivation(double signal)
        {
            return _activationFunction.CalculateActivation(signal);
        }

        internal void updateTerminals(double outputSignal)
        {
            foreach(Synapse synapse in _terminals)
            {
                synapse.Value = outputSignal;
            }
        }
    }
}