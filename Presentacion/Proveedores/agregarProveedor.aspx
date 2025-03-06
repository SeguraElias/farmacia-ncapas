<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agregarProveedor.aspx.cs" Inherits="Presentacion.Proveedores.agregarProveedor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Agregar proveedor</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card m-auto mt-5 p-4" style="width:800px;">
                <div class="row">
                    <div class="col-md-5">
                        <h3>Agregar proveedor</h3>
                    </div>
                </div>
                <div class="row justify-content-center mt-3">
                    <div class="col-md-3">
                        <label>Nombre:</label>
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label>Telefono:</label>
                        <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label>Correo:</label>
                        <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="row mt-3 justify-content-center">
                    <div class="col-md-6">
                        <label>Direccion:</label>
                        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </div>
                <div class="row mt-3 justify-content-center">
                    <div class="col-md-2">
                        <asp:LinkButton runat="server" ID="btnCancelar" CssClass="btn btn-danger" OnClick="btnCancelar_Click">
                            Cancelar<i class="bi bi-x-circle"></i>
                        </asp:LinkButton>
                    </div>
                     <div class="col-md-2">
                         <asp:LinkButton runat="server" ID="btnGuardar" CssClass="btn btn-success" OnClick="LinkButton1_Click">
                             Guardar<i class="bi bi-plus-circle"></i>
                         </asp:LinkButton>
                     </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
