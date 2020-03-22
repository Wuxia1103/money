using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 融合支付
{
    class Jifen:Zhifu 
    {
        public void jifen()
        {
            Console.WriteLine("请输入积分号码");
            string y = Console.ReadLine();
            int Y = int.Parse(y);
            Console.WriteLine("请输入花费的钱");
            string x = Console.ReadLine();
            int X = int.Parse(x);
            int m,temp;
            m = 0;
            temp = X;
            X = m;
            m = temp;
            Console.WriteLine("现在积分为：{0}",m);
            Console.WriteLine("支付结束");
        }
        public override string Zhifujianmian
        {
            get
            {
                return "支付成功";
            }
        }
    }
}
