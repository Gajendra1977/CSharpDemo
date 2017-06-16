using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestDemo
{
    public class BusinessLogic
    {
        public string RoundUpDate(string strDate)
        {
            string newDate = "";
            try
            {
                DateTime recordedTime = new DateTime();
                recordedTime = DateTime.ParseExact(strDate, "yyyy-MM-dd HH:mm", null);                
                int mins = Convert.ToDateTime(strDate).Minute;
                int bracketMins = 0;
                bracketMins = ((mins / 15) + ((mins % 15) / 8)) * 15;
                newDate = DateTime.ParseExact(recordedTime.ToString("yyyy-MM-dd HH"), "yyyy-MM-dd HH", null).AddMinutes(bracketMins).ToString("yyy-MM-dd HH:mm");
            }
           catch(Exception ex)
            {
                // Log exception in DB/error logs
            }
            
            return newDate;
        }
    }
}