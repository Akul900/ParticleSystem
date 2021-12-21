using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleSystem
{

    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;


        GravityPoint point2; // добавил поле под вторую точку

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            {

                Direction = 0,
                Spreading = 10,
                SpeedMin = 1,
                SpeedMax = 10,
                LifeMax = 100,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };
            emitters.Add(this.emitter);

            point2 = new GravityPoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            };

            // привязываем поля к эмиттеру
              emitter.impactPoints.Add(point2);
        }  

        private void timer1_Tick(object sender, EventArgs e)
        {
 
            emitter.UpdateState(); // тут теперь обновляем эмиттер
            
            using (var g = Graphics.FromImage(picDisplay.Image))
            {

                g.Clear(Color.Black);

                emitter.Render(g); // а тут теперь рендерим через эмиттер
                int k = emitter.getParticlesCount();
                lblParticlesCount.Text = $"Кол-во частиц: {k}°";

            }
            picDisplay.Invalidate();

        }


        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            // в обработчике заносим положение мыши в переменные для хранения положения мыши
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;
            }

            // а тут передаем положение мыши, в положение гравитона
                point2.X = e.X;
                point2.Y = e.Y;
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value; // направлению эмиттера присваиваем значение ползунка 
            lblDirection.Text = $"{tbDirection.Value}°"; // добавил вывод значения
        }

        private void tbGraviton_Scroll(object sender, EventArgs e)
        {


            point2.Power = tbGraviton.Value;
        }

        private void tbParticlesPerTick_Scroll(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = tbParticlesPerTick.Value;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void tbSpreading_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tbSpreading.Value;
        }

        private void tbLife_Scroll(object sender, EventArgs e)
        {
            emitter.LifeMax = tbLife.Value;
        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            emitter.SpeedMax = tbSpeed.Value;
        }
    }
}
