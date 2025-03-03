<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Presentacion.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card m-auto mt-5" style="width: 300px">
                <div class="card-title justify-content-center">
                    <h2 class="mt-3 ms-5">Iniciar sesion</h2>
                </div>
                <div class="card-body">
                    <div class="row">
                        <div class="col">
                            <asp:TextBox ID="txtUser" runat="server" CssClass="form-control" placeholder="Usuario"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row mt-2">
                        <div class="col">
                            <asp:TextBox ID="txtPass" runat="server" CssClass="form-control" Text="Password" placeholder="Password" TextMode="Password"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row mt-2 justify-content-center">
                        <div class="col-6">
                            <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-info" Text="Iniciar Sesion" OnClick="btnLogin_Click"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
