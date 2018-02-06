<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="P_O_O_P._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
    .style1
    {
        width: 264px;
    }
        .style2
        {
            width: 264px;
            height: 23px;
        }
        .style3
        {
        height: 23px;
    }
    .style4
    {
        width: 264px;
        height: 21px;
    }
    .style5
    {
        height: 21px;
    }
    .style6
    {
        width: 300px;
        height: 25px;
    }
    .style7
    {
        height: 25px;
    }
    .style9
    {
        height: 25px;
        width: 229px;
    }
    .style11
    {
        width: 229px;
    }
    .style12
    {
        width: 229px;
        height: 23px;
    }
    .style13
    {
        width: 229px;
        height: 21px;
    }
    .style14
    {
        width: 300px;
        height: 32px;
    }
    .style15
    {
        width: 229px;
        height: 32px;
    }
    .style16
    {
        height: 32px;
    }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <table style="width:100%;">
    <tr>
        <td class="style2">
            </td>
        <td class="style12">
            Enter a P.O.O.P ID#</td>
        <td class="style3">
            </td>
    </tr>
    <tr>
        <td class="style6">
            </td>
        <td class="style9">
            <asp:TextBox ID="TextBox1" runat="server" Width="92px"></asp:TextBox>
        </td>
        <td class="style7">
            </td>
    </tr>
    <tr>
        <td class="style4">
            </td>
        <td class="style13">
            Or Select an Organization</td>
        <td class="style5">
            </td>
    </tr>
    <tr>
        <td class="style4">
            </td>
        <td class="style13">
            <asp:DropDownList ID="DropDownList1" runat="server" 
                DataSourceID="SqlDataSource1" DataTextField="ORG_Name" DataValueField="ORG_ID" 
                Width="203px">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:poopstatsConnectionString %>" 
                SelectCommand="SELECT [ORG_Name], [ORG_ID] FROM [ORG]"></asp:SqlDataSource>
        </td>
        <td class="style5">
            </td>
    </tr>
    <tr>
        <td class="style14">
            </td>
        <td class="style15">
            <asp:Button ID="Button1" runat="server" Text="View Stats" Width="205px" 
                onclick="Button1_Click" />
        </td>
        <td class="style16">
            </td>
    </tr>
    <tr>
        <td class="style1">
            &nbsp;</td>
        <td class="style11">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
