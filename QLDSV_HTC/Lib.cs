using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    }
}
