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
            List<Zhifu> zhifus = new List<Zhifu>();
            Zhifubao zhifubao = new Zhifubao();
            zhifus.Add(zhifubao);
            Weixin weixin = new Weixin();
            zhifus.Add(weixin);
            Xinyongka xinyongka = new Xinyongka();
            zhifus.Add(xinyongka);
            Jifen jifen = new Jifen();
            zhifus.Add(jifen);

            switch (n)
            {
                
                case 1:zhifubao.zhifubao();   break;
                case 2:weixin.weixin();  break;
                case 3:xinyongka.xingyongka(); break;
                case 4:jifen.jifen(); break;
            }
           
             Console.WriteLine(zhifubao.Zhifujianmian.ToString());
            
        }
    }
}
