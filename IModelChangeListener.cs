using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPExample
{
    interface IModelChangeListener
    {
        void ReflectChange(IModel model);
    }
}
