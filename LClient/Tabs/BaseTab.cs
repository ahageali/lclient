using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LClient.Tabs
{
    abstract class BaseTab : MetroTabItem
    {
        public abstract void Close();
        public abstract bool Equal(object obj);

        protected bool EqualType(object obj)
        {
            return this.GetType() == obj.GetType();
        }
    }
}
