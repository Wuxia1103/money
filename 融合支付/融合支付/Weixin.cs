using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 融合支付
{
    class Weixin:Zhifu 
    {
        public void weixin()
        {
            Console.WriteLine("正在进行微信支付...");
            for (int i = 0; i < 100; i++) ;
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
