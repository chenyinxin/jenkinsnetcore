using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace jenkinsnetcore
{
    public class DevOpsController: Controller
    {
        [Route("/GetString")]
        public string GetString()
        {
            return "NetCore结果：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        [Route("/GetJava")]
        public string GetJava()
        {
            WebClient wc = new WebClient();
            string result = wc.DownloadString("http://java/GetString");
            return "K8s调用（http://java/GetString）结果：" + result;
        }
        [Route("/GetJava8080")]
        public string GetJava8080()
        {
            WebClient wc = new WebClient();
            string result = wc.DownloadString("http://java:8080/GetString");
            return "K8s调用（http://java:8080/GetString）结果：" + result;
        }
        [Route("/GetIP")]
        public string GetIP()
        {
            var ips = Dns.GetHostAddresses("java");

            string ipstr = "";
            foreach (var ip in ips)
            {
                ipstr += ip.ToString();
            }
            return ipstr;
        }
    }
}
