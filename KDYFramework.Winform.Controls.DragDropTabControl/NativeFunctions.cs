using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace KDYFramework.NativeFunction
{
    /// <summary>
    /// WinAPI Mouse 관련 함수
    /// </summary>
    internal static class NativeFunctions
    {
        /// <summary>
        /// 마우스 동작을 나타내는 Flag Enum
        /// </summary>
        public enum MouseEventFlag
        {
            /// <summary>
            /// Mouse Move
            /// </summary>
            MOUSEEVENTF_MOVE = 0x0001, 

            /// <summary>
            /// Mouse Left Down
            /// </summary>
            MOUSEEVENTF_LEFTDOWN = 0x0002, 

            /// <summary>
            /// Mouse Left Up
            /// </summary>
            MOUSEEVENTF_LEFTUP = 0x0004, 

            /// <summary>
            /// Mouse Right Down
            /// </summary>
            MOUSEEVENTF_RIGHTDOWN = 0x0008, 

            /// <summary>
            /// Mouse Right Up
            /// </summary>
            MOUSEEVENTF_RIGHTUP = 0x0010, 

            /// <summary>
            /// Mouse Middle Down
            /// </summary>
            MOUSEEVENTF_MIDDLEDOWN = 0x0020, 

            /// <summary>
            /// Mouse Middle Up
            /// </summary>
            MOUSEEVENTF_MIDDLEUP = 0x0040, 

            /// <summary>
            /// Mouse Wheel
            /// </summary>
            MOUSEEVENTF_WHEEL = 0x0800, 

            /// <summary>
            /// Mouse Absolute
            /// </summary>
            MOUSEEVENTF_ABSOLUTE = 0x8000, 
        };
        
        /// <summary>
        /// 마우스 이벤트
        /// </summary>
        /// <param name="dwFlags">동작 지정 Flag</param>
        /// <param name="dx">x좌표</param>
        /// <param name="dy">y좌표</param>
        /// <param name="dwData">휠 정보</param>
        /// <param name="dwExtraInfo">추가 정보</param>
        [DllImport("user32.dll", EntryPoint = "mouse_event")]
        public static extern void Mouse_event(MouseEventFlag dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        

        /// <summary>
        /// 커서 위치 셋팅
        /// </summary>
        /// <param name="x">x좌표</param>
        /// <param name="y">y좌표</param>
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        public static extern void SetCursorPos(int x, int y);



        /// <summary>
        /// Retrieves the cursor's position, in screen coordinates.
        /// </summary>
        /// <see>See MSDN documentation for further information.</see>
        [DllImport("user32.dll",EntryPoint = "GetCursorPos")]
        public static extern bool GetCursorPos(out Point point);
    }
}
