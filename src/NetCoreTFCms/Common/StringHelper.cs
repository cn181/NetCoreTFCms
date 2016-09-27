using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetCoreTFCms.Common
{
    public class Utils
    {
        /// <summary>
        /// 过滤标记
        /// </summary>
        /// <param name="ClearHTML">包括HTML，脚本，数据库关键字，特殊字符的源码 </param>
        /// <returns>已经去除标记后的文字</returns>
        public static string ClearHTML(string htmlString)
        {
            if (htmlString == null)
            {
                return "";
            }
            else
            {
                //删除脚本
                htmlString = Regex.Replace(htmlString, @"<script[^>]*?>.*?</script>", "", RegexOptions.IgnoreCase);
                //删除HTML
                htmlString = Regex.Replace(htmlString, @"<(.[^>]*)>", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, @"([\r\n])[\s]+", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, @"-->", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, @"<!--.*", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, @"&(quot|#34);", "\"", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, @"&(amp|#38);", "&", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, @"&(lt|#60);", "<", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, @"&(gt|#62);", ">", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, @"&(nbsp|#160);", " ", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, @"&(iexcl|#161);", "\xa1", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, @"&(cent|#162);", "\xa2", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, @"&(pound|#163);", "\xa3", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, @"&(copy|#169);", "\xa9", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, @"&#(\d+);", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, "xp_cmdshell", "", RegexOptions.IgnoreCase);

                //删除与数据库相关的词
                htmlString = Regex.Replace(htmlString, "select", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, "insert", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, "delete from", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, "count''", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, "drop table", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, "truncate", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, "asc", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, "mid", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, "char", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, "xp_cmdshell", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, "exec master", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, "net localgroup administrators", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, "and", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, "net user", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, "or", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, "net", "", RegexOptions.IgnoreCase);
                //htmlString = Regex.Replace(htmlString,"*", "", RegexOptions.IgnoreCase);
                //htmlString = Regex.Replace(htmlString,"-", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, "delete", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, "drop", "", RegexOptions.IgnoreCase);
                htmlString = Regex.Replace(htmlString, "script", "", RegexOptions.IgnoreCase);

                //特殊的字符
                htmlString = htmlString.Replace("<", "");
                htmlString = htmlString.Replace(">", "");
                htmlString = htmlString.Replace("*", "");
                htmlString = htmlString.Replace("-", "");
                htmlString = htmlString.Replace("?", "");
                htmlString = htmlString.Replace(",", "");
                htmlString = htmlString.Replace("/", "");
                htmlString = htmlString.Replace(";", "");
                htmlString = htmlString.Replace("*/", "");
                htmlString = htmlString.Replace("\r\n", "");
                htmlString = htmlString.Trim();

                return htmlString;
            }
        }

    }
}
