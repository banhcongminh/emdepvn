using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLySanPham_Ajax_SanPham : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        // Cần có code kiểm tra đăng nhập. Sau đó mới thực hiện các thao tác ở dưới.
        if (Request.Params["ThaoTac"] != null)
            thaotac = Request.Params["ThaoTac"];
        switch(thaotac)
        {
            case "XoaSanPham":
                XoaSanPham();
                break;
        }
    }

    private void XoaSanPham()
    {
        string MaSP = "";
        if (Request.Params["MaSP"] != null )
            MaSP = Request.Params["MaSP"];
        
        // Thực hiện code xóa
        // Bước 1: Xóa ảnh đại diện đã lưu trên sever.
        // Bước 2: Xóa bản ghi trên sql.
        emdepvn.SanPham.Sanpham_Delete(MaSP);
        //In ra thông báo: (1) thực hiện thành công, (2) thực hiện không thành công.    
        Response.Write("Đã thực hiện.");
    }
}