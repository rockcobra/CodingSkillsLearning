using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Abstract class for continent factory
    /// </summary>
    abstract class ContinentFactory
    {
        /// <summary>
        /// Create a herbivore
        /// </summary>
        /// <returns></returns>
        public abstract Herbivore CreateHerbivore();

        /// <summary>
        /// Create a carnivore
        /// </summary>
        /// <returns></returns>
        public abstract Carnivore CreateCarnivore();
    }
}
