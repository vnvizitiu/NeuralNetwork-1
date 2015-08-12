﻿using System;
using System.Collections.Generic;
namespace ArtificialNeuralNetwork.Factories
{
    public interface ISomaFactory
    {
        ISoma Create(IList<Synapse> dendrites);
    }
}