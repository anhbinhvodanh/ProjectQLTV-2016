using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DTO;

namespace GUI
{
    static class Program
    {
        public static string sqlConnectString;
        public static ThuThuDTO thuThu = new ThuThuDTO
        {
            maThuThu = 1,
            tenThuThu = "Pham Van Cuong",
            taiKhoan = "admin",
            matKhau = "123"
        };
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            Application.Run(new FormTrangChu());
        }
    }
}
