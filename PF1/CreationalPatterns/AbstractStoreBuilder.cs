using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF1
{
    abstract class AbstractStoreBuilder
    {
        public abstract void BuildId();

        public abstract void BuildName();

        public abstract void BuildOrder();

        public abstract Store GetStore();
    }
}
