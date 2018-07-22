<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Passangers.aspx.cs" Inherits="CourseProjectDB.Passangers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <p>
        <h2>Пасажири</h2></p>
    <p>
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="NATIONALITY" HeaderText="NATIONALITY" SortExpression="NATIONALITY" />
                <asp:BoundField DataField="PASSPORTDATA" HeaderText="PASSPORTDATA" SortExpression="PASSPORTDATA" />
                <asp:BoundField DataField="RESTOURANTTABLENUMBER" HeaderText="RESTOURANTTABLENUMBER" SortExpression="RESTOURANTTABLENUMBER" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM &quot;PASSANGER&quot; WHERE &quot;ID&quot; = ?" InsertCommand="INSERT INTO &quot;PASSANGER&quot; (&quot;ID&quot;, &quot;NATIONALITY&quot;, &quot;PASSPORTDATA&quot;, &quot;RESTOURANTTABLENUMBER&quot;) VALUES (?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM &quot;PASSANGER&quot;" UpdateCommand="UPDATE &quot;PASSANGER&quot; SET &quot;NATIONALITY&quot; = ?, &quot;PASSPORTDATA&quot; = ?, &quot;RESTOURANTTABLENUMBER&quot; = ? WHERE &quot;ID&quot; = ?">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Decimal" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ID" Type="Decimal" />
                <asp:Parameter Name="NATIONALITY" Type="String" />
                <asp:Parameter Name="PASSPORTDATA" Type="String" />
                <asp:Parameter Name="RESTOURANTTABLENUMBER" Type="Decimal" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="NATIONALITY" Type="String" />
                <asp:Parameter Name="PASSPORTDATA" Type="String" />
                <asp:Parameter Name="RESTOURANTTABLENUMBER" Type="Decimal" />
                <asp:Parameter Name="ID" Type="Decimal" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
</asp:Content>
