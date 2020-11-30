using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadShineDemo.ViewModels
{
    class KeyMotionViewModel : NotificationObject
    {
        private double x;

        public double X
        {
            get { return x; }
            set
            {
                x = value;
                this.RaisePropertyChanged("X");
            }
        }
        private double y;

        public double Y
        {
            get { return y; }
            set
            {
                y = value;
                this.RaisePropertyChanged("Y");
            }
        }
        private double z;

        public double Z
        {
            get { return z; }
            set
            {
                z = value;
                this.RaisePropertyChanged("Z");
            }
        }
        private int id;

        public int ID
        {
            get { return id; }
            set
            {
                id = value;
                this.RaisePropertyChanged("ID");
            }
        }
        private int vkCode;

        public int VkCode
        {
            get { return vkCode; }
            set
            {
                vkCode = value;
                this.RaisePropertyChanged("VkCode");
            }
        }
        private string keyName;

        public string KeyName
        {
            get { return keyName; }
            set
            {
                keyName = value;
                this.RaisePropertyChanged("KeyName");
            }
        }

    }
}
