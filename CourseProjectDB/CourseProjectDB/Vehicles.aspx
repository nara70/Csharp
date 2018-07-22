<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vehicles.aspx.cs" Inherits="CourseProjectDB.Vehicles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <p>
        <h2>Транспортні засоби</h2></p>
    <p>
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="MAKEOFTHECAR" HeaderText="MAKEOFTHECAR" SortExpression="MAKEOFTHECAR" />
                <asp:BoundField DataField="NUM" HeaderText="NUM" SortExpression="NUM" />
                <asp:BoundField DataField="NATIONALITY" HeaderText="NATIONALITY" SortExpression="NATIONALITY" />
                <asp:BoundField DataField="PAYMENT" HeaderText="PAYMENT" SortExpression="PAYMENT" />
                <asp:BoundField DataField="ID_DRIVER" HeaderText="ID_DRIVER" SortExpression="ID_DRIVER" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM &quot;VEHICLE&quot; WHERE &quot;ID&quot; = ?" InsertCommand="INSERT INTO &quot;VEHICLE&quot; (&quot;ID&quot;, &quot;MAKEOFTHECAR&quot;, &quot;NUM&quot;, &quot;SCANNEDDOC&quot;, &quot;NATIONALITY&quot;, &quot;PAYMENT&quot;, &quot;ID_DRIVER&quot;) VALUES (?, ?, ?, ?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM &quot;VEHICLE&quot;" UpdateCommand="UPDATE &quot;VEHICLE&quot; SET &quot;MAKEOFTHECAR&quot; = ?, &quot;NUM&quot; = ?, &quot;SCANNEDDOC&quot; = ?, &quot;NATIONALITY&quot; = ?, &quot;PAYMENT&quot; = ?, &quot;ID_DRIVER&quot; = ? WHERE &quot;ID&quot; = ?">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Decimal" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ID" Type="Decimal" />
                <asp:Parameter Name="MAKEOFTHECAR" Type="String" />
                <asp:Parameter Name="NUM" Type="String" />
                <asp:Parameter Name="SCANNEDDOC" Type="Object" />
                <asp:Parameter Name="NATIONALITY" Type="String" />
                <asp:Parameter Name="PAYMENT" Type="Decimal" />
                <asp:Parameter Name="ID_DRIVER" Type="Decimal" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="MAKEOFTHECAR" Type="String" />
                <asp:Parameter Name="NUM" Type="String" />
                <asp:Parameter Name="SCANNEDDOC" Type="Object" />
                <asp:Parameter Name="NATIONALITY" Type="String" />
                <asp:Parameter Name="PAYMENT" Type="Decimal" />
                <asp:Parameter Name="ID_DRIVER" Type="Decimal" />
                <asp:Parameter Name="ID" Type="Decimal" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
</asp:Content>
