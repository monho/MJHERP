using System.Reflection;
using System.Windows.Forms;
using System;

namespace KDYFramework.Winform.Controls.DragDropTabControl
{
    public static class ControlHelper
    {
        /// <summary>
        /// 컨트롤의 DoubleBuffered 속성을 변경합니다.
        /// </summary>
        /// <param name="contorl"></param>
        /// <param name="setting"></param>
        public static void SetDoubleBuffered(this Control contorl, bool setting)
        {
            Type dgvType = contorl.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(contorl, setting, null);
        }
    } 

}
