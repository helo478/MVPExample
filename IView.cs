using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPExample
{
    interface IView
    {
        void AddViewUpdateListener(IViewUpdateListener listener);

        void UpdateName(string name);

        void UpdateData(string data);
    }
}
