using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//to usse TextInfo
using System.Globalization;

namespace QLDSV_HTC
{
    class Lib
    {

        //binding dt vaof cmb
        public static void BDataToCmb(ComboBox cmb, object data)
        {
            cmb.DataSource = data;
            cmb.DisplayMember = "TENKHOA";
            cmb.ValueMember = "TENSERVER";

            //cmb.SelectedIndex = 1;

            cmb.SelectedIndex = Program.MKhoa;
        }

        public static void CmbHelper (ComboBox cmb)
        {
            if (cmb.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            //gan server vua chon
            Program.ServerName = cmb.SelectedValue.ToString();

            //neu qua server khac thi dung remotelogin
            if(Program.MKhoa != cmb.SelectedIndex)
            {
                Program.MLogin = Program.remoteLogin;
                Program.MPass = Program.remotePass;
            }
            else
            {
                //site khac ve site ban dau thi su dung tai khoan da dang nhap
                Program.MLogin = Program.MLoginDN;
                Program.MPass = Program.MPassDN;
            }
        }

        public static int checkData(string cmd)
        {
            // return 1 site hien tai
            //return 2 site khac
            SqlDataReader dataReader = Program.ExecSqlDataReader(cmd);

            if (dataReader == null) return -1;

            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            return result;
        }

        public static string ToCapitalize(string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }
        public static string NumberToText(double inputNumber)
        {
            string[] unitNumbers = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] placeValues = new string[] { "", "nghìn", "triệu", "tỷ" };
            bool isNegative = false;

            // -12345678.3445435 => "-12345678"
            string sNumber = inputNumber.ToString("#");
            double number = Convert.ToDouble(sNumber);
            if (number < 0)
            {
                number = -number;
                sNumber = number.ToString();
                isNegative = true;
            }


            int ones, tens, hundreds;

            int positionDigit = sNumber.Length;   // last -> first

            string result = " ";


            if (positionDigit == 0)
                result = unitNumbers[0] + result;
            else
            {
                // 0:       ###
                // 1: nghìn ###,###
                // 2: triệu ###,###,###
                // 3: tỷ    ###,###,###,###
                int placeValue = 0;

                while (positionDigit > 0)
                {
                    // Check last 3 digits remain ### (hundreds tens ones)
                    tens = hundreds = -1;
                    ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                            positionDigit--;
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                        result = placeValues[placeValue] + result;

                    placeValue++;
                    if (placeValue > 3) placeValue = 1;

                    if ((ones == 1) && (tens > 1))
                        result = "một " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                            result = "lăm " + result;
                        else if (ones > 0)
                            result = unitNumbers[ones] + " " + result;
                    }
                    if (tens < 0)
                        break;
                    else
                    {
                        if ((tens == 0) && (ones > 0)) result = "lẻ " + result;
                        if (tens == 1) result = "mười " + result;
                        if (tens > 1) result = unitNumbers[tens] + " mươi " + result;
                    }
                    if (hundreds < 0) break;
                    else
                    {
                        if ((hundreds > 0) || (tens > 0) || (ones > 0))
                            result = unitNumbers[hundreds] + " trăm " + result;
                    }
                    result = " " + result;
                }
            }
            result = result.Trim();
            if (isNegative) result = "Âm " + result;
            return result;
        }

    }
}
