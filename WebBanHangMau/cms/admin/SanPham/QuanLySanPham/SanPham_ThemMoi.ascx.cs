using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLySanPham_SanPham_ThemMoi : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["id"] != null)
            thaotac = Request.QueryString["id"];
        if (!IsPostBack)
        {
            LayDanhMucCha();
            LayMau();
        }
    }
    #region Lấy màu, size, chất liệu, nhóm.
    private void LayMau()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.Mau.Thongtin_Mau();
        ddlMau.Items.Clear();
        ddlMau.Items.Add(new ListItem("Chọn màu", "0"));

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlMau.Items.Add(new ListItem(dt.Rows[i]["TenMau"].ToString(), dt.Rows[i]["MauID"].ToString()));
            
        }
    }
    #endregion


    #region Lấy ra thông tin danh mục
    private void LayDanhMucCha()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.DanhMuc.Thongtin_Danhmuc_by_MaDMCha("0");
        ddlDanhMucCha.Items.Clear();


        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlDanhMucCha.Items.Add(new ListItem(dt.Rows[i]["TenDM"].ToString(), dt.Rows[i]["MaDM"].ToString()));
            layDanhMucCon(dt.Rows[i]["MaDM"].ToString(), "___");
        }
    }

    private void layDanhMucCon(string MaDMCha, string khoangcach)
    {
        DataTable dt = new DataTable();
        dt = emdepvn.DanhMuc.Thongtin_Danhmuc_by_MaDMCha(MaDMCha);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlDanhMucCha.Items.Add(new ListItem(khoangcach + dt.Rows[i]["TenDM"].ToString(), dt.Rows[i]["MaDM"].ToString()));
            layDanhMucCon(dt.Rows[i]["MaDM"].ToString(), khoangcach + "___");
        }
    }
    #endregion 

    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        //if (flAnhDaiDien.FileContent.Length > 0)
        //{
        //    if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") ||
        //        flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
        //    {
        //        flAnhDaiDien.SaveAs(Server.MapPath("pic/SanPham/") + flAnhDaiDien.FileName);
        //    }
        //}
        //emdepvn.DanhMuc.Danhmuc_Inser(tbTenDanhMuc.Text, flAnhDaiDien.FileName, tbThuTu.Text, ddlDanhMucCha.SelectedValue, "");

        //if (cbThemNhieuDanhMuc.Checked)
        //{
        //    // Viết code xử lý xóa các text đã để người dùng nhập danh mục tiếp theo
        //    ResetControl();
        //}
        //else
        //{
        //    // Đẩy trang về trang danh sách các danh mục đã tạo.
        //    Response.Redirect("/Admin.aspx?modul=SanPham&modulphu=DanhMuc");
        //}
    }

    private void ResetControl()
    {
        tbTenSanPham.Text = "";
        tbSoLuong.Text = "";
        tbGiaBan.Text = "";
        tbNgayTao.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        tbNgayHuy.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
    }

    protected void Huy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}