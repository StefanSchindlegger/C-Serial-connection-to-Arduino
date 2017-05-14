using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace SerialConnectionToArduino
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string portName = "com6";
            int boudRate = 9600;
            bool connected = false;
            
            SerialPort sP = new SerialPort();
            sP.PortName = portName;
            sP.BaudRate = boudRate;
            sP.ReadTimeout = 500;
            sP.WriteTimeout = 500;
            try
            {   sP.Open();
                connected = true;
            }catch (Exception ex){
                Console.WriteLine("Could not connect!");
            }
          
           // sP.WriteLine("Hello");

            while (connected)
            {
                Console.WriteLine(System.DateTime.Now.ToString()+ ": "+ sP.ReadLine());
               
            }

        }
    }
}
