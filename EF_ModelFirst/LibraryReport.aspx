<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LibraryReport.aspx.cs" Inherits="EF_ModelFirst.LibraryReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family:Calibri">
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="StudentID" DataSourceID="EntityDataSource1">
            <Columns>
                <asp:BoundField DataField="StudentID" HeaderText="StudentID" ReadOnly="True" SortExpression="StudentID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Discipline" HeaderText="Discipline" SortExpression="Discipline" />
                <asp:BoundField DataField="AdmissionYear" HeaderText="AdmissionYear" SortExpression="AdmissionYear" />
                <asp:TemplateField HeaderText="Books">
                    <ItemTemplate>
                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSource='<%# Eval("Books") %>'>
                            <Columns>
                                <asp:BoundField DataField="Title" HeaderText="Title" />
                                <asp:BoundField DataField="Author" HeaderText="Author" />
                                <asp:BoundField DataField="Publisher" HeaderText="Publisher" />
                            </Columns>
                        </asp:GridView>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=CustomModelContainer" DefaultContainerName="CustomModelContainer" EnableFlattening="False" EntitySetName="Students" Include="Books">
        </asp:EntityDataSource>
    
    </div>
    </form>
</body>
</html>
