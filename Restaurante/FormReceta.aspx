<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormReceta.aspx.cs" Inherits="Restaurante.FormReceta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="lblFormularioR" runat="server" Text="Formualari de receta"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="lblFuente" runat="server" Text="Fuente de la receta"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFuenteRec" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblUbicacionFisica" runat="server" Text="Ubicación fisica"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUbicacionFisica" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblListaIng" runat="server" Text="Lista de ingredientes"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtListaIng" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblTiempEjec" runat="server" Text="Tiempo total de ejecución"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTiempoEjec" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblUtensilio" runat="server" Text="Utensilios"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUtensilios" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblComentario" runat="server" Text="Comentarios"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtComentarios" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblTiempoPre" runat="server" Text="Tiempo de preparación"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTiempoPrep" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
