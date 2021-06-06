<%@ Page Title="" Language="C#" MasterPageFile="~/start.Master" AutoEventWireup="true" CodeBehind="giohang.aspx.cs" Inherits="bt_test_load.giohang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h1>
        Giỏ hàng
    </h1>
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="MaSP" HeaderText="Mã sản phẩm" />
                <asp:BoundField DataField="TenSP" HeaderText="Tên hàng" />
                <asp:BoundField DataField="Gia" HeaderText="Đơn giá" />
                <asp:BoundField DataField="Soluong" HeaderText="Số lượng" />
                <asp:BoundField DataField="thanhtien" HeaderText="Thành tiền" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
