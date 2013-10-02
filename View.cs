using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPExample
{
    public partial class View : Form, IView
    {
        private ISet<IViewUpdateListener> updateListeners = new HashSet<IViewUpdateListener>();

        public View()
        {
            InitializeComponent();
        }

        public void AddViewUpdateListener(IViewUpdateListener listener)
        {
            updateListeners.Add(listener);
        }

        public void UpdateName(string name)
        {
            this.nameLabel.Text = name;
        }

        public void UpdateData(string data)
        {
            this.dataLabel.Text = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.Name = nameField.Text;
            update.Data = dataField.Text;

            FireListeners(update);
        }

        private void FireListeners(Update update)
        {
            foreach (IViewUpdateListener listener in updateListeners)
            {
                listener.ReflectUpdate(update);
            }
        }
    }
}
