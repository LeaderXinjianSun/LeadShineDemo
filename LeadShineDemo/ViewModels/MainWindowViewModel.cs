using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csLTDMC;
using System.Collections.ObjectModel;

namespace LeadShineDemo.ViewModels
{
    class MainWindowViewModel: NotificationObject
    {
        #region 属性
        private string version;

        public string Version
        {
            get { return version; }
            set
            {
                version = value;
                this.RaisePropertyChanged("Version");
            }
        }
        private string messageStr;

        public string MessageStr
        {
            get { return messageStr; }
            set
            {
                messageStr = value;
                this.RaisePropertyChanged("MessageStr");
            }
        }
        private string homePageVisibility;

        public string HomePageVisibility
        {
            get { return homePageVisibility; }
            set
            {
                homePageVisibility = value;
                this.RaisePropertyChanged("HomePageVisibility");
            }
        }
        private string axisPageVisibility;

        public string AxisPageVisibility
        {
            get { return axisPageVisibility; }
            set
            {
                axisPageVisibility = value;
                this.RaisePropertyChanged("AxisPageVisibility");
            }
        }
        private PointViewModel gPos;

        public PointViewModel GPos
        {
            get { return gPos; }
            set
            {
                gPos = value;
                this.RaisePropertyChanged("GPos");
            }
        }
        private PointViewModel cPos;

        public PointViewModel CPos
        {
            get { return cPos; }
            set
            {
                cPos = value;
                this.RaisePropertyChanged("CPos");
            }
        }

        private ObservableCollection<bool> dMC5400ALimP;

        public ObservableCollection<bool> DMC5400ALimP
        {
            get { return dMC5400ALimP; }
            set
            {
                dMC5400ALimP = value;
                this.RaisePropertyChanged("DMC5400ALimP");
            }
        }
        private ObservableCollection<bool> dMC5400ALimN;

        public ObservableCollection<bool> DMC5400ALimN
        {
            get { return dMC5400ALimN; }
            set
            {
                dMC5400ALimN = value;
                this.RaisePropertyChanged("DMC5400ALimN");
            }
        }
        private ObservableCollection<bool> dMC5400AHome;

        public ObservableCollection<bool> DMC5400AHome
        {
            get { return dMC5400AHome; }
            set
            {
                dMC5400AHome = value;
                this.RaisePropertyChanged("DMC5400AHome");
            }
        }
        private ObservableCollection<bool> dMC5400AAlarm;

        public ObservableCollection<bool> DMC5400AAlarm
        {
            get { return dMC5400AAlarm; }
            set
            {
                dMC5400AAlarm = value;
                this.RaisePropertyChanged("DMC5400AAlarm");
            }
        }
        private ObservableCollection<bool> dMC5400AReady;

        public ObservableCollection<bool> DMC5400AReady
        {
            get { return dMC5400AReady; }
            set
            {
                dMC5400AReady = value;
                this.RaisePropertyChanged("DMC5400AReady");
            }
        }
        private ObservableCollection<bool> dMC5400ASVN;

        public ObservableCollection<bool> DMC5400ASVN
        {
            get { return dMC5400ASVN; }
            set
            {
                dMC5400ASVN = value;
                this.RaisePropertyChanged("DMC5400ASVN");
            }
        }
        private ObservableCollection<bool> dMC5400ARST;

        public ObservableCollection<bool> DMC5400ARST
        {
            get { return dMC5400ARST; }
            set
            {
                dMC5400ARST = value;
                this.RaisePropertyChanged("DMC5400ARST");
            }
        }
        private ObservableCollection<PointViewModel> prefilePos;

        public ObservableCollection<PointViewModel> PrefilePos
        {
            get { return prefilePos; }
            set
            {
                prefilePos = value;
                this.RaisePropertyChanged("PrefilePos");
            }
        }
        private ObservableCollection<bool> dMC5400ADi;

        public ObservableCollection<bool> DMC5400ADi
        {
            get { return dMC5400ADi; }
            set
            {
                dMC5400ADi = value;
                this.RaisePropertyChanged("DMC5400ADi");
            }
        }
        private ObservableCollection<object> dMC5400ADo;

        public ObservableCollection<object> DMC5400ADo
        {
            get { return dMC5400ADo; }
            set
            {
                dMC5400ADo = value;
                this.RaisePropertyChanged("DMC5400ADo");
            }
        }

