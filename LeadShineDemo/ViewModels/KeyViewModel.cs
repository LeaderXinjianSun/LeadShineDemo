using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadShineDemo.ViewModels
{
    class KeyViewModel : NotificationObject
    {
        private int top;

        public int Top
        {
            get { return top; }
            set
            {
                top = value;
                this.RaisePropertyChanged("Top");
            }
        }
        private int left;

        public int Left
        {
            get { return left; }
            set
            {
                left = value;
                this.RaisePropertyChanged("Left");
            }
        }
        private int width;

        public int Width
        {
            get { return width; }
            set
            {
                width = value;
                this.RaisePropertyChanged("Width");
            }
        }
        private int height;

        public int Height
        {
            get { return height; }
            set
            {
                height = value;
                this.RaisePropertyChanged("Height");
            }
        }
        private bool pressed;

        public bool Pressed
        {
            get { return pressed; }
            set
            {
                pressed = value;
                this.RaisePropertyChanged("Pressed");
            }
        }
        private bool pressing;

        public bool Pressing
        {
            get { return pressing; }
            set
            {
                pressing = value;
                this.RaisePropertyChanged("Pressing");
            }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                this.RaisePropertyChanged("Name");
            }
        }

    }
}
