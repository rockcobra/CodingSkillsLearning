using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Class defination for asia factory
    /// </summary>
    class AsiaFactory : ContinentFactory
    {
        /// <summary>
        /// Create a carnivore
        /// </summary>
        /// <returns>A carnivore</returns>
        public override Carnivore CreateCarnivore()
        {
            return new NorthEastTiger();
        }

        /// <summary>
        /// Create a herbivore
        /// </summary>
        /// <returns>A herbivore</returns>
        public override Herbivore CreateHerbivore()
        {
            return new Panda();
        }
    }
}
