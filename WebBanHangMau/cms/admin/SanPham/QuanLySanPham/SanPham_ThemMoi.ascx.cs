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
    private string id = "";             //Lay ID của sản phầm cần chỉnh sửa
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
            LaySize();
            LayChatLieu();
            LayNhom();

           HienThiThongTin(id);
        }
    }

    private void HienThiThongTin(string id)
    {
        if (thaotac == "ChinhSua")
        {
            btThemMoi.Text = "Chỉnh Sửa";
            cbThemNhieuDanhMuc.Visible = false;

            DataTable dt = new DataTable();
            dt = emdepvn.SanPham.Thongtin_Sanpham_by_id(id);
            if (dt.Rows.Count > 0)
            {
                ddlDanhMucCha.SelectedValue = dt.Rows[0]["MaDM"].ToString();
                tbTenSanPham.Text = dt.Rows[0]["TenSP"].ToString();
                tbSoLuong.Text = dt.Rows[0]["SoLuongSP"].ToString();
                tbGiaBan.Text = dt.Rows[0]["GiaSP"].ToString();

                tbNgayTao.Text = dt.Rows[0]["NgayTao"].ToString();
                tbNgayHuy.Text = dt.Rows[0]["NgayHuy"].ToString();

                ddlMau.SelectedValue = dt.Rows[0]["MauID"].ToString();
                ddlSize.SelectedValue = dt.Rows[0]["SizeID"].ToString();
                ddlChatLieu.SelectedValue = dt.Rows[0]["ChatLieuID"].ToString();

                ddlNhom.SelectedValue = dt.Rows[0]["NhomID"].ToString();

                tbMoTa.Text = dt.Rows[0]["MotaSP"].ToString();

                ltrAnhDaiDien.Text = "<img class='anhDaiDien'src='/pic/SanPham/" + dt.Rows[0]["AnhSP"] + @"'/>";
                hdTenAnhDaiDienCu.Value = dt.Rows[0]["AnhSP"].ToString();
            }
        }

        else
        {
            btThemMoi.Text = "Thêm Mới";
            cbThemNhieuDanhMuc.Visible = true;
            tbNgayTao.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
            tbNgayHuy.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        }

    }
    #region Lấy màu, size, chất liệu, nhóm.
    private void LayNhom()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.NhomSanPham.Thongtin_Nhomsp();
        ddlNhom.Items.Clear();
        ddlNhom.Items.Add(new ListItem("Chọn nhóm sản phẩm", "0"));

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlNhom.Items.Add(new ListItem(dt.Rows[i]["TenNhom"].ToString(), dt.Rows[i]["NhomID"].ToString()));

        }
    }
    private void LayChatLieu()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.ChatLieu.Thongtin_Chatlieu();
        ddlChatLieu.Items.Clear();
        ddlChatLieu.Items.Add(new ListItem("Chọn chất liệu", "0"));

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlChatLieu.Items.Add(new ListItem(dt.Rows[i]["TenChatLieu"].ToString(), dt.Rows[i]["ChatLieuID"].ToString()));

        }
    }
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
    private void LaySize()
    {
        DataTable dt = new DataTable();
        dt = emdepvn.Size.Thongtin_Size();
        ddlSize.Items.Clear();
        ddlSize.Items.Add(new ListItem("Chọn Size", "0"));

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlSize.Items.Add(new ListItem(dt.Rows[i]["TenSize"].ToString(), dt.Rows[i]["SizeID"].ToString()));

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
        if (flAnhDaiDien.FileContent.Length > 0)
        {
            if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") ||
                flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
            {
                flAnhDaiDien.SaveAs(Server.MapPath("pic/SanPham/") + flAnhDaiDien.FileName);
            }
        }
        emdepvn.SanPham.Sanpham_Inser(tbTenSanPham.Text,ddlMau.SelectedValue,ddlSize.SelectedValue,ddlChatLieu.SelectedValue,flAnhDaiDien.FileName,
            tbSoLuong.Text,tbGiaBan.Text,tbMoTa.Text,tbNgayTao.Text,tbNgayHuy.Text,ddlDanhMucCha.SelectedValue,ddlNhom.SelectedValue,"");


        if (cbThemNhieuDanhMuc.Checked) 
        {
            // Viết code xử lý xóa các text đã để người dùng nhập danh mục tiếp theo
            ResetControl();
        }
        else
        {
            // Đẩy trang về trang danh sách các danh mục đã tạo.
            Response.Redirect("/Admin.aspx?modul=SanPham&modulphu=DanhSachSanPham");
        }
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