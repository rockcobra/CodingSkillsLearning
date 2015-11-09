using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// Class defination for CellPhone
    /// </summary>
    class Phone
    {
        private string phoneType;

        private Dictionary<string, string> parts = new Dictionary<string, string>();

        /// <summary>
        /// Constructor for phone
        /// </summary>
        /// <param name="phoneType">phone type</param>
        public Phone(string phoneType)
        {
            this.phoneType = phoneType;
        }

        /// <summary>
        /// Indexer for phone
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string this[string key]
        {
            get
            {
                return parts[key];
            }
            set
            {
                parts[key] = value;
            }
        }

        /// <summary>
        /// Show the components for the phone
        /// </summary>
        public void Show()
        {
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("Phone type: {0}", phoneType);
            Console.WriteLine("Surface: {0}", parts["Surface"]);
            Console.WriteLine("Button: {0}", parts["Button"]);
        }
    }
}
