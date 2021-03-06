﻿using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csLTDMC;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using LeadShineDemo.Model;
using ScreenShotDemo;
using System.Drawing;
using Hanbo.Helper;
using ViewROI;
using HalconDotNet;

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
        private ObservableCollection<bool> dMC5400ADo;

        public ObservableCollection<bool> DMC5400ADo
        {
            get { return dMC5400ADo; }
            set
            {
                dMC5400ADo = value;
                this.RaisePropertyChanged("DMC5400ADo");
            }
        }
        private double weightValue;

        public double WeightValue
        {
            get { return weightValue; }
            set
            {
                weightValue = value;
                this.RaisePropertyChanged("WeightValue");
            }
        }
        private HImage cameraIamge;

        public HImage CameraIamge
        {
            get { return cameraIamge; }
            set
            {
                cameraIamge = value;
                this.RaisePropertyChanged("CameraIamge");
            }
        }
        private bool cameraRepaint;

        public bool CameraRepaint
        {
            get { return cameraRepaint; }
            set
            {
                cameraRepaint = value;
                this.RaisePropertyChanged("CameraRepaint");
            }
        }
        private ObservableCollection<ROI> cameraROIList;

        public ObservableCollection<ROI> CameraROIList
        {
            get { return cameraROIList; }
            set
            {
                cameraROIList = value;
                this.RaisePropertyChanged("CameraROIList");
            }
        }
        private HObject cameraAppendHObject;

        public HObject CameraAppendHObject
        {
            get { return cameraAppendHObject; }
            set
            {
                cameraAppendHObject = value;
                this.RaisePropertyChanged("CameraAppendHObject");
            }
        }
        private Tuple<string, object> cameraGCStyle;

        public Tuple<string, object> CameraGCStyle
        {
            get { return cameraGCStyle; }
            set
            {
                cameraGCStyle = value;
                this.RaisePropertyChanged("CameraGCStyle");
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
        public DelegateCommand<object> OutActionCommand { get; set; }
        public DelegateCommand FuncCommand { get; set; }
        public DelegateCommand StopCommand { get; set; }
        #endregion
        #region 变量
        ushort _CardID = 0;
        private string iniParameterPath = System.Environment.CurrentDirectory + "\\Parameter.ini";
        bool runflag = false;
        int stepnum = 0;
        bool[] homed = new bool[3];
        private short res;
        public short Res
        {
            get { return res; }
            set {
                res = value;
                if (value != 0)
                {
                    AddMessage("指令执行错误");
                }
            }
        }
        ScreenCapture screenCapture = new ScreenCapture();
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
            DMC5400ADo = new ObservableCollection<bool>();
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
                PrefilePos.Add(new PointViewModel()
                {
                    X = double.Parse(Inifile.INIGetStringValue(iniParameterPath, "Position", $"X{i}", "0")),
                    Y = double.Parse(Inifile.INIGetStringValue(iniParameterPath, "Position", $"Y{i}", "0")),
                    Z = double.Parse(Inifile.INIGetStringValue(iniParameterPath, "Position", $"Z{i}", "0"))
                });
            }
            CameraROIList = new ObservableCollection<ROI>();
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
            OutActionCommand = new DelegateCommand<object>(new Action<object>(this.OutActionCommandExecute));
            FuncCommand = new DelegateCommand(new Action(this.FuncCommandExecute));
            StopCommand = new DelegateCommand(new Action(this.StopCommandExecute));
            System.Diagnostics.Process[] myProcesses = System.Diagnostics.Process.GetProcessesByName("LeadShineDemo");//获取指定的进程名   
            if (myProcesses.Length > 1) //如果可以获取到知道的进程名则说明已经启动
            {
                System.Windows.MessageBox.Show("不允许重复打开软件", "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                System.Windows.Application.Current.Shutdown();
            }
        }

        private void StopCommandExecute()
        {
            runflag = false;
            Res = LTDMC.dmc_stop(_CardID, 0, 0);
            Res = LTDMC.dmc_stop(_CardID, 1, 0);
            Res = LTDMC.dmc_stop(_CardID, 2, 0);
            stepnum = -1;
        }

        private void FuncCommandExecute()
        {
            //runflag = true;
            //stepnum = 0;

            //System.Diagnostics.Process[] myProcesses = System.Diagnostics.Process.GetProcessesByName("USBKB");//获取指定的进程名   
            //if (myProcesses.Length >= 1) //如果可以获取到知道的进程名则说明已经启动
            //{
            //    var image = screenCapture.CaptureWindow(myProcesses[0].MainWindowHandle);

            var image = screenCapture.CaptureScreen();
            var bitmap = new System.Drawing.Bitmap(image);
            CameraIamge = ImageConventer.ConvertBitmapToHalconImage(bitmap);
            //}


        }

        private void OutActionCommandExecute(object obj)
        {
            ushort bitno = ushort.Parse(obj.ToString());
            if (DMC5400ADo[bitno])
            {
                Res = LTDMC.dmc_write_outbit(_CardID, bitno, 0);
            }
            else
            {
                Res = LTDMC.dmc_write_outbit(_CardID, bitno, 1);
            }
        }

        private void AppClosedEventCommandExecute()
        {
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    Res = LTDMC.dmc_write_sevrst_pin(_CardID, (ushort)i, 1);
                    Res = LTDMC.dmc_write_sevon_pin(_CardID, (ushort)i, 1);

                }
                for (int i = 0; i < 16; i++)
                {
                    Res = LTDMC.dmc_write_outbit(_CardID, (ushort)i, 1);
                }
                LTDMC.dmc_board_close();
            }
            catch { }
        }

        private void Axis_GOCommandExecute(object obj)
        {
            if (System.Windows.Forms.MessageBox.Show($"是否运动到点{int.Parse(obj.ToString()) + 1}？", "确认", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (LTDMC.dmc_check_done(_CardID, 0) == 1 && LTDMC.dmc_check_done(_CardID, 1) == 1 && LTDMC.dmc_check_done(_CardID, 2) == 1)
                {
                    Task.Run(()=> {
                        DMC5400ASVN[0] = true; DMC5400ASVN[1] = true; DMC5400ASVN[2] = true;
                        Res = LTDMC.dmc_write_sevon_pin(_CardID, 0, 0);//励磁
                        Res = LTDMC.dmc_write_sevon_pin(_CardID, 1, 0);//励磁
                        Res = LTDMC.dmc_write_sevon_pin(_CardID, 2, 0);//励磁

                        Res = LTDMC.dmc_set_profile(_CardID, 0, 200, 2000, 0.1, 0.1, 1000);
                        Res = LTDMC.dmc_set_profile(_CardID, 1, 200, 2000, 0.1, 0.1, 1000);
                        Res = LTDMC.dmc_set_profile(_CardID, 2, 200, 2000, 0.1, 0.1, 1000);

                        Res = LTDMC.dmc_pmove(_CardID, 0, (int)(PrefilePos[int.Parse(obj.ToString())].X * 100), 1);
                        Res = LTDMC.dmc_pmove(_CardID, 1, (int)(PrefilePos[int.Parse(obj.ToString())].Y * 100), 1);
                        Res = LTDMC.dmc_pmove(_CardID, 2, (int)(PrefilePos[int.Parse(obj.ToString())].Z * 100), 1);

                        while (LTDMC.dmc_check_done(_CardID, 0) == 0 || LTDMC.dmc_check_done(_CardID, 1) == 0 || LTDMC.dmc_check_done(_CardID, 2) == 0)
                        {
                            System.Threading.Thread.Sleep(100);
                        }
                    });
                    


                }
                else
                {
                    AddMessage("错误:轴Busy");
                }
            }
        }

        private void Axis_TechCommandExecute(object obj)
        {
            if (System.Windows.Forms.MessageBox.Show($"是否示教点{int.Parse(obj.ToString()) + 1}？", "确认", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                PrefilePos[int.Parse(obj.ToString())].X = CPos.X;
                PrefilePos[int.Parse(obj.ToString())].Y = CPos.Y;
                PrefilePos[int.Parse(obj.ToString())].Z = CPos.Z;
                Inifile.INIWriteValue(iniParameterPath, "Position", "X" + obj.ToString(), PrefilePos[int.Parse(obj.ToString())].X.ToString());
                Inifile.INIWriteValue(iniParameterPath, "Position", "Y" + obj.ToString(), PrefilePos[int.Parse(obj.ToString())].Y.ToString());
                Inifile.INIWriteValue(iniParameterPath, "Position", "Z" + obj.ToString(), PrefilePos[int.Parse(obj.ToString())].Z.ToString());
            }
        }

        private void Axis_Home_CommandExecute(object obj)
        {
            ushort axis = ushort.Parse(obj.ToString());
            if (System.Windows.Forms.MessageBox.Show("是否回原点？", "确认", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (LTDMC.dmc_check_done(_CardID, axis) == 1)
                {
                    Task.Run(() =>
                    {
                        DMC5400ASVN[axis] = true;
                        Res = LTDMC.dmc_write_sevon_pin(_CardID, axis, 0);//励磁

                        Res = LTDMC.dmc_set_profile(_CardID, axis, 200, 2000, 0.1, 0.1, 1000);
                        
                        switch (axis)
                        {
                            case 0:
                            case 1:
                                Res = LTDMC.dmc_pmove(_CardID, axis, -99999, 0);
                                while (!DMC5400ALimN[axis])
                                {
                                    System.Threading.Thread.Sleep(10);
                                }
                                Res = LTDMC.dmc_stop(_CardID, axis, 0);
                                System.Threading.Thread.Sleep(100);
                                Res = LTDMC.dmc_set_homemode(_CardID, axis, 1, 0, 1, 0);//设置回零模式
                                break;
                            case 2:
                                Res = LTDMC.dmc_pmove(_CardID, axis, 99999, 0);
                                while (!DMC5400ALimP[axis])
                                {
                                    System.Threading.Thread.Sleep(10);
                                }
                                Res = LTDMC.dmc_stop(_CardID, axis, 0);
                                System.Threading.Thread.Sleep(100);
                                Res = LTDMC.dmc_set_homemode(_CardID, axis, 0, 0, 1, 0);//设置回零模式
                                break;
                            default:
                                break;
                        }
                        
                        Res = LTDMC.dmc_home_move(_CardID, axis);
                        while (LTDMC.dmc_check_done(_CardID,axis) == 0)
                        {
                            System.Threading.Thread.Sleep(100);
                        }
                        System.Threading.Thread.Sleep(500);
                        Res = LTDMC.dmc_set_position(_CardID, axis, 0);
                        Res = LTDMC.dmc_set_encoder(_CardID, axis, 0);
                        homed[axis] = true;
                    });
                }
                else
                {
                    AddMessage("错误:轴Busy");
                }
            }

        }

        private void Axis_Jog_N_MouseDown_CommandExecute(object obj)
        {
            ushort axis = ushort.Parse(obj.ToString());
            if (LTDMC.dmc_check_done(_CardID, axis) == 1)
            {
                DMC5400ASVN[axis] = true;
                Res = LTDMC.dmc_write_sevon_pin(_CardID, axis, 0);//励磁
                Res = LTDMC.dmc_set_profile(_CardID, axis, 200, 2000, 0.1, 0.1, 1000);
                Res = LTDMC.dmc_vmove(_CardID, axis, 0);
            }
            else
            {
                AddMessage("错误:轴Busy");
            }
        }

        private void Axis_Jog_Stop_CommandExecute(object obj)
        {
            ushort axis = ushort.Parse(obj.ToString());
            Res = LTDMC.dmc_stop(_CardID, axis, 0);
        }

        private void Axis_Jog_P_MouseDown_CommandExecute(object obj)
        {
            ushort axis = ushort.Parse(obj.ToString());
            if (LTDMC.dmc_check_done(_CardID, axis) == 1)
            {
                DMC5400ASVN[axis] = true;
                Res = LTDMC.dmc_write_sevon_pin(_CardID, axis, 0);//励磁
                Res = LTDMC.dmc_set_profile(_CardID,axis,200,2000,0.1,0.1,1000);
                Res = LTDMC.dmc_vmove(_CardID,axis,1);
            }
            else
            {
                AddMessage("错误:轴Busy");
            }
        }

        private void RstActionCommandExecute(object obj)
        {
            ushort axis = ushort.Parse(obj.ToString());
            if (DMC5400ARST[axis])
            {
                Res = LTDMC.dmc_write_sevrst_pin(_CardID, axis, 0);
            }
            else
            {
                Res = LTDMC.dmc_write_sevrst_pin(_CardID, axis, 1);
            }
        }

        private async void SvnActionCommandExecute(object obj)
        {
            ushort axis = ushort.Parse(obj.ToString());
            if (DMC5400ASVN[axis])
            {
                Res = LTDMC.dmc_write_sevon_pin(_CardID, axis, 0);
                await Task.Delay(200);
                Res = LTDMC.dmc_set_position(_CardID, axis, LTDMC.dmc_get_encoder(_CardID, axis));
            }
            else
            {
                Res = LTDMC.dmc_write_sevon_pin(_CardID, axis, 1);
            }
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
            short num = LTDMC.dmc_board_init();//获取卡数量
            if (num <= 0 || num > 8)
            {
                AddMessage("初始卡失败!");
            }
            else
            {
                ushort _num = 0;
                ushort[] cardids = new ushort[8];
                uint[] cardtypes = new uint[8];
                Res = LTDMC.dmc_get_CardInfList(ref _num, cardtypes, cardids);
                if (Res != 0)
                {
                    AddMessage("获取卡信息失败!");
                }
                else
                {
                    _CardID = cardids[0];
                    Res = LTDMC.dmc_download_configfile(_CardID, "Motion.ini");
                    if (Res == 0)
                    {
                        Res = LTDMC.nmc_set_connect_state(_CardID, 1, 1, 0);
                        if (Res != 0)
                        {
                            AddMessage("CANOpen异常");
                        }
                        else
                        {
                            ushort NodeNum = 0, _state = 0;
                            LTDMC.nmc_get_connect_state(_CardID, ref NodeNum, ref _state);
                            if (_state != 1)
                            {
                                AddMessage("CANOpen异常");
                            }
                            else
                            {
                                LTDMC.nmc_set_ad_mode(_CardID, 1, 0, 1, 0);           
                                AddMessage("软件加载完成");
                                Run();
                            }

                        }
                    }

                }
            }
            


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
        private async void Run()
        {
            bool DMC5400ADi_0 = false;
            bool presurefirst = false;double _value1 = 0;
            while (true)
            {
                try
                {
                    #region IO
                    var portno0 = LTDMC.dmc_read_inport(_CardID, 0);
                    for (int i = 0; i < 16; i++)
                    {
                        DMC5400ADi[i] = (portno0 & 0x1 << i) == 0;
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        DMC5400ALimP[i] = (portno0 & 0x10000 << i) != 0;
                        DMC5400ALimN[i] = (portno0 & 0x1000000 << i) != 0;
                    }
                    var portno1 = LTDMC.dmc_read_inport(_CardID, 1);
                    for (int i = 0; i < 4; i++)
                    {
                        DMC5400AHome[i] = (portno1 & 0x1 << i) == 0;
                        DMC5400AAlarm[i] = (portno1 & 0x100 << i) != 0;
                        DMC5400AReady[i] = (portno1 & 0x10000 << i) == 0;
                    }
                    #endregion
                    #region 轴状态
                    GPos.X = (double)(LTDMC.dmc_get_position(_CardID, 0)) / 100;
                    GPos.Y = (double)(LTDMC.dmc_get_position(_CardID, 1)) / 100;
                    GPos.Z = (double)(LTDMC.dmc_get_position(_CardID, 2)) / 100;

                    CPos.X = (double)(LTDMC.dmc_get_encoder(_CardID, 0)) / 100;
                    CPos.Y = (double)(LTDMC.dmc_get_encoder(_CardID, 1)) / 100;
                    CPos.Z = (double)(LTDMC.dmc_get_encoder(_CardID, 2)) / 100;

                    #endregion
                    #region 模拟量
                    double _value = 0;
                    LTDMC.nmc_get_ad_input(_CardID, 1, 0, ref _value);
                    if (!presurefirst)
                    {
                        _value1 = _value;
                        presurefirst = true;
                    }
                    WeightValue = (_value - _value1) / 16 * 1000;
                    #endregion
                    #region 运行函数
                    if (runflag && DMC5400ASVN[0] && DMC5400ASVN[1] && DMC5400ASVN[2] && homed[0] && homed[1] && homed[2])
                    {
                        switch (stepnum)
                        {
                            case 0:
                                //Res = LTDMC.dmc_set_profile(_CardID, 0, 200, 50000, 0.1, 0.1, 1000);
                                //Res = LTDMC.dmc_set_profile(_CardID, 1, 200, 50000, 0.1, 0.1, 1000);
                                Res = LTDMC.dmc_set_profile(_CardID, 2, 200, 10000, 0.01, 0.01, 1000);

                                //Res = LTDMC.dmc_pmove(_CardID, 0, (int)(PrefilePos[0].X * 100), 1);
                                //Res = LTDMC.dmc_pmove(_CardID, 1, (int)(PrefilePos[0].Y * 100), 1);
                                Res = LTDMC.dmc_pmove(_CardID, 2, (int)(PrefilePos[0].Z * 100), 1);

                                stepnum = 1;
                                break;
                            case 1:
                                //if (LTDMC.dmc_check_done(_CardID, 0) == 1 && LTDMC.dmc_check_done(_CardID, 1) == 1 && LTDMC.dmc_check_done(_CardID, 2) == 1)
                                if (LTDMC.dmc_check_done(_CardID, 2) == 1)
                                {
                                    stepnum = 2;
                                }
                                break;
                            case 2:
                                await Task.Delay(1000);
                                stepnum = 3;
                                break;
                            case 3:
                                //Res = LTDMC.dmc_set_profile(_CardID, 0, 200, 50000, 0.1, 0.1, 1000);
                                //Res = LTDMC.dmc_set_profile(_CardID, 1, 200, 50000, 0.1, 0.1, 1000);
                                Res = LTDMC.dmc_set_profile(_CardID, 2, 200, 10000, 0.01, 0.01, 1000);

                                //Res = LTDMC.dmc_pmove(_CardID, 0, (int)(PrefilePos[1].X * 100), 1);
                                //Res = LTDMC.dmc_pmove(_CardID, 1, (int)(PrefilePos[1].Y * 100), 1);
                                Res = LTDMC.dmc_pmove(_CardID, 2, (int)(PrefilePos[1].Z * 100), 1);

                                stepnum = 4;
                                break;
                            case 4:
                                //if (LTDMC.dmc_check_done(_CardID, 0) == 1 && LTDMC.dmc_check_done(_CardID, 1) == 1 && LTDMC.dmc_check_done(_CardID, 2) == 1)
                                if (LTDMC.dmc_check_done(_CardID, 2) == 1)
                                {
                                    stepnum = 5;
                                }
                                break;
                            case 5:
                                await Task.Delay(1000);
                                stepnum = 0;
                                break;
                            case 6:
                                //Res = LTDMC.dmc_set_profile(_CardID, 0, 200, 50000, 0.1, 0.1, 1000);
                                //Res = LTDMC.dmc_set_profile(_CardID, 1, 200, 50000, 0.1, 0.1, 1000);
                                Res = LTDMC.dmc_set_profile(_CardID, 2, 200, 50000, 0.1, 0.1, 1000);

                                //Res = LTDMC.dmc_pmove(_CardID, 0, (int)(PrefilePos[2].X * 100), 1);
                                //Res = LTDMC.dmc_pmove(_CardID, 1, (int)(PrefilePos[2].Y * 100), 1);
                                Res = LTDMC.dmc_pmove(_CardID, 2, (int)(PrefilePos[2].Z * 100), 1);

                                stepnum = 7;
                                break;
                            case 7:
                                //if (LTDMC.dmc_check_done(_CardID, 0) == 1 && LTDMC.dmc_check_done(_CardID, 1) == 1 && LTDMC.dmc_check_done(_CardID, 2) == 1)
                                if (LTDMC.dmc_check_done(_CardID, 2) == 1)
                                {
                                    stepnum = 8;
                                }
                                break;
                            case 8:
                                await Task.Delay(1000);
                                stepnum = 0;
                                break;
                            default:
                                break;
                        }
                    }
                    if (DMC5400ADi_0 != DMC5400ADi[0])
                    {
                        DMC5400ADi_0 = DMC5400ADi[0];
                        if (DMC5400ADi[0])
                        {
                            runflag = false;
                            Res = LTDMC.dmc_stop(_CardID, 0, 0);
                            Res = LTDMC.dmc_stop(_CardID, 1, 0);
                            Res = LTDMC.dmc_stop(_CardID, 2, 0);
                            stepnum = -1;
                            DMC5400ASVN[0] = false;
                            DMC5400ASVN[1] = false;
                            DMC5400ASVN[2] = false;
                            Res = LTDMC.dmc_write_sevon_pin(_CardID, 0, 1);
                            Res = LTDMC.dmc_write_sevon_pin(_CardID, 1, 1);
                            Res = LTDMC.dmc_write_sevon_pin(_CardID, 2, 1);
                            AddMessage("急停按钮 按下");
                        }
                    }
                    #endregion

                }
                catch { }

                await Task.Delay(10);
            }
        }
        #endregion
    }
}
