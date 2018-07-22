<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DBLab9._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <br />
        Продукти<asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" Height="50px" Width="125px" AllowPaging="True" DataKeyNames="ID" DataSourceID="SqlDataSource1" OnPageIndexChanging="DetailsView1_PageIndexChanging">
            <Fields>
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="GROUPOFPRODUCT" HeaderText="GROUPOFPRODUCT" SortExpression="GROUPOFPRODUCT" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM &quot;PRODUCT&quot; WHERE &quot;ID&quot; = :id AND ((&quot;GROUPOFPRODUCT&quot; = :groupofproduct) OR (&quot;GROUPOFPRODUCT&quot; IS NULL AND :groupofproduct IS NULL))" InsertCommand="INSERT INTO &quot;PRODUCT&quot; (&quot;ID&quot;, &quot;GROUPOFPRODUCT&quot;) VALUES (:id, :groupofproduct)" OldValuesParameterFormatString="original_{0}" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM &quot;PRODUCT&quot;" UpdateCommand="UPDATE &quot;PRODUCT&quot; SET &quot;GROUPOFPRODUCT&quot; = :groupofproduct WHERE &quot;ID&quot; = :ID AND ((&quot;GROUPOFPRODUCT&quot; = :groupofproduct) OR (&quot;GROUPOFPRODUCT&quot; IS NULL AND :groupofproduct IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_ID" Type="Decimal" />
                <asp:Parameter Name="original_GROUPOFPRODUCT" Type="String" />
                <asp:Parameter Name="original_GROUPOFPRODUCT" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ID" Type="Decimal" />
                <asp:Parameter Name="GROUPOFPRODUCT" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="GROUPOFPRODUCT" Type="String" />
                <asp:Parameter Name="original_ID" Type="Decimal" />
                <asp:Parameter Name="original_GROUPOFPRODUCT" Type="String" />
                <asp:Parameter Name="original_GROUPOFPRODUCT" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        Ресурси<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" ShowInsertButton="True" />
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="TYPE_" HeaderText="TYPE_" SortExpression="TYPE_" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM &quot;RESOURCES&quot; WHERE &quot;ID&quot; = ? AND ((&quot;TYPE_&quot; = ?) OR (&quot;TYPE_&quot; IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO &quot;RESOURCES&quot; (&quot;ID&quot;, &quot;TYPE_&quot;) VALUES (?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM &quot;RESOURCES&quot;" UpdateCommand="UPDATE &quot;RESOURCES&quot; SET &quot;TYPE_&quot; = ? WHERE &quot;ID&quot; = ? AND ((&quot;TYPE_&quot; = ?) OR (&quot;TYPE_&quot; IS NULL AND ? IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_ID" Type="Decimal" />
                <asp:Parameter Name="original_TYPE_" Type="String" />
                <asp:Parameter Name="original_TYPE_" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ID" Type="Decimal" />
                <asp:Parameter Name="TYPE_" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="TYPE_" Type="String" />
                <asp:Parameter Name="original_ID" Type="Decimal" />
                <asp:Parameter Name="original_TYPE_" Type="String" />
                <asp:Parameter Name="original_TYPE_" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>

</asp:Content>
