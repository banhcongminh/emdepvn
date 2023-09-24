<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<%@ Register Src="~/cms/admin/AdminLoadControl.ascx" TagPrefix="uc1" TagName="AdminLoadControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang quan trị website</title>
    <link href="cms/admin/css/cssAdmin.css" rel="stylesheet" />
    <script src="cms/admin/js/code.jquery.com_jquery-3.7.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--Header--%>
            <div class ="container">
                <div id ="header">
                    <div class ="logo"> 
                        Chèn logo tại đây.
                    </div>
                    <div class ="accountMenu">
                        Menu thông tin tài khoảng.
                    </div>
                </div>
            </div>
            

           <%--Menu chính--%>
            <div class ="MenuChinh">
                <div class ="container">
                    <ul>
                        <li><a class ="<%=DanhDau("") %>" href="Admin.aspx" >Trang chủ</a></li>
                        <li><a class ="<%=DanhDau("SanPham") %>" href="Admin.aspx?modul=SanPham">Sản phẩm</a></li>
                        <li><a class ="<%=DanhDau("TaiKhoang") %>" href="Admin.aspx?modul=TaiKhoang">Tài khoảng</a></li>
                        <li><a class ="<%=DanhDau("KhachHang") %>" href="Admin.aspx?modul=KhachHang">Khách hàng</a></li>
                        <li><a class ="<%=DanhDau("QuangCao") %>" href="Admin.aspx?modul=QuangCao">Quảng Cáo</a></li>
                        <li><a class ="<%=DanhDau("Menu") %>" href="Admin.aspx?modul=Menu">Menu</a></li>
                        <li><a class ="<%=DanhDau("TinTuc") %>" href="Admin.aspx?modul=TinTuc">Tin Tức </a></li>


                    </ul>
                </div>
            </div>

            <%--Phần nội dung trang--%>
            <uc1:AdminLoadControl runat="server" ID="AdminLoadControl" />
        </div>
    </form>
</body>
</html>
