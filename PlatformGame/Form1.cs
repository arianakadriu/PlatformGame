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

namespace PlatformGame
{
    public partial class Form1 : Form
    {
        Graphics grafika;

        enum Position
        {
            Left, Right, Up, Down, Stop, Jump1, Jump2, Jump3, Jump4, Jump5, Jump6, Jump7
        }
        private int _x;
        private int _y;
        private Position _objPosition;

        int collectedNumber = 0;

        //lojtari
        SolidBrush brush = new SolidBrush(Color.MediumVioletRed);
        //per platformat
        SolidBrush brusha = new SolidBrush(Color.ForestGreen);
       
        //per dere
        SolidBrush brusha2 = new SolidBrush(Color.PaleGoldenrod);
        
        //nese fiton
        SolidBrush brusha3 = new SolidBrush(Color.GreenYellow);
        
        //per ushqimet
        LinearGradientBrush lgbBrush2 = new LinearGradientBrush(new Point(20, 10), new Point(10, 40), Color.LightSeaGreen, Color.Peru);
        LinearGradientBrush lgbBrush3 = new LinearGradientBrush(new Point(20, 10), new Point(10, 40), Color.SandyBrown, Color.Beige);
        
        //per bllokat e medhenj
        LinearGradientBrush lgbBrush4 = new LinearGradientBrush(new Point(20, 10), new Point(10, 40), Color.Blue, Color.Orange);

        //lojtari
        Rectangle rec0;

        //dera
        Rectangle rec26= new Rectangle(480, 40, 50, 80);
        

        //format me gradient kalter-portokalli
        Rectangle rec8 = new Rectangle(490, 525, 30, 30);
        Rectangle rec16 = new Rectangle(70, 215, 30, 30);
        Rectangle rec22 = new Rectangle(100, 65, 30, 30);

        //format e vogla
        Rectangle rec1 = new Rectangle(95, 605, 20, 20);
        Rectangle rec2 = new Rectangle(135, 605, 20, 20);
        Rectangle rec3 = new Rectangle(175, 605, 20, 20);
        Rectangle rec4 = new Rectangle(215, 605, 20, 20);
        Rectangle rec5 = new Rectangle(350, 535, 20, 20);
        Rectangle rec6 = new Rectangle(390, 535, 20, 20);
        Rectangle rec7 = new Rectangle(445, 535, 20, 20);
        Rectangle rec9 = new Rectangle(220, 455, 20, 20);
        Rectangle rec10 = new Rectangle(260, 455, 20, 20);
        Rectangle rec11 = new Rectangle(90, 375, 20, 20);
        Rectangle rec12 = new Rectangle(140, 375, 20, 20);
        Rectangle rec13 = new Rectangle(230, 305, 20, 20);
        Rectangle rec14 = new Rectangle(290, 305, 20, 20);
        Rectangle rec15 = new Rectangle(350, 305, 20, 20);
        Rectangle rec17 = new Rectangle(120, 225, 20, 20);
        Rectangle rec18 = new Rectangle(180, 225, 20, 20);
        Rectangle rec19 = new Rectangle(230, 225, 20, 20);
        Rectangle rec20 = new Rectangle(330, 155, 20, 20);
        Rectangle rec21 = new Rectangle(400, 155, 20, 20);
        Rectangle rec23 = new Rectangle(150, 75, 20, 20);
        Rectangle rec24 = new Rectangle(200, 75, 20, 20);
        Rectangle rec25 = new Rectangle(250, 75, 20, 20);







