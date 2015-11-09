using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class PhoneBuilder
    {
        protected Phone phone;

        public Phone Phone
        {
            get
            {
                return phone;
            }
        }

        public abstract void BuildSurface();

        public abstract void BuildButton();
    }
}
