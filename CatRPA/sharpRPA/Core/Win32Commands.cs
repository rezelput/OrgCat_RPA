using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace sharpRPA.Core.AutomationCommands
{
    public static class User32Functions
    {
        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        private static extern IntPtr FindWindowNative(string className, string windowName);
        public static IntPtr FindWindow(string windowName)
        {
            //находит точное название окна
            IntPtr hWnd = FindWindowNative(null, windowName);

            //если точное окно не было найдено, то проходит по совпадениям
            if (hWnd == IntPtr.Zero)
            {
                var potentialWindow = System.Diagnostics.Process.GetProcesses().Where(prc => prc.MainWindowTitle.Contains(windowName)).FirstOrDefault();
                if (potentialWindow != null)
                    hWnd = potentialWindow.MainWindowHandle;
            }

            //return hwnd
            return hWnd;
        }

        [DllImport("User32.dll", EntryPoint = "SetForegroundWindow")]
        private static extern IntPtr SetForegroundWindowNative(IntPtr hWnd);
        public static void SetForegroundWindow(IntPtr hWnd)
        {
            SetForegroundWindowNative(hWnd);
        }

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        public static void SetWindowState(IntPtr hWnd, WindowState windowState)
        {
            ShowWindow(hWnd, (int)windowState);
        }

        public enum WindowState
        {
            [Description("Сворачивает окно, даже если поток, которому принадлежит окно, не отвечает. Этот флаг следует использовать только при сворачивании окон из другого потока.")]
            SW_FORCEMINIMIZE = 11,
            [Description("Скрывает окно и активирует другое окно.")]
            SW_HIDE = 0,
            [Description("Развертывает указанное окно.")]
            SW_MAXIMIZE = 3,
            [Description("Сворачивает указанное окно и активирует следующее окно верхнего уровня в Z-порядке.")]
            SW_MINIMIZE = 6,
            [Description("Активирует и отображает окно. Если окно свернуто или развернуто, система восстанавливает его исходный размер и положение. Приложение должно указать этот флаг при восстановлении свернутого окна.")]
            SW_RESTORE = 9,
            [Description("Активирует окно и отображает его в текущем размере и положении.")]
            SW_SHOW = 5,
            [Description("Устанавливает состояние показа на основе значения SW_, указанного в структуре STARTUPINFO, переданной в функцию CreateProcess программой, запустившей приложение.")]
            SW_SHOWDEFAULT = 10,
            [Description("Активирует окно и отображает его как развернутое окно.")]
            SW_SHOWMAXIMIZED = 3,
            [Description("Активирует окно и отображает его как свернутое окно.")]
            SW_SHOWMINIMIZED = 2,
            [Description("Отображает окно в виде свернутого окна. Это значение аналогично SW_SHOWMINIMIZED, за исключением того, что окно не активируется.")]
            SW_SHOWMINNOACTIVE = 7,
            [Description("Отображает окно в его текущем размере и положении. Это значение похоже на SW_SHOW, за исключением того, что окно не активируется.")]
            SW_SHOWNA = 8,
            [Description("Отображает окно в его последнем размере и положении. Это значение аналогично SW_SHOWNORMAL, за исключением того, что окно не активируется.")]
            SW_SHOWNOACTIVATE = 4,
            [Description("Активирует и отображает окно. Если окно свернуто или развернуто, система восстанавливает его исходный размер и положение. Приложение должно указать этот флаг при первом отображении окна.")]
            SW_SHOWNORMAL = 1,
        }

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        private static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
        public static void SetWindowPosition(IntPtr hWnd, int newXPosition, int newYPosition)
        {
            const short SWP_NOSIZE = 1;
            const short SWP_NOZORDER = 0X4;
            const int SWP_SHOWWINDOW = 0x0040;

            SetWindowPos(hWnd, 0, newXPosition, newYPosition, 0, 0, SWP_NOZORDER | SWP_NOSIZE | SWP_SHOWWINDOW);
        }
        public static void SetWindowSize(IntPtr hWnd, int newXSize, int newYSize)
        {
            const short SWP_NOSIZE = 1;
            const short SWP_NOZORDER = 0X4;
            const int SWP_SHOWWINDOW = 0x0040;

            SetWindowPos(hWnd, 0, 0, 0, newXSize, newYSize, SWP_NOZORDER | SWP_NOSIZE | SWP_SHOWWINDOW);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        public static void CloseWindow(IntPtr hWnd)
        {
            const UInt32 WM_CLOSE = 0x0010;
            SendMessage(hWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
        }

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);
        public static void SetCursorPosition(int newXPosition, int newYPosition)
        {
            SetCursorPos(newXPosition, newYPosition);
        }

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        public static void SendMouseClick(string clickType, int xMousePosition, int yMousePosition)
        {
            switch (clickType)
            {
                case "Left Click":
                    mouse_event((int)MouseEvents.MOUSEEVENTF_LEFTDOWN, xMousePosition, yMousePosition, 0, 0);
                    mouse_event((int)MouseEvents.MOUSEEVENTF_LEFTUP, xMousePosition, yMousePosition, 0, 0);
                    break;

                case "Right Click":
                    mouse_event((int)MouseEvents.MOUSEEVENTF_RIGHTDOWN, xMousePosition, yMousePosition, 0, 0);
                    mouse_event((int)MouseEvents.MOUSEEVENTF_RIGHTUP, xMousePosition, yMousePosition, 0, 0);
                    break;

                case "Middle Click":
                    mouse_event((int)MouseEvents.MOUSEEVENTF_MIDDLEDOWN, xMousePosition, yMousePosition, 0, 0);
                    mouse_event((int)MouseEvents.MOUSEEVENTF_MIDDLEUP, xMousePosition, yMousePosition, 0, 0);
                    break;

                case "Left Down":
                    mouse_event((int)MouseEvents.MOUSEEVENTF_LEFTDOWN, xMousePosition, yMousePosition, 0, 0);
                    break;

                case "Right Down":
                    mouse_event((int)MouseEvents.MOUSEEVENTF_RIGHTDOWN, xMousePosition, yMousePosition, 0, 0);
                    break;

                case "Middle Down":
                    mouse_event((int)MouseEvents.MOUSEEVENTF_MIDDLEDOWN, xMousePosition, yMousePosition, 0, 0);
                    break;

                case "Left Up":
                    mouse_event((int)MouseEvents.MOUSEEVENTF_LEFTUP, xMousePosition, yMousePosition, 0, 0);
                    break;

                case "Right Up":
                    mouse_event((int)MouseEvents.MOUSEEVENTF_RIGHTUP, xMousePosition, yMousePosition, 0, 0);
                    break;

                case "Middle Up":
                    mouse_event((int)MouseEvents.MOUSEEVENTF_MIDDLEUP, xMousePosition, yMousePosition, 0, 0);
                    break;

                default:
                    break;
            }
        }

        enum MouseEvents
        {
            MOUSEEVENTF_LEFTDOWN = 0x02,
            MOUSEEVENTF_LEFTUP = 0x04,
            MOUSEEVENTF_RIGHTDOWN = 0x08,
            MOUSEEVENTF_RIGHTUP = 0x10,
            MOUSEEVENTF_MIDDLEDOWN = 0x20,
            MOUSEEVENTF_MIDDLEUP = 0x40
        }

        [DllImport("user32.dll", EntryPoint = "GetWindowRect")]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);
        public static RECT GetWindowPosition(IntPtr hWnd)
        {
            RECT clientArea = new RECT();
            GetWindowRect(hWnd, out clientArea);
            return clientArea;
        }
        public struct RECT
        {
            public int left, top, right, bottom;
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetClipboardData(uint uFormat);
        [DllImport("user32.dll")]
        static extern bool IsClipboardFormatAvailable(uint format);
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool OpenClipboard(IntPtr hWndNewOwner);
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool CloseClipboard();
        [DllImport("kernel32.dll")]
        static extern IntPtr GlobalLock(IntPtr hMem);
        [DllImport("kernel32.dll")]
        static extern bool GlobalUnlock(IntPtr hMem);

        const uint CF_UNICODETEXT = 13;

        public static string GetClipboardText()
        {
            if (!IsClipboardFormatAvailable(CF_UNICODETEXT))
                return null;
            if (!OpenClipboard(IntPtr.Zero))
                return null;

            string data = null;
            var hGlobal = GetClipboardData(CF_UNICODETEXT);
            if (hGlobal != IntPtr.Zero)
            {
                var lpwcstr = GlobalLock(hGlobal);
                if (lpwcstr != IntPtr.Zero)
                {
                    data = Marshal.PtrToStringUni(lpwcstr);
                    GlobalUnlock(lpwcstr);
                }
            }
            CloseClipboard();

            return data;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetDesktopWindow();

        public static Bitmap CaptureWindow(string windowName)
        {
            IntPtr hWnd;
            if (windowName == "Desktop")
            {
                hWnd = GetDesktopWindow();
            }
            else
            {
                hWnd = FindWindow(windowName);
                SetWindowState(hWnd, WindowState.SW_RESTORE);
                SetForegroundWindow(hWnd);
            }

            var rect = new RECT();

            //sleep to allow repaint
            System.Threading.Thread.Sleep(500);

            GetWindowRect(hWnd, out rect);
            var bounds = new Rectangle(rect.left, rect.top, rect.right - rect.left, rect.bottom - rect.top);
            var screenshot = new Bitmap(bounds.Width, bounds.Height);

            using (var graphics = Graphics.FromImage(screenshot))
            {
                graphics.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
            }

            return screenshot;
        }
    }
}