<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TinTucLoadControl.ascx.cs" Inherits="cms_admin_TinTuc_TinTuc" %>
Đây là trang tin tức

<ul>
    <li><a href ="/Admin.aspx?modul=TinTuc&modulphu=DanhSachTinTuc">Danh sách tin tức </a></li>
    <li><a href ="/Admin.aspx?modul=TinTuc&modulphu=NhomTinTuc">Nhóm tin tức </a></li>
</ul>
<asp:PlaceHolder ID="plTinTucLoadControl" runat="server"></asp:PlaceHolder>
