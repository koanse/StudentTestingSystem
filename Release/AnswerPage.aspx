<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnswerPage.aspx.cs" Inherits="AnswerGetSystem.AnswerPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td align="center" colspan="2">
        <asp:Label ID="L_question" runat="server" Text="Вопрос: " Font-Size="14pt"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
        <asp:Label ID="Label1" runat="server" Text="ФИО" Font-Size="12pt"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="TB_FIO" runat="server" Width="322px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
        <asp:Label ID="Label2" runat="server" Text="Группа" Font-Size="12pt"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="TB_group" runat="server" Width="85px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
        <asp:Label ID="Label4" runat="server" Text="Ваш ответ:" Font-Size="16pt"></asp:Label>
                    <br />
        <asp:TextBox ID="TB_Answer" runat="server" Height="221px" TextMode="MultiLine" 
            Width="843px" Font-Bold="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <br />
        <asp:Button ID="B_answer" runat="server" onclick="B_answer_Click" 
            Text="Принять ответ" Font-Bold="True" />
    
                </td>
            </tr>
        </table>
        <br />
    
    </div>
    </form>
</body>
</html>
