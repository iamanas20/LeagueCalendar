<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageOne.aspx.cs" Inherits="LeagueCalendar.PageOne" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <asp:Label ID="LeagueNamePlusYearLabel" Text="" runat="server" />
            <br /><br />
            <asp:Label Text="Match: " runat="server" />
            <asp:DropDownList ID="MatchesDropDownList" AutoPostBack="true" OnSelectedIndexChanged="MatchesDropDownList_SelectedIndexChanged" runat="server">
            </asp:DropDownList>
            <br /><br /><br />
            <asp:Calendar SelectedDayStyle-BackColor="#5b55d9" SelectionMode="Day" SelectedDayStyle-Font-Italic="true" runat="server"></asp:Calendar>
            <br /><br />
            <asp:Label ID="MatchDateLabel" Text="" runat="server" />
            <br /><br />
            <asp:Label ID="MatchFinalInfoLabel" Text="" runat="server" />
        </div>
    </form>
</body>
</html>
