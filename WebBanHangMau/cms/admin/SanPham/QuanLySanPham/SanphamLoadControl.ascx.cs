using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLySanPham_SanphamLoadControl : System.Web.UI.UserControl
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
        {
            thaotac = Request.QueryString["thaotac"];
        }
        switch (thaotac)
        {
            case "ChinhSua":
            case "ThemMoi":
                plLoadControl.Controls.Add(LoadControl("SanPham_ThemMoi.ascx"));
                break;
            default:
                plLoadControl.Controls.Add(LoadControl("SanPham_HienThi.ascx"));
                break;

        }
    }
}