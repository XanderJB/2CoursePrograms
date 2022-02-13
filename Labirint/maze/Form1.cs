using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Game_Win()
        {
           DialogResult dr = MessageBox.Show("Вы победили! Сыграем еще раз?", "Message", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                this.start_game();
            else
                DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }
        private void start_game()
        {
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);
        }

    private void finish_game()
        {
            DialogResult dr = MessageBox.Show("Вы проиграли. Попробуем еще раз?", "Message", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                this.start_game();
            else
                DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            Game_Win();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

    }
}
