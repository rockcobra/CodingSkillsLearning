using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Class defination for america factory
    /// </summary>
    class AmericaFactory : ContinentFactory
    {
        /// <summary>
        /// Create a carnivore
        /// </summary>
        /// <returns>A carnivore</returns>
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        /// <summary>
        /// Create a herbivore
        /// </summary>
        /// <returns>A herbivore</returns>
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}
