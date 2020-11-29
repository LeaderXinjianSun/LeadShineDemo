using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace LeadShineDemo.Model
{
    public class MouseListener : IDisposable
    {
        public MouseListener()
        {
            // Dispatcher thread handling the KeyDown/KeyUp events.
            this.dispatcher = Dispatcher.CurrentDispatcher;

            // We have to store the LowLevelKeyboardProc, so that it is not garbage collected runtime
            hookedLowLevelMouseProc = (InterceptMouses.LowLevelMouseProc)LowLevelMouseProc;

            // Set the hook
            hookId = InterceptMouses.SetHook(hookedLowLevelMouseProc);

            // Assign the asynchronous callback event
            //hookedKeyboardCallbackAsync = new KeyboardCallbackAsync(KeyboardListener_KeyboardCallbackAsync);
        }
        private Dispatcher dispatcher;
        ~MouseListener()
        {
            Dispose();
        }
        public void Dispose()
        {
            InterceptKeys.UnhookWindowsHookEx(hookId);
        }
        internal event EventHandler<RawMouseEventArgs> MouseAction = delegate { };
        /// <summary>
        /// Contains the hooked callback in runtime.
        /// </summary>
        private InterceptMouses.LowLevelMouseProc hookedLowLevelMouseProc;
        /// <summary>
        /// Hook ID
        /// </summary>
        private IntPtr hookId = IntPtr.Zero;
        /// <summary>
        /// Actual callback hook.
        /// 
        /// <remarks>Calls asynchronously the asyncCallback.</remarks>
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.NoInlining)]
        private IntPtr LowLevelMouseProc(int nCode, UIntPtr wParam, IntPtr lParam)
        {
            MSLLHOOKSTRUCT hookStruct;
            if (nCode < 0)
            {
                return InterceptKeys.CallNextHookEx(hookId, nCode, wParam, lParam);
            }

            hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));

            MouseAction(null, new RawMouseEventArgs { Message = (MouseEvent)wParam, Point = hookStruct.pt, MouseData = hookStruct.mouseData });

            return InterceptKeys.CallNextHookEx(hookId, nCode, wParam, lParam);
        }
    }
    internal class RawMouseEventArgs : EventArgs
    {
        internal MouseEvent Message { get; set; }
        internal Point Point { get; set; }
        internal uint MouseData { get; set; }
    }
    /// <summary>
    /// The point co-ordinate.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Point
    {
        public readonly int x;
        public readonly int y;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct MSLLHOOKSTRUCT
    {
        internal Point pt;
        internal readonly uint mouseData;
        internal readonly uint flags;
        internal readonly uint time;
        internal readonly IntPtr dwExtraInfo;
    }
    /// <summary>
    /// Key event
    /// </summary>
    public enum MouseEvent : int
    {
        WM_LBUTTONDOWN = 0x0201,
        WM_LBUTTONUP = 0x0202,
        WM_MOUSEMOVE = 0x0200,
        WM_MOUSEWHEEL = 0x020A,
        WM_RBUTTONDOWN = 0x0204,
        WM_RBUTTONUP = 0x0205,
        WM_WHEELBUTTONDOWN = 0x207,
        WM_WHEELBUTTONUP = 0x208,
        WM_XBUTTONDOWN = 0x020B,
        WM_XBUTTONUP = 0x020C
    }
    #region WINAPI Helper class
    /// <summary>
    /// Winapi Key interception helper class.
    /// </summary>
    internal static class InterceptMouses
    {
        public delegate IntPtr LowLevelMouseProc(int nCode, UIntPtr wParam, IntPtr lParam);
        public static int WH_MOUSE_LL = 14;




        public static IntPtr SetHook(LowLevelMouseProc proc)
        {
            var hook = SetWindowsHookEx(WH_MOUSE_LL, proc, GetModuleHandle("user32"), 0);
            if (hook == IntPtr.Zero)
            {
                throw new Win32Exception();
            }

            return hook;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SetWindowsHookEx(int idHook, LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, UIntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        
    }
    #endregion
}
