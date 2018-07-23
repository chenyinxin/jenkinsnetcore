using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace jenkinsnetcore.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }
        public string Env
        {
            get {
                string str = Environment.GetEnvironmentVariable("one");
                if (string.IsNullOrEmpty(str))
                    return "环境变量（one）未提供";
                else
                    return "环境变量（one）：" + Environment.GetEnvironmentVariable("one");
            }
        }
    }
}
