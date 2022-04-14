using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KDYFramework.Winform.Controls.DragDropTabControl
{
    /// <summary>
    /// Drag&Drop이 가능한 TabPage 클래스
    /// </summary>
    public class DragDropTabPage : TabPage
    {
        /// <summary>
        /// 탭에서 나온 후 Form으로 보여질 개체를 가져옵니다.
        /// </summary>
        public DragDropTabForm DragDropTabForm { get; private set; }
        public List<Control> DragDropControls { get; private set; }

        public DragDropTabPage(DragDropTabForm form)
            :base(form.Text)
        {
            form.OwnerPage = this;
            this.DragDropTabForm = form;

            this.DragDropControls = new List<Control>();

            foreach (Control item in form.Controls)
            {
                this.DragDropControls.Add(item);
            }

            //같이 반복문을 돌며 추가할경우 form Controls에서 컨트롤이 제거되면서 문제 생기므로
            //아래와 같이 한번에 추가
            this.Controls.AddRange(this.DragDropControls.ToArray());
        }
    }
}
