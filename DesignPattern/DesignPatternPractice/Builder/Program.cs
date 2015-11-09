using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBuilder builder;
            PhoneFactory phoneFactory = new PhoneFactory();

            builder = new CellphoneBuilder();
            phoneFactory.Construct(builder);
            builder.Phone.Show();

            builder = new TelephoneBuilder();
            phoneFactory.Construct(builder);
            builder.Phone.Show();
        }
    }
}
