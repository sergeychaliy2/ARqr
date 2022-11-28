using System;
using System.Collections.Generic;
using System.Text;
namespace Polimorf { 
    internal interface IDeviceLoader
    {
        public String GetDevice(DeviceInfo device_1);
    }

   public class ScriptableLoader : IDeviceLoader
    {
        public String GetDevice(DeviceInfo device_1)
        {
            String str = " ";
            try
            {
                if (device_1 != null)
                {
                    str =("year: " , device_1.getYear() , "life:" , device_1.getLife() , "serie:" , device_1.getSerie()).ToString();
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return str;
        }
    }
    public class DeviceInfo : ScriptableLoader
    {
        private int year = 0;
        private int life = 0;
        private int serie = 0;

        public int getYear()
        {
            return year;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public int getLife()
        {
            return life;
        }

        public void setLife(int life)
        {
            this.life = life;
        }

        public int getSerie()
        {
            return serie;
        }

        public void setSerie(int serie)
        {
            this.serie = serie;
        }
        DeviceInfo(int _year, int _life, int _serie)
        {
           this.year = _year;
           this.life = _life;
           this.serie = _serie;
        }
    }
}

