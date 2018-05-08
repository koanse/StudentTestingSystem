<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChooseQuestion.aspx.cs" Inherits="AnswerGetSystem.ChooseQuestion" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 52px;
        }
        .style2
        {
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <table style="width:100%;">
            <tr>
                <td align="center" class="style2">
    
        <asp:Label ID="Label1" runat="server" Text="Выберете вопрос:" Font-Size="14pt"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" class="style1">
        <asp:DropDownList ID="DDL_Quests" runat="server" Font-Size="12pt">
        </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="center">
    <asp:Button ID="B_Answer" runat="server" onclick="B_Answer_Click" 
        Text="Отвечать на вопрос" />
                </td>
            </tr>
        </table>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
