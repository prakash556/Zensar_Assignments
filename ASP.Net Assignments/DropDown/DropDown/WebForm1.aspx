﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DropDown.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 974px;
            height: 347px;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style4 {
            width: 479px;
            text-align: center;
            height: 181px;
        }
        .auto-style5 {
            height: 181px;
            text-align: center;
        }
        .auto-style6 {
            width: 479px;
            text-align: center;
            height: 120px;
        }
        .auto-style7 {
            height: 120px;
            text-align: left;
        }
    </style>
</head>
<body style="width: 978px; height: 352px; margin-left: 29px">
    <form id="form1" runat="server" class="auto-style1">
        <div>
        </div>
        &emsp;
        <table class="auto-style2">
            <tr>
                <td class="auto-style4">
       Select Any Item <asp:DropDownList ID="DropDownList1" runat="server" Height="33px" Width="78px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
                </td>
                <td class="auto-style5">
                    <asp:Image ID="Image1" runat="server" Height="133px" Width="202px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Cost" Height="32px" Width="55px" OnClick="Button1_Click" />
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label1" runat="server" Text="Cost Of Selected Item"></asp:Label>&emsp;
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
