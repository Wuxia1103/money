using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 融合支付
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请进行支付");
            Console.WriteLine("1:支付宝支付；2：微信支付；3：信用卡支付；4：积分支付");
            string m = Console.ReadLine();
            int n = int.Parse(m);
            switch (n)
            {
                case 1:break;
                case 2:break;
                case 3:break;
                case 4:break;
            }
        }
    }
}
