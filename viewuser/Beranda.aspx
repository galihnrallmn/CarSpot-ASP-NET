<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Beranda.aspx.vb" Inherits="carspot.Beranda" %>

<%@ Register TagPrefix="uc" TagName="Sidebar" Src="~/viewuser/layout/Sidebar.ascx" %>
<%@ Register TagPrefix="uc" TagName="Topbar" Src="~/viewuser/layout/Topbar.ascx" %>
<%@ Register TagPrefix="uc" TagName="Footer" Src="~/viewuser/layout/Footer.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Favicon -->
    <link rel="shortcut icon" href="../../template/hopeui/assets/images/favicon.ico">

    <!-- Library / Plugin Css Build -->
    <link rel="stylesheet" href="../../template/hopeui/assets/css/core/libs.min.css">

    <!-- Aos Animation Css -->
    <link rel="stylesheet" href="../../template/hopeui/assets/vendor/aos/dist/aos.css">

    <!-- Hope Ui Design System Css -->
    <link rel="stylesheet" href="../../template/hopeui/assets/css/hope-ui.min.css?v=4.0.0">

    <!-- Custom Css -->
    <link rel="stylesheet" href="../../template/hopeui/assets/css/custom.min.css?v=4.0.0">

    <!-- Dark Css -->
    <link rel="stylesheet" href="../../template/hopeui/assets/css/dark.min.css">

    <!-- Customizer Css -->
    <link rel="stylesheet" href="../../template/hopeui/assets/css/customizer.min.css">

    <!-- RTL Css -->
    <link rel="stylesheet" href="../../template/hopeui/assets/css/rtl.min.css">

     <!-- Bootstrap CSS -->
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/5.1.3/css/bootstrap.min.css" rel="stylesheet">


    <title>Dashboard | Car Spot</title>
</head>
<body>
    <aside class="sidebar sidebar-default sidebar-white sidebar-base navs-rounded-all">
        <uc:Sidebar runat="server" />
    </aside>
    <main class="main-content">
        <uc:Topbar runat="server" />
        <form id="form1" runat="server">
            <div class="container-fluid content-inner mt-n5 py-0">
                <div class="row">
                    <div class="col-sm-12">
                        <div class="card">
                            <div class="card-header d-flex justify-content-between">
                                <div class="header-title">
                                    <h4 class="card-title">Dashboard</h4>
                                </div>
                            </div>
                            <div class="card-body">
                                <div class="row">
                                    <div class="col-lg-4 col-md-6 mb-4">
                                        <div class="card">
                                            <div class="card-body bg-primary text-white">
                                                <h5 class="card-title">Jumlah Merek</h5>
                                                <p class="card-text" id="jumlahMerek"></p>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-4 col-md-6 mb-4">
                                        <div class="card">
                                            <div class="card-body bg-success text-white">
                                                <h5 class="card-title">Jumlah Mobil</h5>
                                                <p class="card-text" id="jumlahMobil"></p>
                                                
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-lg-4 col-md-6 mb-4">
                                        <div class="card">
                                            <div class="card-body bg-danger text-white">
                                                <h5 class="card-title">Jumlah Penjualan</h5>
                                                <p class="card-text" id="jumlahPenjualan"></p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-12">
                                        <canvas id="mobilChart"></canvas>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </form>
    </main>
    <footer class="footer">
        <uc:Footer runat="server" />
    </footer>
    <script>
        document.addEventListener("DOMContentLoaded", function () {
            var jumlahMerek = '<%= jumlahMerek %>';
            var jumlahMobil = '<%= jumlahMobil %>';
            var jumlahPenjualan = '<%= jumlahPenjualan %>';

            document.getElementById('jumlahMerek').textContent = jumlahMerek;
            document.getElementById('jumlahMobil').textContent = jumlahMobil;
            document.getElementById('jumlahPenjualan').textContent = jumlahPenjualan;

            var ctx = document.getElementById('mobilChart').getContext('2d');
            var mobilData = <%= mobilData %>;
            var mobilChart = new Chart(ctx, {
                type: 'bar',
                data: mobilData,
                options: {
                    responsive: true,
                    scales: {
                        y: {
                            beginAtZero: true
                        }
                    }
                }
            });
        });
    </script>
    <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
</body>
</html>
