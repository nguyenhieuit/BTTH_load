<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="layer.aspx.cs" Inherits="bt_test_load.layer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css_load.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="top_bgr">
            <asp:Image ID="Image1" runat="server" ImageUrl="./images/top_bgr.gif" Width="100%" Height="70px"/>
        </div>
        <div class="menu">
            <asp:HyperLink ID="HyperLink1" runat="server">Trang chủ</asp:HyperLink>
            <asp:HyperLink ID="HyperLink2" runat="server">Sản phẩm</asp:HyperLink>
            <asp:HyperLink ID="HyperLink3" runat="server">Dịch vụ</asp:HyperLink>
            <asp:HyperLink ID="HyperLink4" runat="server">Chi tiết</asp:HyperLink>
            <asp:HyperLink ID="HyperLink5" runat="server">Khuyễn mãi</asp:HyperLink>
        </div>
        <div class="ND">
            <div class="left">
                <h1>Danh mục các loại sản phẩm</h1>

            </div>
            <div class="mid">

            </div>
            <div class="login">

                <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" >
                </asp:Login>

            </div>
        </div>
    </form>
</body>
</html>
