using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;
using System.Text;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
			
        }
		
		public static string GetFileDetails(string arg1,string arg2)
		{
		    FileDetails fs = new FileDetails();
			if(System.Text.RegularExpressions.Regex.IsMatch(arg1,"^[-v/v-V/V]"))
			{
			    return fs.Version(arg2);	
			}
			else if(System.Text.RegularExpressions.Regex.IsMatch(arg1,"^[-s/s-S/S]"))
			{
			    return fs.Size(arg2);
			}
			else
				return "";
		}
		
    }
}