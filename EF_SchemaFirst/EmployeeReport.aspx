<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeReport.aspx.cs" Inherits="EF_SchemaFirst.EmployeeReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div style="font-family: Calibri">
        <form id="form1" runat="server">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="department_id" DataSourceID="EntityDataSource1">
                <Columns>
                    <asp:BoundField DataField="department_id" HeaderText="department_id" ReadOnly="True" SortExpression="department_id" />
                    <asp:BoundField DataField="department_name" HeaderText="department_name" SortExpression="department_name" />
                    <asp:BoundField DataField="location" HeaderText="location" SortExpression="location" />
                    <asp:TemplateField HeaderText="employees">
                        <ItemTemplate>
                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSource='<%# Eval("employees") %>'>
                                <Columns>
                                    <asp:BoundField DataField="employee_name" HeaderText="employee_name" />
                                    <asp:BoundField DataField="employment_type" HeaderText="employment_type" />
                                </Columns>
                            </asp:GridView>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=sample_testContext" DefaultContainerName="sample_testContext" EnableFlattening="False" EntitySetName="departments" Include="Employees">
            </asp:EntityDataSource>

        </form>
    </div>
</body>
</html>
