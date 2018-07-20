using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    public delegate void ShowLog(string message);
     
    class Program
    {
        static void Main(string[] args)
        {
            Log log = new Log();
            ShowLog showLog;

            
            showLog = log.warning;  //Gán phương thức vào Delegate
            showLog("TEST1"); //Thi hành Delegate


            showLog = log.info;
            showLog("TEST2");
         
            //Chuỗi Delegate
            showLog = null;
            showLog += log.warning;
            showLog += log.info;
            showLog += log.warning;
            showLog += (x) => { Console.WriteLine(string.Format("===>{0}<===", x)); };
            //Thi hành chuỗi
            showLog("TestLog");


            
            ShowLog showLog2 = (x) => { Console.WriteLine(string.Format("[{0}]", x)); };
            //Kết hợp Delegate
            ShowLog showlogall = showLog + showLog2;
            showlogall("All LOG");

        }
    }

    public class Log
    {
        public void info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("Info: {0}", s));
            Console.ResetColor();
        }

        public void warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("Waring: {0}", s));
            Console.ResetColor();
        }
    }


    
    
    
}
