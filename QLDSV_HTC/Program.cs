using DevExpress.Skins;
using DevExpress.UserSkins;
//using QLDSV_HTC.Forms; ///
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLDSV_HTC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        //public static frmLop frmLop = new frmLop();

        public static SqlConnection Conn = new SqlConnection();
        public static string Connstr = "";
        //public static string Connstr_pub = "Data Source=QUYNH;Initial Catalog=QLDSV_HTC;Integrated Security=True";
        public static string Connstr_pub = "Data Source=DESKTOP-ENO2DP6\\MSSQLSERVER4;Initial Catalog=QLDSV_HTC;User ID=sa;Password=123";


        public static string remoteLogin = "HTKN";
        public static string remotePass = "123";
        public static SqlDataReader myReader;
        public static string userName = "";
        public static string mHoTen = "";
        public static string mGroup = "";
        public static string ServerName = "";
        public static string DataBase = "QLDSV_HTC";
        public static string MLogin = "";
        public static string MPass = "";
        public static int MKhoa;
        public static string MUser = "";
        public static string MUserPass = "";


        public static String MLoginDN = string.Empty;
        public static String MPassDN = string.Empty;


        public static BindingSource bds_dspm = new BindingSource(); // luu ds pm


        public static frmMain frmMain;
        public static frmDangNhap frmDangNhap;

        public static string[] quyen = new string[4] { "PGV", "KHOA", "SINH VIEN", "PKT" };

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myReader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.Conn);

            //xác định kiểu lệnh cho sqlcmd là kiểu text.
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (Program.Conn.State == ConnectionState.Closed) Program.Conn.Open();
            
            try
            {
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }
            catch (SqlException ex)
            {
                Program.Conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.Conn.State == ConnectionState.Closed) Program.Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Conn);
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static int ExecSqlNonQuery(string strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, Conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600; // 10 phut
            if (Conn.State == ConnectionState.Closed) Conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery();
                Conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(strlenh);
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Conn.Close();
                return ex.State;
            }
        }
        public static int KetNoi()
        {
            if (Program.Conn != null && Program.Conn.State == System.Data.ConnectionState.Open)
                Program.Conn.Close();
            try
            {
                Program.Connstr = "Data Source=" + Program.ServerName + ";Initial Catalog=" + Program.DataBase
                  + ";User ID=" + Program.MLogin + ";Password=" + Program.MPass;
                Program.Conn.ConnectionString = Program.Connstr;
                Console.WriteLine(Program.Connstr);
                Program.Conn.Open();
                return 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!\n Xem lại tài khoản, mật khẩu hoặc khoa đã chọn!!!","",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Program.frmMain = new frmMain();
            Program.frmMain.Show();
            Program.frmMain.Enabled = false;

            Program.frmDangNhap = new frmDangNhap();
            Application.Run(Program.frmDangNhap);
        }
    }
}
