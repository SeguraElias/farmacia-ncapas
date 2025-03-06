<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Presentacion.Proveedores.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Proveedores</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card p-3 mt-5">
                <div class="row justify-content-between">
                    <div class="col-md-3">
                        <h3 class="mt-3">Proveedores</h3>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3">
                        <asp:LinkButton ID="btnAgregar" runat="server" CssClass="btn btn-success mt-3" OnClick="btnAgregar_Click">
                            Agregar <i class="bi bi-plus-circle"></i>
                        </asp:LinkButton>
                    </div>
                </div>
                <asp:GridView ID="gvProveedores" runat="server" AutoGenerateColumns="false" CssClass="table table-striped mt-3" OnRowCommand="gvProveedores_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="ID"/>
                        <asp:BoundField DataField="nombre" HeaderText="Nombre"/>
                        <asp:BoundField DataField="telefono" HeaderText="Telefono"/>
                        <asp:BoundField DataField="correo" HeaderText="Correo"/>

                        <asp:TemplateField HeaderText="Acciones">
                            <ItemTemplate>
                                <asp:LinkButton ID="btnActualizar" runat="server" Text="" CssClass="btn btn-primary" CommandName="Actualizar" CommandArgument='<%# Eval("id") %>'>
                                    <i class="bi bi-pencil"></i>
                                </asp:LinkButton> 
                                <asp:LinkButton ID="btnEliminar" runat="server" Text="" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("id") %>' OnClientClick="return confirm('Seguro que deseas eliminar este registro?')">
                                    <i class="bi bi-trash"></i>
                                </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
