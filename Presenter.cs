using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPExample
{

    class Presenter : IPresenter, IModelChangeListener, IViewUpdateListener
    {
        private IModel model;

        private IView view;

        public Presenter(IModel model, IView view)
        {
            this.model = model;
            this.view = view;

            RegisterEventListeners();
        }

        private void RegisterEventListeners()
        {
            model.AddModelChangeListener(this);
            view.AddViewUpdateListener(this);
        }
        
        public void ReflectChange(IModel model)
        {
            PresentName(model.Name);
            PresentData(model.Data);
        }

        public void PresentName(string name)
        {
            view.UpdateName(name);
        }

        public void PresentData(string data) 
        {
            view.UpdateData(data);
        }

        public void ReflectUpdate(Update update)
        {
            this.model.Name = update.Name;
            this.model.Data = update.Data;
        }
    }
}
