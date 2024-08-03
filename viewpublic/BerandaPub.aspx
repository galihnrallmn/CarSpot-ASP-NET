<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="BerandaPub.aspx.vb" Inherits="carspot.BerandaPub" %>

<%@ Register TagPrefix="uc" TagName="Header" Src="~/viewpublic/Header.ascx" %>
<%@ Register TagPrefix="uc" TagName="Footer" Src="~/viewpublic/Footer.ascx" %>



        <form runat="server">
        <uc:Header runat="server" />
        <!-- Bagian Hero Mulai -->
<div class="hero-section">
    <div class="container">
        <div class="row align-items-center">
            <div class="col-lg-6">
                <h1 class="display-4 mb-4">Temukan Mobil Impian Anda dengan Car Spot</h1>
                <p class="lead mb-4">Temukan berbagai macam mobil yang tersedia untuk dijual atau disewa. Mulai dari sedan mewah hingga SUV tangguh, kami memiliki semua yang Anda butuhkan.</p>
                <a href="#" class="btn btn-primary btn-lg me-3">Jelajahi Sekarang</a>
                <a href="#" class="btn btn-outline-primary btn-lg">Pelajari Lebih Lanjut</a>
            </div>
        </div>
    </div>
</div>
<!-- Bagian Hero Selesai -->
            
    <uc:Footer runat="server" />
</form>
