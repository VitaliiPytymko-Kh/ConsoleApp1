using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class Button
        {
            public delegate void ClickEventHendler(string mes );
            
            public event ClickEventHendler CLick;

            private string name;

            public Button(string name)
            {
                this.name = name;
            }


            public void onClick()
            {
                
                CLick?.Invoke(" Кнопка нажата ");
            }
        }

        public class Subscriber1
        {
            public static void CheckClick (string context)
            {
                Console.WriteLine("Subscriber1" + context);
            }
        }

        public class Subscriber2
        {
            public static void CheckClick(string context)
            {
                Console.WriteLine("Subscriber2 " + context);
            }
        }

        static void Main(string[] args)
        {
            Button but = new Button("TestModel" );

            but.CLick += Subscriber1.CheckClick;
            but.CLick += Subscriber2.CheckClick;

            but.onClick();

            

        }
    }
}
