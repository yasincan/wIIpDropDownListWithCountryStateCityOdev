<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Programlama_II.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 118px;
        }
        .auto-style2 {
            width: 118px;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
    </style>
</head>
<body style="width: 459px">
    <form id="form1" runat="server">
        <div>
            <table style="width: 322px; height: 122px"
                >
                <tr>
                    <td class="auto-style2">Ülke Adı :</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ulkeDropDownList" runat="server" Height="16px" Width="185px" AutoPostBack="True" OnSelectedIndexChanged="ulkeDropDownList_SelectedIndexChanged" DataTextField="--Lütfen ülke seçin--">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">İl Adı :</td>
                    <td>
                        <asp:DropDownList ID="ilDropDownList" runat="server" Height="16px" Width="185px" AutoPostBack="True" OnSelectedIndexChanged="ilDropDownList_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">İlçe Adı :</td>
                    <td>
                        <asp:DropDownList ID="ilceDropDownList" runat="server" Height="16px" Width="185px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                   
                    <td colspan="2" style="margin-left: 40px">
                        <asp:Button ID="Button1" runat="server" Height="41px" Text="Seçimi Göster" Width="304px" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
            <asp:Label ID="ulkeLabel" runat="server"></asp:Label>
            <br />
            <asp:Label ID="ilLabel" runat="server"></asp:Label>
            <br />
            <asp:Label ID="ilceLabel" runat="server"></asp:Label>         
        </div>
    </form>
</body>
</html>
