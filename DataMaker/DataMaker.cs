using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DataMaker
{
    public partial class dataMaker
    {
        public dataMaker() {
        }
        //随机数据生成器
        public static ArrayList making(Random ran, int n) {
            ArrayList arrayList = new ArrayList();//作用:创建顺序表
            for (int i = 0; i < n; ++i) {
                arrayList.Add(ran.Next(0, 200));
            }
            return arrayList;
        }
    }

        private void Delay(int Millisecond) //延迟系统时间，但系统又能同时能执行其它任务；
        {
            DateTime current = DateTime.Now;
            while (current.AddMilliseconds(Millisecond) > DateTime.Now)
            {
                Application.DoEvents();//转让控制权            
            }
            return;
        }

                    if ((startButton.Text).Equals("暂停") == true)
            {
                startButton.Text = "开始";
            }
}
