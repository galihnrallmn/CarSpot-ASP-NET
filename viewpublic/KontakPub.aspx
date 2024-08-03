<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="KontakPub.aspx.vb" Inherits="carspot.KontakPub" %>

<%@ Register TagPrefix="uc" TagName="Header" Src="~/viewpublic/Header.ascx" %>
<%@ Register TagPrefix="uc" TagName="Footer" Src="~/viewpublic/Footer.ascx" %>

        <form runat="server">
        <uc:Header runat="server" />
        <!-- Contact Section Start -->
    <div class="container-fluid py-5">
        <div class="container">
            <div class="text-center">
                <h1 class="mb-4">Hubungi Kami</h1>
            </div>
            <div class="row g-5">
                <div class="col-lg-6">
                    <h5>Hubungi Kami</h5>
                    <p>Jika Anda memiliki pertanyaan atau membutuhkan informasi lebih lanjut, jangan ragu untuk menghubungi kami.</p>
                    <div class="d-flex mb-4">
                        <div class="flex-shrink-0 btn-square bg-primary rounded-circle">
                            <i class="fas fa-map-marker-alt text-white"></i>
                        </div>
                        <div class="ms-3">
                            <h6>Alamat</h6>
                            <p>Jl. Ahmad Yani No.Km.06, Pemuda, Kec. Pelaihari, Kabupaten Tanah Laut, Kalimantan Selatan 70815</p>
                        </div>
                    </div>
                    <div class="d-flex mb-4">
                        <div class="flex-shrink-0 btn-square bg-primary rounded-circle">
                            <i class="fas fa-phone text-white"></i>
                        </div>
                        <div class="ms-3">
                            <h6>Telepon</h6>
                            <p>+628 1290 9876</p>
                        </div>
                    </div>
                    <div class="d-flex mb-4">
                        <div class="flex-shrink-0 btn-square bg-primary rounded-circle">
                            <i class="fas fa-envelope text-white"></i>
                        </div>
                        <div class="ms-3">
                            <h6>Email</h6>
                            <p>CarSpot@gmail.com</p>
                        </div>
                    </div>
                </div>
                <div class="col-lg-6">
                    <h5>Kirim Pesan</h5>
                    <form>
                        <div class="row g-3">
                            <div class="col-md-6">
                                <input type="text" class="form-control" placeholder="Nama Anda" required>
                            </div>
                            <div class="col-md-6">
                                <input type="email" class="form-control" placeholder="Email Anda" required>
                            </div>
                            <div class="col-12">
                                <input type="text" class="form-control" placeholder="Subjek" required>
                            </div>
                            <div class="col-12">
                                <textarea class="form-control" rows="5" placeholder="Pesan" required></textarea>
                            </div>
                            <div class="col-12">
                                <button class="btn btn-primary w-100 py-3" type="submit">Kirim Pesan</button>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
    <!-- Contact Section End -->
            
    <uc:Footer runat="server" />
</form>
