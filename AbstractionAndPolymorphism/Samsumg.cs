using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndPolymorphism
{
    public class Samsumg : Mobile
    {
        public void getWIFIConnection()
        {
            Console.WriteLine("WIFI connected");
        }

        //This is one mwthod which shows camera functionality  
        public void cameraClick()
        {
            Console.WriteLine("Camera clicked");
        }

        //This is one overloaded method which shows camera functionality as well but with its camera's different mode(panaroma)  
        public void cameraClick(string CameraMode)
        {
            Console.WriteLine("Camera clicked in " + CameraMode + " Mode");
        }
    }
}
