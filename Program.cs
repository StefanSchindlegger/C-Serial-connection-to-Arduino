using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;           // <--- import System.IO.Ports for the serial communication


namespace SerialConnectionToArduino
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string portName = "com6";    // you have to change the port name to the port to which the arduino is connected
            int boudRate = 9600;         // use the same boud rate you defined on the arduino (  Serial.begin(....)   )
            bool connected = false;
            
            //settings for the serial connection
            SerialPort sP = new SerialPort();    
            sP.PortName = portName;
            sP.BaudRate = boudRate;
            sP.ReadTimeout = 500;   //Must be greater than the longest interval in which the arduino is sending
            sP.WriteTimeout = 500;
            
            try
            {   sP.Open();  //try to connect
                connected = true;
            }catch (Exception ex){
                Console.WriteLine("Could not connect!");
            }

            while (connected)
            {
                // prints out the date, the time and the message from the arduino
                Console.WriteLine(System.DateTime.Now.ToString()+ ": "+ sP.ReadLine()); 
            }

        }
    }
}
