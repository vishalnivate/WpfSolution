
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfDemoApp.Assignment
{
    public class UserInterface : INotifyPropertyChanged
    {
        string _username;
        int _age;
        string _favcolor;
        string _image;
        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

        public string Favcolor
        {
            get
            {
                return _favcolor;
            }

            set
            {
                _favcolor = value;
            }
        }

        public string Image
        {
            get
            {
                return _image;
            }

            set
            {
                _image = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged=delegate { };
    }
}
