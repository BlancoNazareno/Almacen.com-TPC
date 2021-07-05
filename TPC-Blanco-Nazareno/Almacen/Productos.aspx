<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Almacen.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <div class="container">


        <%
            if (ListaProductos != null)
            {%>
        <%foreach (Dominio.Producto item in ListaProductos)
            {%>
         <div class="row">
            <div class="col-sm">
               item.ID
            </div>
            <div class="col-sm">
               item.Descripcion
            </div>
             <div class="col-sm">
               item.Marca.ID
            </div>
              <div class="col-sm">
               item.Proveedor.ID
            </div>
              <div class="col-sm">
               item.PrecioCompra
            </div>
              <div class="col-sm">
               item.PrecioVenta
            </div>
              <div class="col-sm">
               item.StockMinimo
            </div>
        </div>
        <%}%>
        <%}%>
    </div>
</asp:Content>
