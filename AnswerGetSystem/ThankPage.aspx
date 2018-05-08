<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThankPage.aspx.cs" Inherits="AnswerGetSystem.ThankPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
        <asp:Label ID="Label1" runat="server" Text="Спасибо за Ваш ответ!" 
            Font-Italic="True" Font-Size="20pt"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" 
            NavigateUrl="~/ChooseQuestion.aspx" Font-Size="14pt">Перейти к выбору вопроса</asp:HyperLink>
    </center>
    </div>
    </form>
</body>
</html>
