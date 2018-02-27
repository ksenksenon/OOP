using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Polymorphism
{
    public class DoubleLight
    {
        protected int height, width; //размеры
        protected string status; //текущее состояние
        protected bool red, green; //сигнал
        Rectangle _rect;
        Point _location = new Point(0, 0);
        List<Rectangle> lights = new List<Rectangle>();

        public DoubleLight()
        {
            height = 200;
            width = 100;
            red = true;
            green = false;
        }

        public DoubleLight(int height, int width, bool red, bool green) //конструктор
        {
            this.height = height;
            this.width = width;
            this.red = red;
            this.green = green;
            //_rect = new Rectangle(0, 0, 90, 150);
            //lights.Add(new Rectangle(_rect.X + 10, _rect.Y + 10, 70, 70));
            //lights.Add(new Rectangle(lights[lights.Count - 1].X, lights[lights.Count - 1].Y + lights[lights.Count - 1].Height + 10, 70, 70));
            //lights.Add(new Rectangle(lights[lights.Count - 1].X, lights[lights.Count - 1].Y + lights[lights.Count - 1].Height + 10, 70, 70));
        }

        public virtual void setStatus(bool red, bool green) //задать текущее состояние
        {
            if (red) status = "stop";
            if (green) status = "go";
        }

        public string getStatus() //считать текущее состояние
        {
            return status;
        }

        public void setLight(bool red, bool green) //задать сигнал
        {
            if (red) this.red = true;
            else
            if (green) this.green = true;
        }

        public bool Red
        {
            get { return red; }
            set { red = value; }
        }

        public bool Green
        {
            get { return green; }
            set { green = value; }
        }

        public virtual void ChangeState() //переключить в следующее состояние
        {
            if (red == true)
            {
                red = false;
                green = true;
                status = "go";
            }
            else
            {
                red = true;
                green = false;
                status = "stop";
            }
        }

        public virtual bool Correct()
        {
            if ((red && green) && (!red && !green)) return false;
            else return true;
        }

        public void setLocation(Point point)
        {
            _rect = new Rectangle(_rect.X + point.X, _rect.Y + point.Y, 280, 100);
            lights[0] = new Rectangle(_rect.X + 10, _rect.Y + 10, 90, 90);
            lights[1] = new Rectangle(lights[0].X, lights[0].Y + lights[0].Height + 10, 90, 90);
            //lights[2] = new Rectangle(lights[1].X, lights[1].Y + lights[1].Height + 10, 90, 90);
        }

        public void Draw(Graphics gr, int width, int height)
        {
            _rect = new Rectangle(0, 0, width, height);
            lights.Add(new Rectangle(_rect.X + width / 4, _rect.Y + width / 4, width / 2, width / 2));
            lights.Add(new Rectangle(lights[lights.Count - 1].X, height - (lights[lights.Count - 1].Y + lights[lights.Count - 1].Height + 10), width / 2, width / 2));
            //lights.Add(new Rectangle(lights[lights.Count - 1].X, lights[lights.Count - 1].Y + lights[lights.Count - 1].Height + 10, 70, 70));
            gr.FillRectangle(Brushes.DarkGray, _rect);
            gr.DrawRectangle(new Pen(Color.Black), _rect);
            switch (status)
            {
                case "stop":
                    gr.FillEllipse(Brushes.Red, lights[0]);
                    gr.FillEllipse(Brushes.Black, lights[1]);

                    //gr.FillEllipse(Brushes.Black, lights[2]);
                    //gr.DrawEllipse(new Pen(Color.Black), lights[2]);
                    break;

                case "go":
                    gr.FillEllipse(Brushes.Black, lights[0]);
                    gr.FillEllipse(Brushes.Green, lights[1]);

                    //gr.FillEllipse(Brushes.Green, lights[2]);
                    //gr.DrawEllipse(new Pen(Color.Green), lights[2]);
                    break;
            }
        }

    }

    public class TrippleLight : DoubleLight
    {
        protected bool yellow; //сигнал

        Rectangle _rect;
        Point _location = new Point(0, 0);
        List<Rectangle> lights = new List<Rectangle>();

        public TrippleLight() : base()
        {
            yellow = false;
        }

        public TrippleLight(bool yellow, int height, int width, bool red, bool green) : base(height, width, red, green)
        {
            this.yellow = yellow;
        }

        public bool Yellow
        {
            get { return yellow; }
            set { yellow = value; }
        }

        public void setStatus(bool red, bool yellow, bool green) //задать текущее состояние
        {
            base.setStatus(red, green);
            if (yellow) status = "wait";
        }

        public void setLight(bool red, bool yellow, bool green) //задать сигнал
        {
            base.setLight(red, green);
            if (yellow) this.yellow = true;

        }

        public override void ChangeState() //переключить в следующее состояние
        {
            base.ChangeState();
            if (yellow == true)
            {
                red = false;
                yellow = false;
                green = true;
                status = "go";
            }

        }
        public override bool Correct()
        {
            base.Correct();
            if ((red && yellow) && (yellow && green) && (red && yellow && green) && (!red && !yellow && !green)) return false;
            else return true;
        }
    }

    public class ArrowLight : TrippleLight
    {
        bool arrow;

        Rectangle _rect;
        Point _location = new Point(0, 0);
        List<Rectangle> lights = new List<Rectangle>();

        public ArrowLight() : base()
        {
            arrow = false;
        }

        public ArrowLight(bool arrow, bool yellow, int height, int width, bool red, bool green) : base(yellow, height, width, red, green)
        {
            this.arrow = arrow;
        }

        public bool Arrow
        {
            get { return arrow; }
            set { arrow = value; }
        }

        public void setStatus(bool red, bool yellow, bool green, bool arrow) //задать текущее состояние
        {
            base.setStatus(red, yellow, green);
            if (yellow) status = "wait";

        }

        public void setLight(bool red, bool yellow, bool green, bool arrow) //задать сигнал
        {
            base.setLight(red, yellow, green);
            if (arrow) this.arrow = true;
        }

        public override void ChangeState() //переключить в следующее состояние
        {
            base.ChangeState();
            if (arrow == true)
            { arrow = false; }
            else
            { arrow = true; }

        }


    }
}
