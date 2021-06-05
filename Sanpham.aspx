<%@ Page Title="" Language="C#" MasterPageFile="~/start.Master" AutoEventWireup="true" CodeBehind="Sanpham.aspx.cs" Inherits="bt_test_load.Sanpham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #DataList2{
            width:200px;
            height:200px;
        }
        #sanpham{
            width:100%;
            border-style:double;
            margin-left: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h1>
        Danh mục sản phẩm
    </h1>
    <asp:DataList ID="DataList2" runat="server" RepeatColumns="3" >
        <ItemTemplate>
            <div id="sanpham">
                <asp:Image ID="Image2" runat="server" Width="80px" ImageUrl='<%# "~/images/hinhSP/" + Eval("Hinh") %>' />
            <br />
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenSP") %>'></asp:Label>
            <br />
                <div class="Gia">
                    <%# Eval("Gia", "{0:0,0}") %>
                </div>
            <br />
                <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("MaSP") %>' OnClick="LinkButton2_Click">Chi tiết sản phẩm</asp:LinkButton>
            </div>
        </ItemTemplate>

    </asp:DataList>
</asp:Content>
