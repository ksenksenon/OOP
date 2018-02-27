using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Polymorphism
{
    public abstract class TrafficLights //абстрактный класс
    {
        public string status; //состояние светофора
        public string type; //тип
      
        public TrafficLights(string type, string status)
        {
            this.type = type;
            this.status = status;
        }
        public abstract void ChangeState();
        public abstract void color(string status);
        public abstract void Draw(Graphics gr, string status);
    }

    public class DoubleLight: TrafficLights //пешеходный светофор
    {
        private int height=180, width=140;  //размеры

        protected bool red, green; //сигнал

        Rectangle _rect;
        List<Rectangle> lights = new List<Rectangle>();

        public DoubleLight(string type, string status) : base(type, status) //конструктор
        {

        }

        public override void color(string status) //задать цвет по состоянию
        {
            if (status == "Движение запрещено") { red = true; green = false; }
            else { green = true; red = false; }
        }

        public virtual void setStatus(bool red, bool green) //задать текущее состояние
        {
            if (red) status = "Движение запрещено";
            else
            if (green) status = "Движение разрешено";
        }

        public string getStatus() //считать текущее состояние
        {
            return status;
        }

        public bool Red //задать и читать сигнал
        {
            get { return red; }
            set { red = value; }
        }

        public bool Green
        {
            get { return green; }
            set { green = value; }
        }

        public override void ChangeState() //переключить в следующее состояние
        {
            if (red == true)
            {
                red = false;
                green = true;
                status = "Движение разрешено";
            }
            else
            {
                red = true;
                green = false;
                status = "Движение запрещено";
            }
        }

       
        public override void Draw(Graphics gr, string status)
        {
            _rect = new Rectangle(40, 60, width, height);
            lights.Add(new Rectangle(_rect.X + 35, _rect.Y + 15, 70, 70));
            lights.Add(new Rectangle(lights[lights.Count - 1].X, lights[lights.Count - 1].Y + lights[lights.Count - 1].Height + 10, 70, 70));
            gr.FillRectangle(Brushes.DarkGray, _rect);
            gr.DrawRectangle(new Pen(Color.Black), _rect);
            switch (status)
            {
                case "Движение запрещено":
                    gr.FillEllipse(Brushes.Red, lights[0]);
                    gr.FillEllipse(Brushes.Black, lights[1]);
                    break;

                case "Движение разрешено":
                    gr.FillEllipse(Brushes.Black, lights[0]);
                    gr.FillEllipse(Brushes.Green, lights[1]);
                    break;
            }
        }
    }

    public class TripleLight : DoubleLight //автомобильный светофор
    {
        protected bool yellow; 
        private int width = 140, height = 250;
        Rectangle _rect;  
        List<Rectangle> lights = new List<Rectangle>();

        public TripleLight(string type, string status) : base(type, status)
        {
            
        }

        public override void color(string status)
        {
            if (status == "Движение запрещено") { red = true; yellow = false; green = false; }
            if (status == "Ожидание движения") { red = true; yellow = true; green = false;}
            if (status == "Движение разрешено") { red = false; yellow = false; green = true; }
            if (status == "Ожидание остановки") { red = false; yellow = true; green = false; }
        }

        public bool Yellow
        {
            get { return yellow; }
            set { yellow = value; }
        }

        public void setStatus(bool red, bool yellow, bool green) //задать текущее состояние
        {
            if (red && !yellow) status = "Движение запрещено";
            if (red && yellow) status = "Ожидание движения";
            if (green) status = "Движение разрешено";
            if (yellow && !red) status = "Ожидание остановки";
        }

        public override void ChangeState() //переключить в следующее состояние
        {
            if (red == true && yellow == false)
            {
                
                yellow = true;
                status = "Ожидание движения";
                return;
            }
            if (red == true && yellow == true)
            {
                red = false;
                yellow = false;
                green = true;
                status = "Движение разрешено";
                return;
            }
            if (green == true)
            {
                yellow = true;
                green = false;
                status = "Ожидание остановки";
                return;
            }
            if (yellow == true && red==false)
            {
                red = true;
                yellow = false;
                status = "Движение запрещено";
            }
        }
      
        public override void Draw(Graphics gr, string status)
        {
            _rect = new Rectangle(55, 60, width, height);
           
            lights.Add(new Rectangle(_rect.X + 35, _rect.Y + 10, 70, 70));
            lights.Add(new Rectangle(lights[lights.Count - 1].X,lights[lights.Count - 1].Y + lights[lights.Count - 1].Height + 10, 70,70));
            lights.Add(new Rectangle(lights[lights.Count - 1].X, lights[lights.Count - 1].Y + lights[lights.Count - 1].Height + 10, 70, 70));
            gr.FillRectangle(Brushes.DarkGray, _rect);
            gr.DrawRectangle(new Pen(Color.Black), _rect);
            switch (status)
            {
                case "Движение запрещено":
                    gr.FillEllipse(Brushes.Red, lights[0]);
                    gr.FillEllipse(Brushes.Black, lights[1]);
                    gr.FillEllipse(Brushes.Black, lights[2]);
                    break;
                case "Ожидание движения":
                    gr.FillEllipse(Brushes.Red, lights[0]);
                    gr.FillEllipse(Brushes.Yellow, lights[1]);
                    gr.FillEllipse(Brushes.Black, lights[2]);
                    break;

                case "Движение разрешено":
                    gr.FillEllipse(Brushes.Black, lights[0]);
                    gr.FillEllipse(Brushes.Black, lights[1]);
                    gr.FillEllipse(Brushes.Green, lights[2]);
                    break;

                case "Ожидание остановки":
                    gr.FillEllipse(Brushes.Black, lights[0]);
                    gr.FillEllipse(Brushes.Yellow, lights[1]);
                    gr.FillEllipse(Brushes.Black, lights[2]);
                    break;
            }
        }
    }

    class ArrowLight : TripleLight //светофор со стрелкой
    {
        private bool arrow;
        private int height = 250; int width = 110;
        Rectangle _rect, _arrow;
        List<Rectangle> lights = new List<Rectangle>();

        public ArrowLight(string type, string status) : base(type, status)
        {
           
        }

        public override void color(string status)
        {
            if (status == "Движение запрещено") { red = true; yellow = false; green = false; arrow = false; }
            if (status == "Только поворот") { red = true; yellow = false; green = false; arrow = true; }
            if (status == "Движение и поворот разрешены") { red = false; yellow = false; green = true; arrow = true; }
            if (status == "Движение разрешено, поворот запрещен") { red = false; yellow = false; green = true; arrow = false;  }
            if (status == "Ожидание остановки") { red = false; yellow = true; green = false; arrow = false; }
        }
        public bool Arrow
        {
            get { return arrow; }
            set { arrow = value; }
        }

        public void setStatus(bool red, bool yellow, bool green, bool arrow) //задать текущее состояние
        {
           
        }

        public override void ChangeState() //переключить в следующее состояние
        {
            if (red == true && arrow == false)
            {
                arrow = true;               
                status = "Только поворот";
                return;
            }
            if (red == true && arrow == true)
            {
                red = false;
                green = true;
                status = "Движение и поворот разрешены";
                return;
            }
            if (green == true && arrow==true)
            {
                arrow = false;
                status = "Движение разрешено, поворот запрещен";
                return;
            }
            if (green == true && arrow == false)
            {
                green = false;
                yellow = true;
                status = "Ожидание остановки";
                return;
            }
            if (yellow == true)
            {
                yellow = false;
                red = true;
                status = "Движение запрещено";
            }
        }
        public override void Draw(Graphics gr, string status)
        {
            _rect = new Rectangle(15, 60, width, height);
            _arrow = new Rectangle(125,225,110,85);
            lights.Add(new Rectangle(_rect.X + 20, _rect.Y + 10, 70, 70));
            lights.Add(new Rectangle(lights[lights.Count - 1].X, lights[lights.Count - 1].Y + lights[lights.Count - 1].Height+10, 70, 70));
            lights.Add(new Rectangle(lights[lights.Count - 1].X, lights[lights.Count - 1].Y + lights[lights.Count - 1].Height + 10, 70, 70));
            lights.Add(new Rectangle(lights[lights.Count - 1].X + 110, lights[lights.Count - 1].Y , 70, 70));
            gr.FillRectangle(Brushes.DarkGray, _rect);
            gr.DrawRectangle(new Pen(Color.Black), _rect);
            gr.FillRectangle(Brushes.DarkGray, _arrow);
            gr.DrawRectangle(new Pen(Color.Black), _arrow);
            switch (status)
            {
                case "Движение запрещено":
                    gr.FillEllipse(Brushes.Red, lights[0]);
                    gr.FillEllipse(Brushes.Black, lights[1]);
                    gr.FillEllipse(Brushes.Black, lights[2]);
                    gr.FillEllipse(Brushes.Black, lights[3]);
                    break;

                case "Только поворот":
                    gr.FillEllipse(Brushes.Red, lights[0]);
                    gr.FillEllipse(Brushes.Black, lights[1]);
                    gr.FillEllipse(Brushes.Black, lights[2]);
                    gr.FillEllipse(Brushes.LawnGreen, lights[3]);
                    break;
                case "Движение и поворот разрешены":
                    gr.FillEllipse(Brushes.Black, lights[0]);
                    gr.FillEllipse(Brushes.Black, lights[1]);
                    gr.FillEllipse(Brushes.Green, lights[2]);
                    gr.FillEllipse(Brushes.LawnGreen, lights[3]);
                    break;
                case "Движение разрешено, поворот запрещен":
                    gr.FillEllipse(Brushes.Black, lights[0]);
                    gr.FillEllipse(Brushes.Black, lights[1]);
                    gr.FillEllipse(Brushes.Green, lights[2]);
                    gr.FillEllipse(Brushes.Black, lights[3]);
                    break;
                case "Ожидание остановки":
                    gr.FillEllipse(Brushes.Black, lights[0]);
                    gr.FillEllipse(Brushes.Yellow, lights[1]);
                    gr.FillEllipse(Brushes.Black, lights[2]);
                    gr.FillEllipse(Brushes.Black, lights[3]);
                    break;

            }
        }

    }
}
