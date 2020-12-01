using Microsoft.Practices.Prism.Commands;
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
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;

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
        public string parameterPageVisibility;
        public string ParameterPageVisibility
        {
            get { return parameterPageVisibility; }
            set
            {
                parameterPageVisibility = value;
                this.RaisePropertyChanged("ParameterPageVisibility");
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
        private SeriesCollection seriesCollection1;

        public SeriesCollection SeriesCollection1
        {
            get { return seriesCollection1; }
            set
            {
                seriesCollection1 = value;
                this.RaisePropertyChanged("SeriesCollection1");
            }
        }
        private double selfWeightValue;

        public double SelfWeightValue
        {
            get { return selfWeightValue; }
            set
            {
                selfWeightValue = value;
                this.RaisePropertyChanged("SelfWeightValue");
            }
        }
        private ObservableCollection<KeyViewModel> keys;

        public ObservableCollection<KeyViewModel> Keys
        {
            get { return keys; }
            set
            {
                keys = value;
                this.RaisePropertyChanged("Keys");
            }
        }
        private int vitualCode;

        public int VitualCode
        {
            get { return vitualCode; }
            set
            {
                vitualCode = value;
                this.RaisePropertyChanged("VitualCode");
            }
        }
        private int scanCode;

        public int ScanCode
        {
            get { return scanCode; }
            set
            {
                scanCode = value;
                this.RaisePropertyChanged("ScanCode");
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
        private int mouseX;

        public int MouseX
        {
            get { return mouseX; }
            set
            {
                mouseX = value;
                this.RaisePropertyChanged("MouseX");
            }
        }
        private int mouseY;

        public int MouseY
        {
            get { return mouseY; }
            set
            {
                mouseY = value;
                this.RaisePropertyChanged("MouseY");
            }
        }
        private ObservableCollection<KeyMotionViewModel> keyMotions;

        public ObservableCollection<KeyMotionViewModel> KeyMotions
        {
            get { return keyMotions; }
            set
            {
                keyMotions = value;
                this.RaisePropertyChanged("KeyMotions");
            }
        }
        private KeyMotionViewModel selectedKeyMotion;

        public KeyMotionViewModel SelectedKeyMotion
        {
            get { return selectedKeyMotion; }
            set
            {
                selectedKeyMotion = value;
                this.RaisePropertyChanged("SelectedKeyMotion");
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
        public DelegateCommand GetSelfWeightValueCommand { get; set; }
        public DelegateCommand<object> OperateButtonCommand { get; set; }
        public DelegateCommand ResetCommand { get; set; }
        public DelegateCommand Axis_SaveCommand { get; set; }
        public DelegateCommand KeyMotionSaveCommand { get; set; }
        #endregion
        #region 变量
        ushort _CardID = 0;
        private string iniParameterPath = System.Environment.CurrentDirectory + "\\Parameter.ini";
        bool runflag = false;
        int stepnum = 0;
        bool[] homed = new bool[3];
        bool collect = false;bool start = false;int activekeycode = -1;
        KeyboardListener Listener = new KeyboardListener();
        MouseListener MListener = new MouseListener();
        List<KeyInfo> keymap;
        List<Keycode> keycodes;
        List<KeyMotionInfo> keymotionmap;
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
        #endregion
        #region 构造函数
        public MainWindowViewModel()
        {
            #region 初始化参数
            Version = "20201104";
            MessageStr = "";
            HomePageVisibility = "Visible";
            AxisPageVisibility = "Collapsed";
            ParameterPageVisibility = "Collapsed";
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
            SelfWeightValue = double.Parse(Inifile.INIGetStringValue(iniParameterPath, "System", "SelfWeightValue", "0"));
            SeriesCollection1 = new SeriesCollection(){
                    new LineSeries
                    {
                        Title = "值",
                        Fill = Brushes.Transparent,
                        Stroke = Brushes.Red,
                        PointGeometrySize = 0.1,
                        Values = new ChartValues<double>()
                    }
                };
            Keys = new ObservableCollection<KeyViewModel>();
            keymap = Utils.getKeymap();
            keycodes = Utils.getKeycodes();
            keymotionmap = Utils.getKeymotionmap();
            foreach (var k in keymap)
            {
                Keys.Add(new KeyViewModel()
                {
                    Left = k.left * 10,
                    Top = k.top * 10,
                    Width = k.width * 10,
                    Height = k.height * 10,
                    Pressed = false,
                    Name = Utils.getKeycodeByVkCode(k.vk_code).name,
                });
            }
            Keys.Add(new KeyViewModel() { 
                Left = 17*10,
                Top = 26*10,
                Width = 10*10,
                Height = 4*10,
                Pressed = false,
                Name = "LMOUSE"
            });
            Keys.Add(new KeyViewModel()
            {
                Left = 27 * 10,
                Top = 26 * 10,
                Width = 10 * 10,
                Height = 4 * 10,
                Pressed = false,
                Name = "RMOUSE"
            });
            Listener.KeyDown += new RawKeyEventHandler(KeyDown);
            Listener.KeyUp += new RawKeyEventHandler(KeyUp);
            MListener.MouseAction += new EventHandler<RawMouseEventArgs>(MouseAction1);
            KeyMotions = new ObservableCollection<KeyMotionViewModel>();
            foreach (var item in keymotionmap)
            {
                KeyMotions.Add(new KeyMotionViewModel()
                {
                    ID = item.id,
                    X = item.x,
                    Y = item.y,
                    Z = item.z,
                    VkCode = item.vk_code,
                    KeyName = Utils.getKeycodeByVkCode(item.vk_code).name,
                }
                    );
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
            OutActionCommand = new DelegateCommand<object>(new Action<object>(this.OutActionCommandExecute));
            FuncCommand = new DelegateCommand(new Action(this.FuncCommandExecute));
            
            GetSelfWeightValueCommand = new DelegateCommand(new Action(this.GetSelfWeightValueCommandExecute));
            OperateButtonCommand = new DelegateCommand<object>(new Action<object>(this.OperateButtonCommandCommandExecute));
            ResetCommand = new DelegateCommand(new Action(this.ResetCommandExecute));
            Axis_SaveCommand = new DelegateCommand(new Action(this.Axis_SaveCommandExecute));
            KeyMotionSaveCommand = new DelegateCommand(new Action(this.KeyMotionSaveCommandExecute));
        }

        private void KeyMotionSaveCommandExecute()
        {
            if (SelectedKeyMotion != null)
            {
                bool r = Utils.updateMotionData(SelectedKeyMotion.ID,SelectedKeyMotion.X, SelectedKeyMotion.Y,SelectedKeyMotion.Z,SelectedKeyMotion.VkCode);
                if (r)
                {
                    MessageBox.Show($"{SelectedKeyMotion.KeyName}坐标数据更新完成 {SelectedKeyMotion.X},{SelectedKeyMotion.Y}", "消息", MessageBoxButtons.OK);
                }
            }
        }

        private void Axis_SaveCommandExecute()
        {
            for (int i = 0; i < PrefilePos.Count; i++)
            {
                Inifile.INIWriteValue(iniParameterPath, "Position", "X" + i.ToString(), PrefilePos[i].X.ToString());
                Inifile.INIWriteValue(iniParameterPath, "Position", "Y" + i.ToString(), PrefilePos[i].Y.ToString());
                Inifile.INIWriteValue(iniParameterPath, "Position", "Z" + i.ToString(), PrefilePos[i].Z.ToString());
            }
            AddMessage("点坐标保存完成");
        }

        private void MouseAction1(object sender, RawMouseEventArgs e)
        {
            switch (e.Message)
            {
                case MouseEvent.WM_LBUTTONUP:
                    var mousekey = Keys.FirstOrDefault(key => key.Name == "LMOUSE");
                    mousekey.Pressed = true;
                    mousekey.Pressing = false;
                    activekeycode = keycodes.FirstOrDefault(t=> t.name == "LMOUSE").vk_code;
                    break;
                case MouseEvent.WM_LBUTTONDOWN:
                    mousekey = Keys.FirstOrDefault(key => key.Name == "LMOUSE");
                    mousekey.Pressed = false;
                    mousekey.Pressing = true;
                    activekeycode = keycodes.FirstOrDefault(t => t.name == "LMOUSE").vk_code;
                    break;
                case MouseEvent.WM_RBUTTONUP:
                    mousekey = Keys.FirstOrDefault(key => key.Name == "RMOUSE");
                    mousekey.Pressed = true;
                    mousekey.Pressing = false;
                    activekeycode = keycodes.FirstOrDefault(t => t.name == "RMOUSE").vk_code;
                    break;
                case MouseEvent.WM_RBUTTONDOWN:
                    mousekey = Keys.FirstOrDefault(key => key.Name == "RMOUSE");
                    mousekey.Pressed = false;
                    mousekey.Pressing = true;
                    activekeycode = keycodes.FirstOrDefault(t => t.name == "RMOUSE").vk_code;
                    break;
                default:
                    break;
            }
            MouseX = e.Point.x;
            MouseY = e.Point.y;
        }

        private void ResetCommandExecute()
        {
            foreach (var k in Keys)
            {
                k.Pressed = false;
                k.Fail = false;
            }
        }

        private void KeyUp(object sender, RawKeyEventArgs args)
        {
            int vk_code = args.VKCode;
            int sc_code = Utils.VkToSc(vk_code);

            for (int i = 0; i < keymap.Count; i++)
            {
                var k = keymap[i];
                if (k.vk_code == vk_code)
                {
                    Keys[i].Pressing = false;
                    Keys[i].Pressed = true;
                    break;
                }
            }
            activekeycode = args.VKCode;
        }

        private void KeyDown(object sender, RawKeyEventArgs args)
        {
            int vk_code = args.VKCode;

            VitualCode = vk_code;
            ScanCode = 0;
            KeyName = "";

            for (int i = 0; i < keymap.Count; i++)
            {
                var k = keymap[i];
                if (k.vk_code == vk_code)
                {
                    Keys[i].Pressing = true;
                    break;
                }
            }

            for (int i = 0; i < keycodes.Count; i++)
            {
                var keycode = keycodes[i];
                if (keycode.vk_code == vk_code)
                {
                    ScanCode = keycode.sc_code;
                    KeyName = keycode.name;
                }
            }
            activekeycode = args.VKCode;
        }

        private void OperateButtonCommandCommandExecute(object obj)
        {
            switch (obj.ToString())
            {
                case "0":
                    if (stepnum == 5)
                    {
                        start = true;
                    }                    
                    break;
                default:
                    break;
            }
        }

        private void GetSelfWeightValueCommandExecute()
        {
            double _value1 = 0;
            LTDMC.nmc_get_ad_input(_CardID, 1, 0, ref _value1);
            SelfWeightValue = _value1;
            Inifile.INIWriteValue(iniParameterPath, "System", "SelfWeightValue", SelfWeightValue.ToString());
        }

        private void FuncCommandExecute()
        {
            runflag = true;
            stepnum = 0;
            //Random rd = new Random();
            //SeriesCollection1[0].Values.Add((double)rd.Next(0,1000));
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
                Listener.Dispose();
                MListener.Dispose();
            }
            catch { }
        }

        private void Axis_GOCommandExecute(object obj)
        {
            if (MessageBox.Show($"是否运动到点{int.Parse(obj.ToString()) + 1}？", "确认", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
            if (MessageBox.Show($"是否示教点{int.Parse(obj.ToString()) + 1}？", "确认", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                PrefilePos[int.Parse(obj.ToString())].X = GPos.X;
                PrefilePos[int.Parse(obj.ToString())].Y = GPos.Y;
                PrefilePos[int.Parse(obj.ToString())].Z = GPos.Z;
                Inifile.INIWriteValue(iniParameterPath, "Position", "X" + obj.ToString(), PrefilePos[int.Parse(obj.ToString())].X.ToString());
                Inifile.INIWriteValue(iniParameterPath, "Position", "Y" + obj.ToString(), PrefilePos[int.Parse(obj.ToString())].Y.ToString());
                Inifile.INIWriteValue(iniParameterPath, "Position", "Z" + obj.ToString(), PrefilePos[int.Parse(obj.ToString())].Z.ToString());
            }
        }

        private void Axis_Home_CommandExecute(object obj)
        {
            ushort axis = ushort.Parse(obj.ToString());
            if (MessageBox.Show("是否回原点？", "确认", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
                    ParameterPageVisibility = "Collapsed";
                    break;
                case "1":
                    ParameterPageVisibility = "Visible";
                    HomePageVisibility = "Collapsed";
                    AxisPageVisibility = "Collapsed";
                    break;
                case "2":
                    HomePageVisibility = "Collapsed";
                    AxisPageVisibility = "Visible";
                    ParameterPageVisibility = "Collapsed";
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
            bool DMC5400ADi_0 = false;int pindex = 0;
            double weight1 = 0;
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
                    WeightValue = (_value - SelfWeightValue) / 16 * 1000;
                    #endregion
                    #region 运行函数
                    if (runflag && DMC5400ASVN[0] && DMC5400ASVN[1] && DMC5400ASVN[2] && homed[0] && homed[1] && homed[2])
                    {
                        switch (stepnum)
                        {
                            case 0:
                                //Res = LTDMC.dmc_set_profile(_CardID, 0, 200, 50000, 0.1, 0.1, 1000);
                                //Res = LTDMC.dmc_set_profile(_CardID, 1, 200, 50000, 0.1, 0.1, 1000);
                                //Res = LTDMC.dmc_set_profile(_CardID, 2, 200, 10000, 0.01, 0.01, 1000);

                                //Res = LTDMC.dmc_pmove(_CardID, 0, (int)(PrefilePos[0].X * 100), 1);
                                //Res = LTDMC.dmc_pmove(_CardID, 1, (int)(PrefilePos[0].Y * 100), 1);
                                //Res = LTDMC.dmc_pmove(_CardID, 2, (int)(PrefilePos[0].Z * 100), 1);
                                stepnum = 3;
                                break;
                            case 1:
                                if (LTDMC.dmc_check_done(_CardID, 0) == 1 && LTDMC.dmc_check_done(_CardID, 1) == 1 && LTDMC.dmc_check_done(_CardID, 2) == 1)
                                {
                                    stepnum = 2;
                                }
                                break;
                            case 2:
                                await Task.Delay(100);
                                stepnum = 3;
                                break;
                            case 3:
                                Res = LTDMC.dmc_set_profile(_CardID, 0, 200, 50000, 0.2, 0.2, 1000);
                                Res = LTDMC.dmc_set_profile(_CardID, 1, 200, 50000, 0.2, 0.2, 1000);
                                Res = LTDMC.dmc_set_profile(_CardID, 2, 200, 50000, 0.01, 0.01, 1000);

                                Res = LTDMC.dmc_pmove(_CardID, 0, (int)(PrefilePos[1].X * 100), 1);
                                Res = LTDMC.dmc_pmove(_CardID, 1, (int)(PrefilePos[1].Y * 100), 1);
                                Res = LTDMC.dmc_pmove(_CardID, 2, (int)(0), 1);

                                stepnum = 4;
                                break;
                            case 4:
                                if (LTDMC.dmc_check_done(_CardID, 0) == 1 && LTDMC.dmc_check_done(_CardID, 1) == 1 && LTDMC.dmc_check_done(_CardID, 2) == 1)
                                {
                                    stepnum = 5;
                                }
                                break;
                            case 5:
                                if (start)
                                {
                                    stepnum = 6;
                                    pindex = 0;
                                    ResetCommandExecute();
                                    start = false;
                                }
                                break;
                            case 6:
                                //Z轴降下来
                                Res = LTDMC.dmc_set_profile(_CardID, 2, 200, 10000, 0.1, 0.1, 1000);
                                Res = LTDMC.dmc_pmove(_CardID, 2, (int)(PrefilePos[1].Z * 100), 1);
                                stepnum = 7;
                                break;
                            case 7:
                                if (LTDMC.dmc_check_done(_CardID, 2) == 1)
                                {
                                    stepnum = 8;
                                }
                                break;
                            case 8:
                                if (pindex < KeyMotions.Count)
                                {
                                    stepnum = 12;
                                }
                                else
                                {
                                    stepnum = 0;
                                }

                                break;
                            case 12:
                                Res = LTDMC.dmc_set_profile(_CardID, 0, 200, 10000, 0.2, 0.2, 1000);
                                Res = LTDMC.dmc_set_profile(_CardID, 1, 200, 10000, 0.2, 0.2, 1000);
                                Res = LTDMC.dmc_set_profile(_CardID, 2, 200, 10000, 0.1, 0.1, 1000);

                                Res = LTDMC.dmc_pmove(_CardID, 0, (int)((PrefilePos[1].X + KeyMotions[pindex].X) * 100), 1);
                                Res = LTDMC.dmc_pmove(_CardID, 1, (int)((PrefilePos[1].Y + KeyMotions[pindex].Y) * 100), 1);
                                Res = LTDMC.dmc_pmove(_CardID, 2, (int)(PrefilePos[1].Z * 100), 1);
                                stepnum = 13;
                                break;
                            case 13:
                                if (LTDMC.dmc_check_done(_CardID, 0) == 1 && LTDMC.dmc_check_done(_CardID, 1) == 1 && LTDMC.dmc_check_done(_CardID, 2) == 1)
                                {
                                    stepnum = 14;
                                    collect = true;
                                }
                                break;
                            case 14:
                                Res = LTDMC.dmc_set_profile(_CardID, 2, 200, 1000, 0.1, 0.1, 1000);

                                Res = LTDMC.dmc_pmove(_CardID, 2, (int)((PrefilePos[1].Z - 2) * 100), 1);
                                Task.Run(() =>
                                {
                                    SeriesCollection1[0].Values.Clear();
                                    while (collect)
                                    {
                                        double _value1 = 0;
                                        LTDMC.nmc_get_ad_input(_CardID, 1, 0, ref _value1);
                                        weight1 = (double)((_value1 - SelfWeightValue) / 16 * 1000);
                                        SeriesCollection1[0].Values.Add(weight1);
                                        System.Threading.Thread.Sleep(1);
                                    }
                                });
                                activekeycode = -1;
                                stepnum = 15;
                                break;
                            case 15:
                                if (LTDMC.dmc_check_done(_CardID, 2) == 1)
                                {
                                    stepnum = 16;
                                }
                                else
                                {
                                    if (WeightValue > 80)
                                    {
                                        Res = LTDMC.dmc_stop(_CardID, 2, 0);
                                        var item = Keys.FirstOrDefault(t => t.Name == KeyMotions[pindex].KeyName);
                                        item.Fail = true;
                                        stepnum = 17;
                                    }
                                }
                                break;
                            case 16:
                                await Task.Delay(100);
                                if (weight1 < 20)
                                {
                                    var item = Keys.FirstOrDefault(t => t.Name == KeyMotions[pindex].KeyName);
                                    item.Fail = true;
                                    AddMessage(item.Name + " 下压压力值 < 20g");
                                }
                                if (activekeycode != KeyMotions[pindex].VkCode)
                                {
                                    var item = Keys.FirstOrDefault(t => t.Name == KeyMotions[pindex].KeyName);
                                    item.Fail = true;
                                    AddMessage(item.Name + " 下压信号不良");
                                }
                                stepnum = 17;
                                break;
                            case 17:
                                Res = LTDMC.dmc_set_profile(_CardID, 2, 200, 1000, 0.1, 0.1, 1000);

                                Res = LTDMC.dmc_pmove(_CardID, 2, (int)((PrefilePos[1].Z) * 100), 1);
                                activekeycode = -1;
                                stepnum = 18;
                                break;
                            case 18:
                                if (LTDMC.dmc_check_done(_CardID, 2) == 1)
                                {
                                    stepnum = 19;
                                }
                                break;
                            case 19:
                                await Task.Delay(100);
                                if (weight1 >= 20)
                                {
                                    var item = Keys.FirstOrDefault(t => t.Name == KeyMotions[pindex].KeyName);
                                    item.Fail = true;
                                    AddMessage(item.Name + " 抬起压力值 > 20g");
                                }
                                if (activekeycode != KeyMotions[pindex].VkCode)
                                {
                                    var item = Keys.FirstOrDefault(t => t.Name == KeyMotions[pindex].KeyName);
                                    item.Fail = true;
                                    AddMessage(item.Name + " 抬起信号不良");
                                }
                                collect = false;
                                pindex++;
                                stepnum = 8;
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
                            collect = false;
                            start = false;
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
