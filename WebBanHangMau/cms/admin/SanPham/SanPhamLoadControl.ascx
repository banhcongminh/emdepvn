<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SanPhamLoadControl.ascx.cs" Inherits="cms_admin_SanPham_SanPhamLoadControl" %>


<div class="container">
    <div class="cotTrai">
        <div class="head">
            Quản lý
        </div>
          <ul>
            <li><a class ="<%=DanhDau("sanpham","DanhMuc","") %>" href="/Admin.aspx?modul=SanPham&modulphu=DanhMuc">Danh mục sản phẩm</a></li>
            <li><a class ="<%=DanhDau("sanpham","NhomSanPham","") %>" href="/Admin.aspx?modul=SanPham&modulphu=NhomSanPham">Nhóm sản phẩm</a></li>
            <li><a class ="<%=DanhDau("sanpham","DanhSachSanPham","") %>" href="/Admin.aspx?modul=SanPham&modulphu=DanhSachSanPham">Danh sách sản phẩm</a></li>
            <li><a class ="<%=DanhDau("sanpham","Mau","") %>" href="/Admin.aspx?modul=SanPham&modulphu=Mau">Màu sản phẩm</a></li>
            <li><a class ="<%=DanhDau("sanpham","ChatLieu","") %>" href="/Admin.aspx?modul=SanPham&modulphu=ChatLieu">Chất liệu sản phẩm</a></li>
            <li><a class ="<%=DanhDau("sanpham","Size","") %>" href="/Admin.aspx?modul=SanPham&modulphu=Size">Size sản phẩm</a></li>
        </ul>
        <div class="head">
            Thêm mới
        </div>
        <ul>
            <li><a class ="<%=DanhDau("sanpham","DanhMuc","ThemMoi") %>" href="/Admin.aspx?modul=SanPham&modulphu=DanhMuc&thaotac=ThemMoi">Danh mục sản phẩm</a></li>
            
            <li><a class ="<%=DanhDau("sanpham","DanhSachSanPham","ThemMoi") %>" href="/Admin.aspx?modul=SanPham&modulphu=DanhSachSanPham&thaotac=ThemMoi">Danh sách sản phẩm</a></li>
            <li><a class ="<%=DanhDau("sanpham","Mau","ThemMoi") %>" href="/Admin.aspx?modul=SanPham&modulphu=Mau&thaotac=ThemMoi">Màu sản phẩm</a></li>
            <li><a class ="<%=DanhDau("sanpham","ChatLieu","ThemMoi") %>" href="/Admin.aspx?modul=SanPham&modulphu=ChatLieu&thaotac=ThemMoi">Chất liệu sản phẩm</a></li>
            <li><a class ="<%=DanhDau("sanpham","Size","ThemMoi") %>" href="/Admin.aspx?modul=SanPham&modulphu=Size&thaotac=ThemMoi">Size sản phẩm</a></li>
            <li><a class ="<%=DanhDau("sanpham","NhomSanPham","ThemMoi") %>" href="/Admin.aspx?modul=SanPham&modulphu=NhomSanPham&thaotac=ThemMoi">Nhóm sản phẩm</a></li>

        </ul>
    </div>

<div class="cotPhai">
    <asp:PlaceHolder ID="plSanPhamLoadControl" runat="server"></asp:PlaceHolder>

</div>

<div class ="cb"><!----------></div>
</div>