        public Form1()
        {
            InitializeComponent();
            _x = 38;
            _y = 590;
            _objPosition = Position.Right;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            grafika = this.CreateGraphics();
           
            grafika.FillRectangle(brusha, new Rectangle(0, 630, 300, 30));
            grafika.FillRectangle(brusha, new Rectangle(300, 560, 250, 30));
            grafika.FillRectangle(brusha, new Rectangle(200, 480, 100, 30));
            grafika.FillRectangle(brusha, new Rectangle(80, 400, 120, 30));
            grafika.FillRectangle(brusha, new Rectangle(200, 330, 200, 30));
            grafika.FillRectangle(brusha, new Rectangle(50, 250, 250, 30));
            grafika.FillRectangle(brusha, new Rectangle(300, 180, 150, 30));
            grafika.FillRectangle(brusha, new Rectangle(450, 120, 100, 30));
            grafika.FillRectangle(brusha, new Rectangle(0, 100, 320, 30));

            grafika.FillRectangle(brusha2, rec26);

            rec0 = new Rectangle(_x, _y, 36, 36);
            grafika.FillRectangle(brush, rec0);
           

            grafika.FillRectangle(lgbBrush2, rec1);
            grafika.FillRectangle(lgbBrush2, rec2);
            grafika.FillRectangle(lgbBrush2, rec3);
            grafika.FillRectangle(lgbBrush2,rec4 );

            grafika.FillEllipse(lgbBrush3, rec5);
            grafika.FillEllipse(lgbBrush3, rec6);
            grafika.FillEllipse(lgbBrush3, rec7);
            
            grafika.FillEllipse(lgbBrush4, rec8);

            grafika.FillRectangle(lgbBrush2, rec9);
            grafika.FillEllipse(lgbBrush3, rec10);

            grafika.FillEllipse(lgbBrush2, rec11);
            grafika.FillRectangle(lgbBrush3, rec12);

            grafika.FillRectangle(lgbBrush2, rec13);
            grafika.FillEllipse(lgbBrush3, rec14);
            grafika.FillEllipse(lgbBrush2, rec15);

            grafika.FillRectangle(lgbBrush4, rec16);
            grafika.FillEllipse(lgbBrush3, rec17);
            grafika.FillEllipse(lgbBrush2, rec18);
            grafika.FillRectangle(lgbBrush3, rec19);

            grafika.FillRectangle(lgbBrush2, rec20);
            grafika.FillEllipse(lgbBrush3, rec21);

            grafika.FillEllipse(lgbBrush4, rec22);
            grafika.FillEllipse(lgbBrush2, rec23);
            grafika.FillRectangle(lgbBrush3, rec24);
            grafika.FillRectangle(lgbBrush2, rec25);

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

       

        public void kthehu()
        {
            //per format me gradient kalter-portokalli
            if(rec8.X<=300)
            {
                rec8.X = 525;
            }

            if (rec16.X >= 250)
            {
                rec16.X = 70;
            }

            if (rec22.X >= 300)
            {
                rec22.X = 100;
            }

            //per format e vogla
            if (rec1.Y<=600)
            {
                rec1.Y = 605;
            }
            if (rec2.Y <= 600)
            {
                rec2.Y = 605;
            }
            if (rec3.Y <= 600)
            {
                rec3.Y = 605;
            }
            if (rec4.Y <= 600)
            {
                rec4.Y = 605;
            }

            if (rec5.Y <= 530)
            {
                rec5.Y = 535;
            }
            if (rec6.Y <= 530)
            {
                rec6.Y = 535;
            }
            if (rec7.Y <= 530)
            {
                rec7.Y = 535;
            }

            if (rec9.Y <= 450)
            {
                rec9.Y = 455;
            }
            if (rec10.Y <= 450)
            {
                rec10.Y = 455;
            }

            if (rec11.Y <= 370)
            {
                rec11.Y = 375;
            }
            if (rec12.Y <= 370)
            {
                rec12.Y = 375;
            }

            if (rec13.Y <= 300)
            {
                rec13.Y = 305;
            }
            if (rec14.Y <= 300)
            {
                rec14.Y = 305;
            }
            if (rec15.Y <= 300)
            {
                rec15.Y = 305;
            }

            if (rec17.Y <= 220)
            {
                rec17.Y = 225;
            }
            if (rec18.Y <= 220)
            {
                rec18.Y = 225;
            }
            if (rec19.Y <= 220)
            {
                rec19.Y = 225;
            }

            if (rec20.Y <= 150)
            {
                rec20.Y = 155;
            }
            if (rec21.Y <= 150)
            {
                rec21.Y = 155;
            }

            if (rec23.Y <= 70)
            {
                rec23.Y = 75;
            }
            if (rec24.Y <= 70)
            {
                rec24.Y = 75;
            }
            if (rec25.Y <= 70)
            {
                rec25.Y = 75;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            kthehu();
            //per lojtarin me leviz
            if (_objPosition==Position.Right)
            {
                _x += 20;
            }
            else if (_objPosition == Position.Left)
            {
                _x -= 20;
            }
            else if (_objPosition == Position.Up)
            {
                _y -= 20;
            }
            else if (_objPosition == Position.Down)
            {
                _y += 20;
            }

            //kerce prej nje platforme ne tjetren
            else if(_objPosition==Position.Stop)
            {
                _x = 485;
                _y = 85;
            }
            else if (_objPosition == Position.Jump1)
            {
                _x = 300;
                _y = 520;
            }
            else if (_objPosition == Position.Jump2)
            {
                _x = 260;
                _y = 440;
            }
            else if (_objPosition==Position.Jump3)
            {
                _x =160;
                _y = 360;
            }
            else if (_objPosition == Position.Jump4)
            {
                _x = 200;
                _y = 290;
            }
            else if (_objPosition == Position.Jump5)
            {
                _x = 250;
                _y = 210;
            }
            else if (_objPosition == Position.Jump6)
            {
                _x = 320;
                _y = 140;
            }
            else if (_objPosition == Position.Jump7)
            {
                _x = 280;
                _y = 60;
            }


            //per format me gradient kalter-portokalli
            rec8.X -= 5;
            rec16.X += 5;
            rec22.X += 5;

            //per format e vogla
            rec1.Y -= 3;
            rec2.Y -= 3;
            rec3.Y -= 3;
            rec4.Y -= 3;

            rec5.Y -= 3;
            rec6.Y -= 3;
            rec7.Y -= 3;

            rec9.Y -= 3;
            rec10.Y -= 3;

            rec11.Y -= 3;
            rec12.Y -= 3;

            rec13.Y -= 3;
            rec14.Y -= 3;
            rec15.Y -= 3;

            rec17.Y -= 3;
            rec18.Y -= 3;
            rec19.Y -= 3;

            rec20.Y -= 3;
            rec21.Y -= 3;

            rec23.Y -= 3;
            rec24.Y -= 3;
            rec25.Y -= 3;

            //per mi marr ushqimet edhe nese preket me bllokat e medhenj
            if (rec0.IntersectsWith(rec1))
            {
                rec1 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
            else if (rec0.IntersectsWith(rec2))
            {
                rec2 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
            else if (rec0.IntersectsWith(rec3))
            {
                rec3 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
            else if (rec0.IntersectsWith(rec4))
            {
                rec4 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
            else if (rec0.IntersectsWith(rec5))
            {
                rec5 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
            else if (rec0.IntersectsWith(rec6))
            {
                rec6 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
            else if (rec0.IntersectsWith(rec7))
            {
                rec7 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
           /* else if (rec0.IntersectsWith(rec8))
            {
                rec0= new Rectangle(-100, -100, 1, 1);
                MessageBox.Show("You lost");
                Application.Exit();
            }*/
            else if (rec0.IntersectsWith(rec9))
            {
                rec9 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
            else if (rec0.IntersectsWith(rec10))
            {
                rec10 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
            else if (rec0.IntersectsWith(rec11))
            {
                rec11 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
            else if (rec0.IntersectsWith(rec12))
            {
                rec12 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
            else if (rec0.IntersectsWith(rec13))
            {
                rec13 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
            else if (rec0.IntersectsWith(rec14))
            {
                rec14 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
            else if (rec0.IntersectsWith(rec15))
            {
                rec15 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
           /* else if (rec0.IntersectsWith(rec16))
            {
                rec0 = new Rectangle(-100, -100, 1, 1);
                MessageBox.Show("You lost");
                Application.Exit();
            }*/
            else if (rec0.IntersectsWith(rec17))
            {
                rec17 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
            else if (rec0.IntersectsWith(rec18))
            {
                rec18 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
            else if (rec0.IntersectsWith(rec19))
            {
                rec19 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
            else if (rec0.IntersectsWith(rec20))
            {
                rec20 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
            else if (rec0.IntersectsWith(rec21))
            {
                rec21 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
           /* else if (rec0.IntersectsWith(rec22))
            {
                rec0 = new Rectangle(-100, -100, 1, 1);
                MessageBox.Show("You lost");
                Application.Exit();
            }*/
            else if (rec0.IntersectsWith(rec23))
            {
                rec23 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
            else if (rec0.IntersectsWith(rec24))
            {
                rec24 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
            else if (rec0.IntersectsWith(rec25))
            {
                rec25 = new Rectangle(-100, -100, 1, 1);
                collectedNumber++;
                lblScore.Text = collectedNumber.ToString();
            }
           else if (rec0.IntersectsWith(rec26) && (collectedNumber == 22))
            {
                //rec26 = new Rectangle(480, 40, 50, 80);
                //grafika.FillRectangle(brusha3, rec26);
                lblWin.Visible = true;

            }

            if (rec0.IntersectsWith(rec8)|| rec0.IntersectsWith(rec16) || rec0.IntersectsWith(rec22))
            {
                rec0 = new Rectangle(-100, -100, 1, 1);
                MessageBox.Show("You lost");
                Application.Exit();
            }

            Invalidate();
        }

       

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode==Keys.Left)
            {
                _objPosition = Position.Left;
            }
            else if (e.KeyCode == Keys.Right)
            {
                _objPosition = Position.Right;
            }
           else if (e.KeyCode == Keys.Up)
            {
                _objPosition = Position.Up;
            }
            else if (e.KeyCode == Keys.Down)
            {
                _objPosition = Position.Down;
            }
           else if(e.KeyCode.ToString()== "I")
            {
                _objPosition = Position.Stop;
            }
           else if (e.KeyCode.ToString()=="Q")
            {
                _objPosition = Position.Jump1;
            }
            else if (e.KeyCode.ToString() == "W")
            {
                _objPosition = Position.Jump2;
            }
            else if (e.KeyCode.ToString() == "E")
            {
                _objPosition = Position.Jump3;
            }
            else if (e.KeyCode.ToString() == "R")
            {
                _objPosition = Position.Jump4;
            }
            else if (e.KeyCode.ToString() == "T")
            {
                _objPosition = Position.Jump5;
            }
            else if (e.KeyCode.ToString() == "Y")
            {
                _objPosition = Position.Jump6;
            }
            else if (e.KeyCode.ToString() == "U")
            {
                _objPosition = Position.Jump7;
            }
           

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
