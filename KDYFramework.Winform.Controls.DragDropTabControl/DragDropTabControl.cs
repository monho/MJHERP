using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDYFramework.NativeFunction;

namespace KDYFramework.Winform.Controls.DragDropTabControl
{
    public class DragDropTabControl : TabControl
    {
        /// <summary>
        /// 사용자가 선택한 탭
        /// </summary>
        DragDropTabPage selectedTab;
        /// <summary>
        /// 사용자가 추가한 페이지들
        /// </summary>
        List<DragDropTabPage> pages;
        /// <summary>
        /// DragDropTab이 밖으로 드래그 되었는지 여부
        /// </summary>
        bool isDragDropTabOut = false;

        public DragDropTabControl()
        {
            this.pages = new List<DragDropTabPage>();
            this.SetDoubleBuffered(true);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            this.selectedTab = FindPage(e.Location) as DragDropTabPage;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (isDragDropTabOut)
            {
                this.Controls.Remove(this.selectedTab as Control);
                this.selectedTab.Controls.Clear();

                DragDropTabForm form = this.selectedTab.DragDropTabForm;
                form.StartPosition = FormStartPosition.Manual;

                Point mousePosition;
                NativeFunctions.GetCursorPos(out mousePosition);

                mousePosition.X -= 50;
                mousePosition.Y -= 15;
                form.Location = mousePosition;

                form.Controls.AddRange(this.selectedTab.DragDropControls.ToArray());
                form.IsTab = false;
                form.Show(this);

                this.selectedTab = null;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            //탭을 선택후 영역밖으로 나갔는지 여부를 검사한다.
            if (this.selectedTab != null && (e.Location.Y < 0 || e.Location.Y > this.ItemSize.Height))
            {
                isDragDropTabOut = true;
            }
            else
            {
                isDragDropTabOut = false;
            }
        }

        /// <summary>
        /// 해당 좌표의 TabPage를 검색합니다.
        /// </summary>
        /// <param name="pt"></param>
        /// <returns></returns>
        private TabPage FindPage(Point pt)
        {
            int index = FindPageIndex(pt);
            return index == -1 ? null : this.TabPages[index];
        }

        /// <summary>
        /// 해당 좌표의 Page의 Index를 검색합니다.
        /// </summary>
        /// <param name="pt"></param>
        /// <returns></returns>
        private int FindPageIndex(Point pt)
        {
            int index = -1;

            for (int i = 0; i < TabPages.Count; i++)
            {
                if (GetTabRect(i).Contains(pt))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        /// <summary>
        /// DragDropPage를 추가합니다.
        /// </summary>
        /// <param name="dragDropTabPage"></param>
        public void AddDragDropControls(DragDropTabPage dragDropTabPage)
        {
            this.pages.Add(dragDropTabPage);

            dragDropTabPage.DragDropTabForm.CompleteDragEventHandler += DragDropTabForm_CompleteDragEventHandler;
            dragDropTabPage.DragDropTabForm.FormClosing += DragDropTabForm_FormClosing;

            try
            {
                this.TabPages.Add(dragDropTabPage);
            }
            catch(NullReferenceException)//MDI윈도우를 삽입시 런타임중에 뭔지 모르는 예외 발생함..
            {
              
            }
        }

        /// <summary>
        /// DragDropForm이 드래그가 완료되면 발생합니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DragDropTabForm_CompleteDragEventHandler(object sender, EventArgs e)
        {
            DragDropTabForm form = sender as DragDropTabForm;

            if (form != null)
            {
                Point screenPoint;
                NativeFunctions.GetCursorPos(out screenPoint);
                Point point = this.PointToClient(screenPoint);
                if (this.ClientRectangle.Contains(point) && point.Y <= this.ItemSize.Height)
                {
                    DragDropTabPage page = pages.Find(a => a.DragDropTabForm == form);
                    page.Controls.AddRange(page.DragDropControls.ToArray());
                    form.Hide();
                    form.IsTab = true;

                    int index = this.FindPageIndex(point);
                    if (index != -1)
                    {
                        this.TabPages.Insert(index, page);
                    }
                    else
                    {
                        this.TabPages.Add(page);
                    }
                }
            }
        }

        /// <summary>
        /// DragDropPage가 닫힐때 발생합니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DragDropTabForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = this.pages.Find(a => a.DragDropTabForm == sender);
            this.pages.Remove(res);
        }
    }
}