        #endregion
        #region 方法绑定
        public DelegateCommand AppLoadedEventCommand { get; set; }
        public DelegateCommand AppClosedEventCommand { get; set; }
        public DelegateCommand<object> MenuActionCommand { get; set; }
        public DelegateCommand<object> SvnActionCommand { get; set; }
        public DelegateCommand<object> RstActionCommand { get; set; }
        public DelegateCommand<object> Axis_Jog_P_MouseDown_Command { get; set; }
        public DelegateCommand<object> Axis_Jog_N_MouseDown_Command { get; set; }
        public DelegateCommand<object> Axis_Jog_Stop_Command { get; set; }
        public DelegateCommand<object> Axis_Home_Command { get; set; }
        public DelegateCommand<object> Axis_TechCommand { get; set; }
        public DelegateCommand<object> Axis_GOCommand { get; set; }        
        #endregion
        #region 构造函数
        public MainWindowViewModel()
        {
            #region 初始化参数
            Version = "20201104";
            MessageStr = "";
            HomePageVisibility = "Visible";
            AxisPageVisibility = "Collapsed";
            GPos = new PointViewModel();
            CPos = new PointViewModel();
            DMC5400ALimP = new ObservableCollection<bool>();
            DMC5400ALimN = new ObservableCollection<bool>();
            DMC5400AHome = new ObservableCollection<bool>();
            DMC5400AAlarm = new ObservableCollection<bool>();
            DMC5400AReady = new ObservableCollection<bool>();
            DMC5400ASVN = new ObservableCollection<bool>();
            DMC5400ARST = new ObservableCollection<bool>();
            PrefilePos = new ObservableCollection<PointViewModel>();
            DMC5400ADi = new ObservableCollection<bool>();
            DMC5400ADo = new ObservableCollection<object>();
            for (int i = 0; i < 4; i++)
            {
                DMC5400ALimP.Add(false);
                DMC5400ALimN.Add(false);
                DMC5400AHome.Add(false);
                DMC5400AAlarm.Add(false);
                DMC5400AReady.Add(false);
                DMC5400ASVN.Add(false);
                DMC5400ARST.Add(false);                
            }
            for (int i = 0; i < 16; i++)
            {
                DMC5400ADi.Add(false);
                DMC5400ADo.Add(false);
            }
            for (int i = 0; i < 10; i++)
            {
                PrefilePos.Add(new PointViewModel());
            }
            #endregion
            AppLoadedEventCommand = new DelegateCommand(new Action(this.AppLoadedEventCommandExecute));
            AppClosedEventCommand = new DelegateCommand(new Action(this.AppClosedEventCommandExecute));
            MenuActionCommand = new DelegateCommand<object>(new Action<object>(this.MenuActionCommandExecute));
            SvnActionCommand = new DelegateCommand<object>(new Action<object>(this.SvnActionCommandExecute));
            RstActionCommand = new DelegateCommand<object>(new Action<object>(this.RstActionCommandExecute));
            Axis_Jog_P_MouseDown_Command = new DelegateCommand<object>(new Action<object>(this.Axis_Jog_P_MouseDown_CommandExecute));
            Axis_Jog_N_MouseDown_Command = new DelegateCommand<object>(new Action<object>(this.Axis_Jog_N_MouseDown_CommandExecute));
            Axis_Jog_Stop_Command = new DelegateCommand<object>(new Action<object>(this.Axis_Jog_Stop_CommandExecute));
            Axis_Home_Command = new DelegateCommand<object>(new Action<object>(this.Axis_Home_CommandExecute));
            Axis_TechCommand = new DelegateCommand<object>(new Action<object>(this.Axis_TechCommandExecute));
            Axis_GOCommand = new DelegateCommand<object>(new Action<object>(this.Axis_GOCommandExecute));
        }

        private void AppClosedEventCommandExecute()
        {
            try
            {
                LTDMC.dmc_board_close();
            }
            catch { }
        }

        private void Axis_GOCommandExecute(object obj)
        {
            throw new NotImplementedException();
        }

        private void Axis_TechCommandExecute(object obj)
        {
            throw new NotImplementedException();
        }

        private void Axis_Home_CommandExecute(object obj)
        {
            throw new NotImplementedException();
        }

        private void Axis_Jog_N_MouseDown_CommandExecute(object obj)
        {
            throw new NotImplementedException();
        }

        private void Axis_Jog_Stop_CommandExecute(object obj)
        {
            throw new NotImplementedException();
        }

        private void Axis_Jog_P_MouseDown_CommandExecute(object obj)
        {
            throw new NotImplementedException();
        }

        private void RstActionCommandExecute(object obj)
        {
            throw new NotImplementedException();
        }

        private void SvnActionCommandExecute(object obj)
        {
            throw new NotImplementedException();
        }

        private void MenuActionCommandExecute(object obj)
        {
            switch (obj.ToString())
            {
                case "0":
                    HomePageVisibility = "Visible";
                    AxisPageVisibility = "Collapsed";
                    break;
                case "2":
                    HomePageVisibility = "Collapsed";
                    AxisPageVisibility = "Visible";
                    break;
                default:
                    break;
            }
        }

        private void AppLoadedEventCommandExecute()
        {
            LTDMC.dmc_board_init();
            AddMessage("软件加载完成");
        }
        #endregion
        #region 自定义函数
        private void AddMessage(string str)
        {
            string[] s = MessageStr.Split('\n');
            if (s.Length > 1000)
            {
                MessageStr = "";
            }
            if (MessageStr != "")
            {
                MessageStr += "\n";
            }
            MessageStr += System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " " + str;
        }
        #endregion
    }
}
