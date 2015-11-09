using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class PhoneFactory
    {
        public void Construct(PhoneBuilder phoneBuilder)
        {
            phoneBuilder.BuildButton();
            phoneBuilder.BuildSurface();
        }
    }
}
