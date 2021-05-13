using System;
using System.Collections.Generic;
using System.Threading;
using  T=System.Threading.Tasks;

using System.Threading.Tasks;

namespace dwmo
{
     class Program
    {
       
        /*
        public string Name { get; set; }
        public int id { get; set; }
        public override string ToString()
        {
            return string.Format("Id:{0},name:{1}",id,Name);
        }

        */
       
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("hwllo");
            Console.ReadKey();
        }
        static async void Method()
        {
           await Task.Run(new Action(longtask));
            Console.WriteLine("New Thread");
        }
        static void longtask()
        {
            Thread.Sleep(20000);
        }
    }

}
