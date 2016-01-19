using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VIRETAILDAL;
using VIRETAILDAL.Masters;
using VIRETAILDAL.Transfers;
using VIRETAILENTITIES;

namespace Store.COMMON
{
    class Functions
    {
        public static string BackUpFileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\XtraGrid_PurchaseToXML.xml";
        public static bool IsAlpha(String strToCheck)
        {
            Regex objAlphaPattern = new Regex("[^a-zA-Z]");
            return objAlphaPattern.IsMatch(strToCheck);
        }
        public static bool IsAlphaNumeric(String strToCheck)
        {
            var objAlphaNumericPattern = new Regex("[^a-zA-Z0-9]");
            return objAlphaNumericPattern.IsMatch(strToCheck);
        }
        public static List<Form> AddOpenedForms()
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            return Application.OpenForms.Cast<Form>().Where(form => form.GetType().Assembly == currentAssembly).ToList();
            //foreach (Form form in OwnedForms) {
            //if (form.Name == "Whatever") {
            //    form.Activate();
            //    return;
        }
        public static int GetAutoSeed(DataTable dt)
        {
            int auto = 0;
            var dc = GetAutoIdColumnName(dt);
            foreach (DataRow d in dt.Rows)
            {
                var v = Int32.Parse(d[dc[0]].ToString());
                if (v < 0)
                {
                    auto = v;
                }
            }
            return auto == 0 ? -1 : --auto;
        }
        public static DataColumn[] GetAutoIdColumnName(DataTable dt)
        {
            var ret = dt.PrimaryKey;
            return ret;
        }
        public static void CreateBackUp(DataTable dt)
        {
            try
            {
                //dt.AcceptChanges();
                dt.WriteXml(BackUpFileName);
            }
            catch(Exception)
            {}
        }
        public static void DeleteBackUp()
        {
            File.Delete(BackUpFileName);
        }
        public static string GetTableNameFromXmlFile()
        {
            string retval = null;
            try
            {
                //xml.DocumentElement.ChildNodes[0].Name
                var ds = new DataSet();
                ds.ReadXml(BackUpFileName);
                retval = ds.Tables[0].TableName;
            }
            catch(Exception)
            {
                 DeleteBackUp();
                retval = null;
            }

            //var xmld = new XmlDocument();
            //xmld.Load(BackUpFileName);
            //XmlNode oEventNode = xmld.ChildNodes[0];
            //var retval =  oEventNode.ToString();
            //  oEventNode = xmld.ChildNodes[1];
            //  retval = oEventNode.ToString(); 
           //var reader = new XmlTextReader(BackUpFileName);
            //while (reader.Read())
            //{
            //    switch (reader.NodeType)
            //    {
            //        case XmlNodeType.Element: // The node is an element.
            //            Console.Write("<" + reader.Name);
            //            Console.WriteLine(">");
            //            retval = reader.Name;
            //            break;
            //        case XmlNodeType.Text: //Display the text in each element.
            //            Console.WriteLine(reader.Value);
            //            break;
            //        case XmlNodeType.EndElement: //Display the end of the element.
            //            Console.Write("</" + reader.Name);
            //            Console.WriteLine(">");
            //            break;
            //    }
            //}
            return retval;
        }
        public static int CheckStockAvailable(int stockid)
        {
            var cls = new StockMaster();
            return cls.GetAvailableQty(stockid);
        }
       
