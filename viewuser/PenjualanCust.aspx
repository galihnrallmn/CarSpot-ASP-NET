﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PenjualanCust.aspx.vb" Inherits="carspot.PenjualanCust" %>

<%@ Register TagPrefix="uc" TagName="Sidebar" Src="~/viewuser/layout/Sidebar.ascx" %>
<%@ Register TagPrefix="uc" TagName="Topbar" Src="~/viewuser/layout/Topbar.ascx" %>
<%@ Register TagPrefix="uc" TagName="Footer" Src="~/viewuser/layout/Footer.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Favicon -->
    <link rel="shortcut icon" href="../template/hopeui/assets/images/favicon.ico">

    <!-- Library / Plugin Css Build -->
    <link rel="stylesheet" href="../template/hopeui/assets/css/core/libs.min.css">

    <!-- Aos Animation Css -->
    <link rel="stylesheet" href="../template/hopeui/assets/vendor/aos/dist/aos.css">

    <!-- Hope Ui Design System Css -->
    <link rel="stylesheet" href="../template/hopeui/assets/css/hope-ui.min.css?v=4.0.0">

    <!-- Custom Css -->
    <link rel="stylesheet" href="../template/hopeui/assets/css/custom.min.css?v=4.0.0">

    <!-- Dark Css -->
    <link rel="stylesheet" href="../template/hopeui/assets/css/dark.min.css">

    <!-- Customizer Css -->
    <link rel="stylesheet" href="../template/hopeui/assets/css/customizer.min.css">

    <!-- RTL Css -->
    <link rel="stylesheet" href="../template/hopeui/assets/css/rtl.min.css">

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

    <title>Penjualan | Car Spot</title>
</head>
<body>
    <aside class="sidebar sidebar-default sidebar-white sidebar-base navs-rounded-all ">
    <uc:Sidebar runat="server" />
</aside>
<main class="main-content">
    <uc:Topbar runat="server" />
    
    <br/>
    <br/>
    <form id="form1" runat="server">
    <div class="container-fluid content-inner mt-n5 py-0">
    <div class="row">
        <div class="col-sm-12">
            <div class="card">
                <div class="card-header d-flex justify-content-between">
                    <div class="header-title">
                        <h4 class="card-title">Pembelian</h4>
                        <br/>
                    </div>
                </div>
                <div class="card-body">
                    <div class="table-responsive">
                        <asp:Table ID="TblPenjualan" runat="server" utoGenerateColumns="True" CssClass="table table-striped" BorderStyle="Solid" BorderWidth="2px" CellPadding="10" CellSpacing="3" GridLines="Both">
                            </asp:Table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
    </form>

    <footer class="footer">
    <uc:Footer runat="server" />
</div>

</body>

</html>
