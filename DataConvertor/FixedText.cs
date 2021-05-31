using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Web_App.Convertors
{
    public class FixedText
    {
        public static string FixEmail(string email)
        {
            return email.Trim().ToLower();
        }
    }
}
