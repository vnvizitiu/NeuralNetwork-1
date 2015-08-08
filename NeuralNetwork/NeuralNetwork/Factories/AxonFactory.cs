﻿using ArtificialNeuralNetwork.ActivationFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialNeuralNetwork.Factories
{
    public class AxonFactory
    {
        private IActivationFunction _activationFunction;

        private AxonFactory(IActivationFunction activationFunction)
        {
            _activationFunction = activationFunction;
        }

        public static AxonFactory GetInstance(IActivationFunction activationFunction)
        {
            return new AxonFactory(activationFunction);
        }

        public IAxon Create(IList<Synapse> terminals)
        {
            return new Axon(terminals, _activationFunction);
        }
    }
}