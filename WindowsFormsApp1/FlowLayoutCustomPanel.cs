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
    public partial class FlowLayoutCustomPanel : FlowLayoutPanel
    {
        public FlowLayoutCustomPanel() : base()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint, true);
            //this.BackColor = Color.Blue;
            this.DoubleBuffered = true;

        }
        protected override void OnScroll(ScrollEventArgs se)
        {
            this.Invalidate();
            //this.BackColor = Color.Red;
            base.OnScroll(se);
            Console.WriteLine("xad");
        }

        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            //Console.WriteLine("xad");

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
    }
}
