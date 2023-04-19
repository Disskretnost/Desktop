using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrimeaCloud
{
    public partial class FlowLayCust : UserControl
    {
        public FlowLayCust()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint, true);

            this.DoubleBuffered = true;
            {
                imgPnl1.Visible = false;
                imgPnl2.Visible = false;
                imgPnl3.Visible = false;
                imgPnl4.Visible = false;
                imgPnl5.Visible = false;
                imgPnl6.Visible = false;
                imgPnl7.Visible = false;
                imgPnl8.Visible = false;
                imgPnl9.Visible = false;
                imgPnl10.Visible = false;
                imgPnl11.Visible = false;
                imgPnl12.Visible = false;
                imgPnl13.Visible = false;
                imgPnl14.Visible = false;
                imgPnl15.Visible = false;
                imgPnl16.Visible = false;
                imgPnl17.Visible = false;
                imgPnl18.Visible = false;
                imgPnl19.Visible = false;
                imgPnl20.Visible = false;
                imgPnl21.Visible = false;
                imgPnl22.Visible = false;
                imgPnl23.Visible = false;
                imgPnl24.Visible = false;
                imgPnl25.Visible = false;
                imgPnl26.Visible = false;
                imgPnl27.Visible = false;
                imgPnl28.Visible = false;
                imgPnl29.Visible = false;
                imgPnl30.Visible = false;
                imgPnl31.Visible = false;
                imgPnl32.Visible = false;
                imgPnl33.Visible = false;
                imgPnl34.Visible = false;
                imgPnl35.Visible = false;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_CLIPCHILDREN
                return cp;
            }
        }

        public void ScrollChanged(int VscrollBarV, int VscrollBarMin, int VscrollBarMax)
        {
            flowLayoutPanel1.VerticalScroll.Minimum = VscrollBarMin;
            flowLayoutPanel1.VerticalScroll.Maximum = VscrollBarMax;
            flowLayoutPanel1.VerticalScroll.Value = VscrollBarV;
        }

        public void RealizeImgPnls(string type, int num, int numberFromServ, string text, Bunifu.UI.WinForms.BunifuPanel BunifuPanel)//тип,id файла, id владельца, название
        {
            ((TESTControl.ImgPnl)flowLayoutPanel1.Controls[$"imgPnl{num}"]).fileType = type;
            ((TESTControl.ImgPnl)flowLayoutPanel1.Controls[$"imgPnl{num}"]).bunifuPanel = BunifuPanel;
            flowLayoutPanel1.Controls[$"imgPnl{num}"].Visible = true;
            flowLayoutPanel1.Controls[$"imgPnl{num}"].Text = text;
            ((TESTControl.ImgPnl)flowLayoutPanel1.Controls[$"imgPnl{num}"]).textWithInfo = text;
            ((TESTControl.ImgPnl)flowLayoutPanel1.Controls[$"imgPnl{num}"]).NumberFromServ = numberFromServ.ToString();
        }

        public void ClearIMG()
        {
            for (int i = 0; i < flowLayoutPanel1.Controls.Count-1; i++)
            {
                flowLayoutPanel1.Controls[$"imgPnl{i+1}"].Visible = false;
            }
        }
    }
}
