using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Street
{
    public class House
    {
        private int num;
        private int count_floor;
        private int count_entrance;
        private int flat_entrance;
        private int flat_floor;

        Rectangle _rect;

        public House()
        {
            num = 1;
            count_floor=1;
            count_entrance=1;
            flat_entrance=1;
            flat_floor=1;
        }

        public House(int num, int count_floor, int count_entrance, int flat_entrance, int flat_floor)
        {
            this.num = num;
            this.count_floor = count_floor;
            this.count_entrance = count_entrance;
            this.flat_entrance = flat_entrance;
            this.flat_floor = flat_floor;
        }

        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        public int Count_floor
        {
            get { return count_floor; }
            set { count_floor = value; }
        }

        public int Count_entrance
        {
            get { return count_entrance; }
            set { count_entrance = value; }
        }

        public int Flat_entrance
        {
            get { return flat_entrance; }
            set { flat_entrance = value; }
        }
        public int Flat_floor
        {
            get { return flat_floor; }
            set { flat_floor = value; }
        }

        public void draw(Graphics gr)
        {
            _rect = new Rectangle(0, 150-count_floor * 10, count_entrance*10, count_floor*10);
            gr.FillRectangle(Brushes.LightSeaGreen, _rect);
            gr.DrawRectangle(new Pen(Color.DarkGray), _rect);
        }

    }
}
