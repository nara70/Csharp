<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cabins.aspx.cs" Inherits="CourseProjectDB.Cabins" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <p>
        <h2>Каюти</h2></p>
    <p>
        <br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource2">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="AMOUNTOFBERTHS" HeaderText="AMOUNTOFBERTHS" SortExpression="AMOUNTOFBERTHS" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM &quot;CABIN&quot; WHERE &quot;ID&quot; = ?" InsertCommand="INSERT INTO &quot;CABIN&quot; (&quot;ID&quot;, &quot;AMOUNTOFBERTHS&quot;) VALUES (?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM &quot;CABIN&quot;" UpdateCommand="UPDATE &quot;CABIN&quot; SET &quot;AMOUNTOFBERTHS&quot; = ? WHERE &quot;ID&quot; = ?">
        <DeleteParameters>
            <asp:Parameter Name="ID" Type="Decimal" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ID" Type="Decimal" />
            <asp:Parameter Name="AMOUNTOFBERTHS" Type="Decimal" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="AMOUNTOFBERTHS" Type="Decimal" />
            <asp:Parameter Name="ID" Type="Decimal" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
</asp:Content>
