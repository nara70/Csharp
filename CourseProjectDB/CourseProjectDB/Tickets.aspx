<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tickets.aspx.cs" Inherits="CourseProjectDB.Tickets" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <p>
        <h2>Квитки</h2></p>
    <p>
        <br />
    <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" Height="50px" Width="125px">
        <Fields>
            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="PRICE" HeaderText="PRICE" SortExpression="PRICE" />
            <asp:BoundField DataField="DISCOUNT" HeaderText="DISCOUNT" SortExpression="DISCOUNT" />
            <asp:BoundField DataField="RESERVATION" HeaderText="RESERVATION" SortExpression="RESERVATION" />
            <asp:BoundField DataField="ID_PASSANGER" HeaderText="ID_PASSANGER" SortExpression="ID_PASSANGER" />
            <asp:BoundField DataField="ID_CABIN" HeaderText="ID_CABIN" SortExpression="ID_CABIN" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
        </Fields>
    </asp:DetailsView>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="PRICE" HeaderText="PRICE" SortExpression="PRICE" />
            <asp:BoundField DataField="DISCOUNT" HeaderText="DISCOUNT" SortExpression="DISCOUNT" />
            <asp:BoundField DataField="RESERVATION" HeaderText="RESERVATION" SortExpression="RESERVATION" />
            <asp:BoundField DataField="ID_PASSANGER" HeaderText="ID_PASSANGER" SortExpression="ID_PASSANGER" />
            <asp:BoundField DataField="ID_CABIN" HeaderText="ID_CABIN" SortExpression="ID_CABIN" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM &quot;TICKET&quot; WHERE &quot;ID&quot; = ?" InsertCommand="INSERT INTO &quot;TICKET&quot; (&quot;ID&quot;, &quot;PRICE&quot;, &quot;DISCOUNT&quot;, &quot;RESERVATION&quot;, &quot;ID_PASSANGER&quot;, &quot;ID_CABIN&quot;) VALUES (?, ?, ?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM &quot;TICKET&quot;" UpdateCommand="UPDATE &quot;TICKET&quot; SET &quot;PRICE&quot; = ?, &quot;DISCOUNT&quot; = ?, &quot;RESERVATION&quot; = ?, &quot;ID_PASSANGER&quot; = ?, &quot;ID_CABIN&quot; = ? WHERE &quot;ID&quot; = ?">
        <DeleteParameters>
            <asp:Parameter Name="ID" Type="Decimal" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ID" Type="Decimal" />
            <asp:Parameter Name="PRICE" Type="Decimal" />
            <asp:Parameter Name="DISCOUNT" Type="Decimal" />
            <asp:Parameter Name="RESERVATION" Type="Decimal" />
            <asp:Parameter Name="ID_PASSANGER" Type="Decimal" />
            <asp:Parameter Name="ID_CABIN" Type="Decimal" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="PRICE" Type="Decimal" />
            <asp:Parameter Name="DISCOUNT" Type="Decimal" />
            <asp:Parameter Name="RESERVATION" Type="Decimal" />
            <asp:Parameter Name="ID_PASSANGER" Type="Decimal" />
            <asp:Parameter Name="ID_CABIN" Type="Decimal" />
            <asp:Parameter Name="ID" Type="Decimal" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
