using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Class defination for northeast tiger
    /// </summary>
    class NorthEastTiger : Carnivore
    {
        /// <summary>
        /// Eat action of northeast tiger
        /// </summary>
        /// <param name="herbivore">The herbivore to eat</param>
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine(string.Format("{0} eats {1}", this.GetType().Name, herbivore.GetType().Name));
        }
    }
}
