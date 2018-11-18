using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    class StoreDirector
    {
        public void Construct(StoreBuilder builder)
        {
            builder.BuildId();
            builder.BuildName();
            builder.BuildOrder();
        }
    }
}
