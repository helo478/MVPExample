using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPExample
{
    public interface IViewUpdateListener
    {
        void ReflectUpdate(Update update);
    }
}
