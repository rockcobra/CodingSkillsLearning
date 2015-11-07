using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Class defination of animal world
    /// </summary>
    class AnimalWorld
    {
        /// <summary>
        /// The contineant
        /// </summary>
        private ContinentFactory continentFactory;

        /// <summary>
        /// Constructor for animal world
        /// </summary>
        /// <param name="factory"></param>
        public AnimalWorld(ContinentFactory factory)
        {
            continentFactory = factory;
        }

        /// <summary>
        /// run the chain
        /// </summary>
        public void RunFoodChain()
        {
            Carnivore carnivore = continentFactory.CreateCarnivore();
            Herbivore herbivore = continentFactory.CreateHerbivore();
            carnivore.Eat(herbivore);
        }
    }
}
