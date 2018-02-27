using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Street
{
    public class Str
    {
        private string name;
        private int count_house;

        public Str() { }

        public Str(string name, int count_house)
        {
                this.name = name;
                this.count_house = count_house;           
        }

        public bool IsNameEmpty() 
        {
            return name == "" ? true : false;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Count
        {
            get { return count_house; }
            set { count_house = value; }
        }

        public static List<Str> list_street = new List<Str>();

        public void AddStreet()
        {
            list_street.Add(new Str(name,count_house));
        }

        public List<House> list_house = new List<House>();


        public bool CorrectHouse(int num_h) //проверка на корректность ввода номера дома
        {
            int k = 0;
            foreach (House obj in list_house)
            {
                if (obj.Num == num_h) k++;
            }
            return k > 0 ? false : true;
        }

        public bool CorrectStreet(string n_str)//проверка на корректность ввода названия улицы
        {
            int k = 0;
            foreach (Str obj in list_street)
            {
                if (obj.Name == n_str) k++;
            }
            return k > 0 ? false : true;
        }

        public void AddHouse(int num, int count_floor, int count_entrance, int flat_entrance, int flat_floor) //добавление дома
        {
            list_house.Add(new House(num, count_floor, count_entrance, flat_entrance, flat_floor));
        }

        string street_name;
        string house_number;
        string n_floor;
        string n_entr;
        string n_flat_en;
        string n_flat_floor;

        static string path = Application.StartupPath + @"\Streets.txt";
      
        public void Writing() //запись в файл
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < list_street.Count; i++)
            {
                street_name = list_street[i].Name;
                file.WriteLine("Название улицы: " + street_name);
                for (int j = 0; j < list_street[i].list_house.Count; j++)
                {
                    house_number = list_street[i].list_house[j].Num.ToString();
                    n_floor= list_street[i].list_house[j].Count_floor.ToString();
                    n_entr = list_street[i].list_house[j].Count_entrance.ToString();
                    n_flat_en = list_street[i].list_house[j].Flat_entrance.ToString();
                    n_flat_floor = list_street[i].list_house[j].Flat_floor.ToString();

                    file.WriteLine("Дом № " + house_number);
                    file.WriteLine("Количество этажей: " + n_floor);
                    file.WriteLine("Количество подъездов: " + n_entr);
                    file.WriteLine("Количество квартир в подъезде: " + n_flat_en);
                    file.WriteLine("Количество квартир на этаже: " + n_flat_floor);
                }
                file.WriteLine();
            }
            file.Close();
        }

        public bool CountOfHouse() //условие записи в файл
        {
            if (list_house.Count == count_house) return true;
            else return false;
        }

        public bool adding(int col) //проверка на превышение заданного количества домов
        {
            return (col < count_house) ? true : false;
        }

        public int Counter() //счетчик оставшегося количества домов
        {
            return count_house - list_house.Count-1;
        }

    }
}
