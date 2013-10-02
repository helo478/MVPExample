using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPExample
{
    class Model : IModel
    {
        private ISet<IModelChangeListener> modelChangeListeners = new HashSet<IModelChangeListener>();

        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                FireListeners();
            }
        }

        private string data;
        public string Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
                FireListeners();
            }
        }

        public void AddModelChangeListener(IModelChangeListener modelChangeListener)
        {
            this.modelChangeListeners.Add(modelChangeListener);
        }

        public void RemoveModelChangeListener(IModelChangeListener modelChangeListener)
        {
            this.modelChangeListeners.Remove(modelChangeListener);
        }

        public void FireListeners()
        {
            foreach (IModelChangeListener listener in modelChangeListeners)
            {
                listener.ReflectChange(this);
            }
        }
    }
}
