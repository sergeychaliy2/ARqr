using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorf
{

    class ScriptableLoader : IDeviceLoader
    {
        class DeviceInfo : ScriptableLoader
        {
            private int year = 0;
            private int life = 0;
            private int serie = 0;

            public DeviceInfo(int _year, int _life, int _serie)
            {
                this.year = _year;
                this.life = _life;
                this.serie = _serie;
            }
            public String GetDevice(DeviceInfo device_1)
            {
                String str=" ";
                try
                {
                    if (device_1 != null)
                    {
                        str = ("year: " + device_1.year + "life:" + device_1.life + "serie:" + device_1.serie);
                    }
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return str;
            }
        }
    }
}