        public static DateTime CreateFirstDayOfMonth(int yr, int mont)
        {
            return yr < 2000 ? new DateTime(2000 + yr, mont, 1) : new DateTime(yr, mont, 1);
        }
        public static bool CheckDate(string dt)
        {
            try
            {
                int first = dt.IndexOf("-", StringComparison.Ordinal);
                if(first< 0)
                {
                    if(ToDateTime(int.Parse(dt))!=null)
                  {
                      return true;
                  }
                    return false;
                }
                string[] split = dt.Split('-');
                if (dt.Length < 4)
                {
                    return false;
                }
                var d1 = CreateFirstDayOfMonth(Int32.Parse(split[1]), Int32.Parse(split[0]));
                var d2 = DateTime.Today;
                if (d1 <= d2)
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static DateTime? ToDateTime(int synonDate)
        {
            int day = synonDate % 100;
            int dateWithoutDay = synonDate / 100;
            int month = dateWithoutDay % 100;
            int dateWithoutDayAndMonth = dateWithoutDay / 100;
            int year = dateWithoutDayAndMonth % 100;
            int century = dateWithoutDayAndMonth / 100;

            if (0 == day || 0 == month)
                return null;
            return new DateTime((19 + century) * 100 + year, month, day);
        }
        public static  DsInventory CreateDataSetForXmlFile(string tranids)
        {
           return new ItemMoveDataManager().CreateDataSetForXmlFile(tranids);
        }
        public static string GetFormatedAutoNo(int sourceid)
        {
            var taa = new DataManager();
            return taa.GetFormatedAutoNo(5);
        }
        public static string GetBarCodeFromQuery(IEnumerable<DataRow> qry)
        {
            DataTable tb = qry.CopyToDataTable();
            return tb.Rows[0]["BARCODE"].ToString();
        }
        public static DsMaster.USERINFODataTable CheckLoginDetails(string username, string password)
        {
           return new VIRETAILDAL.Masters.UserInfo().CheckLoginDetails(username,Base64Encode(password));
        }
        public static string Base64Encode(string sData)
        {
            try
            {
                byte[] encData_byte = new byte[sData.Length];
                encData_byte = Encoding.UTF8.GetBytes(sData);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }
        public static string Base64Decode(string sData)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(sData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;

        }
        public static bool IsNumeric(string str)
        {
            decimal result;
            return decimal.TryParse(str, out result);
        }
        public string GetSalesStore()
        {
            var bl = new ItemMoveDataManager();
            return bl.GetSalesStore();
        }
        public static string NumericToWords(int number)
        {
            //if (number == 0)
            //    return "Zero";

            //if (number < 0)
            //    return "Minus " + NumericToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumericToWords(number / 1000000) + " Million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumericToWords(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumericToWords(number / 100) + " Hundred ";
                number %= 100;
            }
            if (number > 0)
            {
                if (words != "")
                    words += "And ";
                var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }
            return words;
        }
        public static string DecimalToWords(decimal number)
        {
            if (number == 0)
                return "Zero";

            if (number < 0)
                return "Minus " + DecimalToWords(Math.Abs(number));

            string words = "";

            int intPortion = (int)number;
            decimal fraction = (number - intPortion) * 100;
            int decPortion = (int)fraction;

            words = NumericToWords(intPortion);
            if (decPortion > 0)
            {
                words+= " and " + (int)fraction  + "/" + "100 only" ;
               // words+= words.Substring(1,1) +  words.Substring(1, words.Length-1).ToLower();
              // words.Substring(0, 1) + words.Substring(1, words.Length - 1).ToLower();
            }
            return words;
        }

 
    }
    class InputLanguageHelper
    {
        InputLanguage _arabicInput;
        InputLanguage _englishInput;


        public InputLanguageHelper()
        {
            _arabicInput = GetInputLanguageByName("arabic");
            _englishInput = GetInputLanguageByName("english");
        }

        public void SetKeyboardLayout(InputLanguage layout)
        {
            InputLanguage.CurrentInputLanguage = layout;
        }


        public static InputLanguage GetInputLanguageByName(string inputName)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.Culture.EnglishName.ToLower().StartsWith(inputName))
                    return lang;
            }
            return null;
        }

        public void LoadArabicKeyboardLayout()
        {
            if (_arabicInput != null)
                InputLanguage.CurrentInputLanguage = _arabicInput;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        public void LoadEnglishKeyboardLayout()
        {
            if (_englishInput != null)
                InputLanguage.CurrentInputLanguage = _englishInput;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

    }
}
  
 
