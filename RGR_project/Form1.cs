using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR_project
{
    public partial class Form1 : Form
    {
        public Bitmap Field = Resource1.field;
        public Bitmap Player = Resource1.player;

        enum position
        {
            left, right, up, down
        }
        private position _personPosition;
        private float X = 350;
        private float Y = 350;



        public Form1()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);

        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics field = e.Graphics;
            Graphics player = e.Graphics;



            field.DrawImage(Field, 60, 60);
            player.DrawImage(Player, X, Y, 100, 100);


        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();

            if (_personPosition == position.right)
            {
                X += 5;
            }
            else if (_personPosition == position.left)
            {
                X -= 5;
            }
            else if (_personPosition == position.up)
            {
                Y += 5;
            }
            else if (_personPosition == position.down)
            {
                Y -= 5;
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S )
            {
                _personPosition = position.up;
            } else if (e.KeyCode == Keys.W)
            {
                _personPosition = position.down;
            } else if (e.KeyCode == Keys.D)
            {
                _personPosition = position.right;
            } else if (e.KeyCode == Keys.A)
            {
                _personPosition = position.left;
            }
                    
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.W)
            {
                _personPosition = position.up;
            }
        }
    }


    //public partial class Field : Form1
    //{
    //    public Bitmap Fields = Resource1.field;
    //    private void Field_Paint(object sender, PaintEventArgs e)
    //    {
    //        Graphics field = e.Graphics;

    //        field.DrawImage(Fields, 100, 100);


    //    }
    //}
}
