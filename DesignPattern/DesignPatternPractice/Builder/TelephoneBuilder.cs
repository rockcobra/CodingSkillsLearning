using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 
    /// </summary>
    class TelephoneBuilder : PhoneBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        public TelephoneBuilder()
        {
            phone = new Phone("Telephone");
        }

        /// <summary>
        /// 
        /// </summary>
        public override void BuildButton()
        {
            phone["Button"] = "Telephone button";
        }

        /// <summary>
        /// 
        /// </summary>
        public override void BuildSurface()
        {
            phone["Surface"] = "Telephone surface";
        }
    }
}
