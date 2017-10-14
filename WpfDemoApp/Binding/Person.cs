using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfDemoApp.Binding
{
    public class Person : INotifyPropertyChanged
    {
        int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Age"));
            }
        }
        string _name;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
