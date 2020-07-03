using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GreenCabV1.Repository
{
    public static class CommonFunction
    {
        private static readonly System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
        public static bool SendMail(string mailSub, string body, string emailTo)
        {

            string strFrom, strTo, strSubject, strBody;
            strFrom = "greencarcarpool2@gmail.com";
            strTo = emailTo;
            strSubject = mailSub;
            strBody = body;


            return SendMailByBW(strFrom, strTo, strSubject, strBody); ;

        }
        //Update By Kamlesh
        public static bool SendMailByBW(string from, string to, string subject, string body)
        {
            try
            {

                //Encoed
                byte[] bytes = Encoding.UTF8.GetBytes(body);
                string _body = Convert.ToBase64String(bytes);
                //decode

                string base64 = "YWJjZGVmPT0=";
                byte[] bytes1 = Convert.FromBase64String(base64);
                string str = Encoding.UTF8.GetString(bytes1);


                var values = new Dictionary<string, string>
{
            { "FromEmail", "greencarpool2@gmail.com"},
            { "FromPassword",  "Green@1234"},
            { "toEmail", to },
            { "EmailBody",body+ GetEmailFooter() },
            { "MailSubject", subject},
            { "MailDisplayName", "Greencar Carpooling NGO- Save Money, Save Enviroment" },
};

                var content = new System.Net.Http.FormUrlEncodedContent(values);

                var response = client.PostAsync("http://t1.roken4life.com/sendemail.aspx", content);//http://localhost:57867/SendEmail.aspx    http://t1.roken4life.com/sendemail.aspx

                var responseString = response.Result.Content.ReadAsStringAsync();// ReadAsStringAsync();




                return true;
            }
            catch (Exception ex)
            {
                var s = ex.ToString();
                return false;
            }
        }
        public static string GetEmailFooter()
        {
            string Footer = "<br/><br/><strong>NOTE:</strong><br/>";
            Footer += "<br/>-----------------------------------------------------------------------------------------------------------------<br/>";
            Footer += "<span style='font-size:10px;font-family:Times New Roman'>Kindly note that information contained in our website are for general public to use however we make no representations or warranties of any kind, expressed or implied about the completeness, accuracy, reliability , sustainability or availability with respect to users details or map or any information or electronic data for any purpose.  You are requested to follow law, rules and regulations of law of land. Kindly go through FAQ & terms and conditions page for more details.</span>";
            Footer += "<br/><br/>";
            Footer += "<span style='font-size:10px;font-family:Times New Roman'>GreenCar understand that air pollution & traffic congestion is matter of concern for all of us.  We are also trying to reduce your driving stress and fuel expenses. Kindly help us in this noble cause.</span>";
            Footer += "<br/>-----------------------------------------------------------------------------------------------------------------<br/>";
            return Footer;
        }
        public static string API_Key_Decrypt(string EncryptedText)
        {


            try
            {

                EncryptedText = ConvertHexToString(EncryptedText, Encoding.Unicode);

                byte[] inputByteArray = new byte[EncryptedText.Length + 1];
                byte[] rgbIV = { 0x21, 0x44, 0x56, 0x87, 0x10, 0xfd, 0xea, 0x1c };
                //  byte[] rgbIV = { 0x22,0x43 };
                //  byte[] rgbIV = { };
                byte[] key = { };
                key = System.Text.Encoding.UTF8.GetBytes("A0D1nX0Q");
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                inputByteArray = Convert.FromBase64String(EncryptedText);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(key, rgbIV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                System.Text.Encoding encoding = System.Text.Encoding.UTF8;
                return encoding.GetString(ms.ToArray());
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        static readonly string PasswordHash = "P@@Sw0rd";
        static readonly string SaltKey = "S@LT&KEY";
        static readonly string VIKey = "@1B2c3D4e5F6g7H8";
        //Encrypt
        public static string API_Key_Encrypt(string stringToEncrypt)
        {

            try
            {
                byte[] inputByteArray = Encoding.UTF8.GetBytes(stringToEncrypt);
                byte[] rgbIV = { 0x21, 0x44, 0x56, 0x87, 0x10, 0xfd, 0xea, 0x1c };
                byte[] key = { };
                key = System.Text.Encoding.UTF8.GetBytes("A0D1nX0Q");
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(key, rgbIV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                return ConvertStringToHex(Convert.ToBase64String(ms.ToArray()), System.Text.Encoding.Unicode);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }


        public static string ConvertHexToString(String hexInput, System.Text.Encoding encoding)
        {
            int numberChars = hexInput.Length;
            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hexInput.Substring(i, 2), 16);
            }
            return encoding.GetString(bytes);
        }

        private static string ConvertStringToHex(String input, System.Text.Encoding encoding)
        {
            Byte[] stringBytes = encoding.GetBytes(input);
            StringBuilder sbBytes = new StringBuilder(stringBytes.Length * 2);
            foreach (byte b in stringBytes)
            {
                sbBytes.AppendFormat("{0:X2}", b);
            }
            return sbBytes.ToString();
        }

    }
}
