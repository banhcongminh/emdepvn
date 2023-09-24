using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyDanhMuc_DanhMuc_HienThi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            LayDanhMuc();
    }

    private void LayDanhMuc()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.DanhMuc.Thongtin_Danhmuc();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrDanhMuc.Text += @"
            <tr id='maDong_"+ dt.Rows[i]["MaDM"] + @"'>
                <td class ='cotMa''>"+dt.Rows[i]["MaDM"] +@"</td>
                <td class ='cotTen'>"+dt.Rows[i]["TenDM"] +@"</td>
                <td class ='cotAnh'>
                    <img class='anhDaiDien' src='/pic/SanPham/"+dt.Rows[i]["AnhDaiDien"] + @"'>
                    <img class='anhDaiDienHover' src='/pic/SanPham/"+dt.Rows[i]["AnhDaiDien"] + @"'>
                </td>
                <td class ='cotThuTu'>" + dt.Rows[i]["ThuTu"] +@"</td>
                <td class ='cotCongCu'>
                    <a href='#' class ='dmcon' title='Xem danh mục con'></a>
                    <a href='#' class ='sua' title='Sửa'></a>
                    <a href='javascript:XoaDanhMuc(" + dt.Rows[i]["MaDM"] + @")' class ='xoa' title='Xóa'></a>
                </td>           
            </tr>
            ";
        }
    }

}