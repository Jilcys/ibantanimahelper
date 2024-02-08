using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ibantanimahelper
{

    public class findIban
    {
        public string TrimIBAN(string iban)
        {
            string IBAN = iban;
            string trimmedIBAN = Regex.Replace(IBAN, @"\s+", "");
            string Code;
            if (trimmedIBAN[6].ToString() == "0")
            {
                Code = trimmedIBAN[7].ToString() + trimmedIBAN[8].ToString();
            }
            else
            {
                Code = trimmedIBAN[6].ToString() + trimmedIBAN[7].ToString() + trimmedIBAN[8].ToString();
            }
            return Code;
        }
        public string IBANBUL(string iban)
        {

            string Code = TrimIBAN(iban);            
            
            var Codes = new Repository();
            var bankname = Codes.getData();
            for (int i = 0; i < bankname.Count; i++)
            {
                if (Code == bankname.ElementAt(i).Key.ToString())
                {
                    return bankname.ElementAt(i).Value;
                }
            }
            return null;
        }
        public string SWIFT(string iban)
        {
            string Code = TrimIBAN(iban); 
            
            var Codes = new Repository();
            var swift = Codes.getSWIFT();
            for (int i = 0; i < swift.Count; i++)
            {
                if (Code == swift.ElementAt(i).Key.ToString())
                {
                    return swift.ElementAt(i).Value;
                }
            }
            return null;

        }
        public void test()
        {
            
            

        }       
    }    
}
