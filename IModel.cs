using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPExample
{
    interface IModel
    {
        string Name
        {
            get;
            set;
        }

        string Data
        {
            get;
            set;
        }

        void AddModelChangeListener(IModelChangeListener listener);
    }
}
