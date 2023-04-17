using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CrimeaCloud
{
    public partial class LoadfFileForm : Form
    {
        private Timer timer;
        private int angle;

        public LoadfFileForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            timer.Start();
            StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false; //нельзя выбрать другую
            TopMost = true;
        }

        public void SetMessageText(string message)
        {
            bunifuLabel1.Text = message;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            angle += 5;
            if (angle >= 360) angle = 0;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // сохранение текущего состояния графического контекста
            GraphicsState state = e.Graphics.Save();

            // перемещение системы координат в центр элемента управления
            e.Graphics.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);

            // поворот на заданный угол
            e.Graphics.RotateTransform(angle);

            // отображение картинки
            e.Graphics.DrawImage(Properties.Resources.LoadFile, new Point(-Properties.Resources.LoadFile.Width / 2, -Properties.Resources.LoadFile.Height / 2));

            // восстановление сохраненного состояния графического контекста
            e.Graphics.Restore(state);
        }
    }
}
