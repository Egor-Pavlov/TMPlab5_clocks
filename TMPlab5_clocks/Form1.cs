using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMPlab5_clocks
{
    public partial class Form1 : Form
    {
        Graphics graphics;

        int r = 100;//радиус циферблата
        int offset = 20;//смещение относительно верхнего левого угла

        public Form1()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }
        private void Draw(int angleHours, int angleMin, int angleSec)
        {
            graphics.Clear(Color.White);
            int x1 = Convert.ToInt32(0.6 * r * Math.Cos(angleHours * Math.PI / 180));//вычисляем координаты для каждой стрелки
            int y1 = Convert.ToInt32(0.6 * r * Math.Sin(angleHours * Math.PI / 180));

            int x2 = Convert.ToInt32(0.8 * r * Math.Cos(angleMin * Math.PI / 180));
            int y2 = Convert.ToInt32(0.8 * r * Math.Sin(angleMin * Math.PI / 180));

            int x3 = Convert.ToInt32(0.9 * r * Math.Cos(angleSec * Math.PI / 180));
            int y3 = Convert.ToInt32(0.9 * r * Math.Sin(angleSec * Math.PI / 180));

            Pen Circle = new Pen(Color.DarkGray, 5);
            graphics.DrawEllipse(Circle, offset, offset, 2 * r, 2 * r);//циферблат

            Pen HourPen = new Pen(Color.Black, 5);//создаем ручки разной толщины для рисования
            Pen MinPen = new Pen(Color.Black, 3);
            Pen SecPen = new Pen(Color.Black, 2);

            graphics.DrawLine(HourPen, offset + r, offset + r, x1 + offset * 6, y1 + offset * 6);//стрелка часы
            graphics.DrawLine(MinPen, offset + r, offset + r, x2 + offset * 6, y2 + offset * 6);//стрелка минуты
            graphics.DrawLine(SecPen, offset + r, offset + r, x3 + offset * 6, y3 + offset * 6);//стрелка секунды
            
            // Кружочек в центре
            graphics.DrawEllipse(new Pen(Color.DarkGray, 5), offset + r - (float)2.5, offset + r - (float)2.5, 5, 5);
        }


        private void ShowTime1_Click(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", (int)DigitHours.Value, (int)DigitMinutes.Value, (int)DigitSeconds.Value);
            DigitTime digitTime = new DigitTime((ushort)(DigitHours.Value), (ushort)(DigitMinutes.Value), (ushort)(DigitSeconds.Value));

            AnalogAdapter analogAdapter = new AnalogAdapter(digitTime);

            //-90 потому что иначе циферблат на боку
            int angleH = analogAdapter.Hour - 90;
            int angleM = analogAdapter.Minute - 90;
            int angleS = analogAdapter.Second - 90;

            Draw(angleH, angleM, angleS);
        }

        private void ShowTime2_Click(object sender, EventArgs e)
        {
            
            int angleH = Convert.ToInt32(AnalogHours.Value);
            int angleM = Convert.ToInt32(AnalogMinutes.Value);
            int angleS = Convert.ToInt32(AnalogSeconds.Value);

            Draw(angleH -90, angleM - 90, angleS - 90);//-90 потому что иначе циферблат на боку

            AnalogTime analogTime = new AnalogTime((ushort)angleH, (ushort)angleM, (ushort)angleS);
            DigitAdapter digitAdapter = new DigitAdapter(analogTime);
            label1.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", digitAdapter.Hour, digitAdapter.Minute, digitAdapter.Second);
        }

        private void timer1_Tick(object sender, EventArgs e)//тикает 1 раз, рисует циферблат и больше не тикает
        {
            graphics.Clear(Color.White);
            Pen Circle = new Pen(Color.DarkGray, 5);
            graphics.DrawEllipse(Circle, offset, offset, 2 * r, 2 * r);//циферблат
            // Кружочек в центре
            graphics.DrawEllipse(new Pen(Color.DarkGray, 5), offset + r - (float)2.5, offset + r - (float)2.5, 5, 5);
            timer1.Enabled = false;
        }
    }
}
