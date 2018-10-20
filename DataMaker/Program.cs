using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMaker
{
    class Program
    {
        //程序运行入口
        static void Main(string[] args)
        {
            dataMaker dataMaker = new dataMaker();//实例化dataMaker
            Random ran = new Random();//实例化一个随机数的对象
            Console.WriteLine("请输入要生成的数据量：");
            int num = Convert.ToInt16(Console.ReadLine().ToString());
            ArrayList al = dataMaker.making(ran, num);//调用函数生成一个顺序表
            Console.Write("创建的随机数顺序表如下：\n");
            for (int i = 0; i < num; i++)//打印一个顺序表
            {
                Console.Write("{0}\n", al[i]);
            }
            Console.ReadLine();
        }
    }
}
