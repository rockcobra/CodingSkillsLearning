using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Abstract class for Carnivore
    /// </summary>
    abstract class Carnivore
    {
        /// <summary>
        /// Eat a herbivore
        /// </summary>
        /// <param name="herbivore">The herbivore to eat</param>
        public abstract void Eat(Herbivore herbivore);
    }
}
