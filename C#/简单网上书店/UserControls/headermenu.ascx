<%@ Control Language="c#" Inherits="MyBookShop.UserControls.HeaderMenu" CodeFile="HeaderMenu.ascx.cs" %>
    <table id="Table1" cellspacing="1" cellpadding="1" width="100%" border="0">
        <tr>
            <td>
                <img src="Images/logo.jpg"/ alt="logo" />

            </td>
       </tr>
        <tr>
            <td valign="baseline">
                <asp:Label ID="LabelHello" runat="server"></asp:Label><br/>
                <asp:LinkButton ID="LinkButtonLogin" runat="server" OnClick="LinkButtonLogin_Click"></asp:LinkButton>&&<a
                    href="BookAdd.aspx">添加图书</a>&&<a href="BookList.aspx">浏览图书</a>&&<a href="BookStatistics.aspx">图书统计</a>&&<a
                        href="CartView.aspx">我的购物篮</a>
            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>
    </table>