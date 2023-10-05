using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal abstract class Device
    {
        protected string MODEL { get; set; }
        protected string TYPE { get; set; }
    }

    interface IDevice
    {
        void Sound();
        void Show();
        void Desc();
    }


    internal class Kettle : Device, IDevice
    {
        public Kettle () 
        {
            MODEL = null;
            TYPE = "Kettle";
        }
        public Kettle(string MODEL)
        {
            this.MODEL = MODEL;
            TYPE = "Kettle";
        }

        public virtual void Sound ()
        {
            Console.WriteLine("Pshshshsh");
        }
        public virtual void Show()
        {
            Console.WriteLine($"Type of device is {TYPE}, model is {MODEL ?? "No data"}");
        }
        public virtual void Desc()
        {
            Console.WriteLine("Device used to boil water");
        }
    }

    internal class MicroWaveOven : Device, IDevice
    {
        public MicroWaveOven()
        {
            MODEL = null;
            TYPE = "Microwave oven";
        }
        public MicroWaveOven(string MODEL)
        {
            this.MODEL = MODEL;
            TYPE = "Microwave oven";
        }

        public virtual void Sound()
        {
            Console.WriteLine("Pi pi pi");
        }
        public virtual void Show()
        {
            Console.WriteLine($"Type of device is {TYPE}, model is {MODEL ?? "No data"}");
        }
        public virtual void Desc()
        {
            Console.WriteLine("Device used to heat and cook the food");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IDevice MyDevice = new MicroWaveOven();
            Console.WriteLine("Micro wave oven");
            MyDevice.Show();
            MyDevice.Sound();
            MyDevice.Desc();
            Console.WriteLine();

            MyDevice = new Kettle("Tefal P1000");
            MyDevice.Show();
            MyDevice.Sound();
            MyDevice.Desc();
        }
    }
}
