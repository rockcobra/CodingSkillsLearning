using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Class defination for wolf
    /// </summary>
    class Wolf : Carnivore
    {
        /// <summary>
        /// Eat action of wolf
        /// </summary>
        /// <param name="herbivore">The herbivore to eat</param>
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine(string.Format("{0} eats {1}", this.GetType().Name, herbivore.GetType().Name));
        }
    }
}
