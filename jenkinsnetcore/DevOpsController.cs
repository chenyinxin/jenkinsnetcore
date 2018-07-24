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
    }
}
