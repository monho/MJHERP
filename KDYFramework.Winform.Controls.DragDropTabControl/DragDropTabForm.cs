using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDYFramework.NativeFunction;

namespace KDYFramework.Winform.Controls.DragDropTabControl
{
    public partial class DragDropTabForm : Form
    {
        const int WM_NCLBUTTONDOWN = 0xa1;
        const int WM_NCLBUTTONUP = 0xa0;
        const int HTCAPTION = 2;
        bool isCaptionClick = false;

        public event EventHandler CompleteDragEventHandler;
        public DragDropTabPage OwnerPage { get; internal set; }
        /// <summary>
        /// Tab 형태 여부를 가져오거나 설정합니다.
        /// </summary>
        public bool IsTab { get; set; }
        

        public DragDropTabForm()
        {
            InitializeComponent();
            this.IsTab = true;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCLBUTTONDOWN:
                    if ((int)m.WParam == HTCAPTION)
                    {
                        this.Cursor = Cursors.Hand;
                        isCaptionClick = true;
                    }
                    break;
                case WM_NCLBUTTONUP:
                    if ((int)m.WParam == HTCAPTION && isCaptionClick)
                    {
                        this.Cursor = Cursors.Default;
                        if(CompleteDragEventHandler!=null)
                            CompleteDragEventHandler(this, EventArgs.Empty);
                        isCaptionClick = false;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// 컨트롤을 제거합니다.
        /// </summary>
        /// <param name="ctl"></param>
        public void RemoveControl(Control ctl)
        {
            if (this.IsTab)
            {
                this.OwnerPage.Controls.Remove(ctl);
            }
            else
            {
                this.Controls.Remove(ctl);
            }
            this.OwnerPage.DragDropControls.Remove(ctl);
        }

        public void AddControl(Control ctl)
        {
            if (this.IsTab)
            {
                this.OwnerPage.Controls.Add(ctl);
            }
            else
            {
                this.Controls.Add(ctl);
            }
            this.OwnerPage.DragDropControls.Add(ctl);
        }

        public override string ToString()
        {
            return this.Text;
        }
    }
}
