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
    class CellphoneBuilder : PhoneBuilder
    {
        /// <summary>
        /// Constrcuctor for CellphoneBuilder
        /// </summary>
        public CellphoneBuilder()
        {
            phone = new Phone("Cellphone");
        }

        /// <summary>
        /// 
        /// </summary>
        public override void BuildButton()
        {
            phone["Button"] = "Cellphone button";
        }

        /// <summary>
        /// 
        /// </summary>
        public override void BuildSurface()
        {
            phone["Surface"] = "Cellphone surface";
        }
    }
}
