<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MediaLibrary.aspx.cs" Inherits="EF_CodeFirst.MediaLibrary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:BoundField DataField="album_id" HeaderText="album_id" SortExpression="album_id" />
                <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
                <asp:BoundField DataField="imdb_rating" HeaderText="imdb_rating" SortExpression="imdb_rating" />
                <asp:TemplateField HeaderText="track_list">
                    <ItemTemplate>
                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSource='<%# Eval("Tracks") %>'>
                            <Columns>
                                <asp:BoundField DataField="title" HeaderText="Title" />
                                <asp:BoundField DataField="artists" HeaderText="Artists" />
                            </Columns>
                        </asp:GridView>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="release_year" HeaderText="release_year" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getAllAlbums" TypeName="EF_CodeFirst.TrackLibrary"></asp:ObjectDataSource>
    
    </div>
    </form>
</body>
</html>
