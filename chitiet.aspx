<%@ Page Title="" Language="C#" MasterPageFile="~/start.Master" AutoEventWireup="true" CodeBehind="chitiet.aspx.cs" Inherits="bt_test_load.chitiet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
    <style>
        .return{
            float:right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h1>Chi tiết sản phẩm</h1>
    <div class="return">
        <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="./images/icon/return.png"></asp:HyperLink>
    </div>
    <asp:DataList ID="DataList1" runat="server" Width="334px">
        <ItemTemplate>
            <div id="tensp">
                <asp:Label ID="Label1" runat="server" Text='<%#Eval("TenSP") %>'></asp:Label>
            </div>
            <br />
            <div id="SP">
                <div id="hinhct">
                    <asp:Image ID="Image2" runat="server" ImageUrl='<%# "~/images/HinhSP/" + Eval("Hinh") %>' Width="100px" />
                    <div class="Gia">
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("Gia", "{0:0,0}") %>'></asp:Label>
                    </div>
                </div>
            </div>
            <div id="chitiet">
                <asp:Label ID="Label3" runat="server" Text='<%#Eval("MoTa") %>'></asp:Label>
            </div>
            
        </ItemTemplate>

    </asp:DataList>
</asp:Content>
