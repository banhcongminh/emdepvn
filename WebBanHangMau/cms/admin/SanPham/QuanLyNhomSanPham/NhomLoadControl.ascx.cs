using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyNhomSanPham_NhomLoadControl : System.Web.UI.UserControl
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
            case "ThemMoi":
                plLoadControl.Controls.Add(LoadControl("NhomSanPham_ThemMoi.ascx"));
                break;
            case "ChinhSua":
                plLoadControl.Controls.Add(LoadControl("NhomSanPham_ChinhSua.ascx"));
                break;
            
        }
    }
}