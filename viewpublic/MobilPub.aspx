<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="MobilPub.aspx.vb" Inherits="carspot.MobilPub" %>


<%@ Register TagPrefix="uc" TagName="Header" Src="~/viewpublic/Header.ascx" %>
<%@ Register TagPrefix="uc" TagName="Footer" Src="~/viewpublic/Footer.ascx" %>

<form runat="server">
<uc:Header runat="server" />
<div class="hero-section">
    <div class="container">
        <div class="row align-items-center">
            <div class="row">
                <div class="col-lg-12">
                    <h2>Daftar Mobil</h2>
                    <div class="table-responsive">
    <asp:Table ID="TblMobil" runat="server" AutoGenerateColumns="False" CssClass="table table-striped" BorderStyle="Solid" BorderWidth="2px" CellPadding="10" CellSpacing="3" GridLines="Both">
    </asp:Table>
</div>
                </div>
            </div>
        </div>
    </div>
</div>
    
<uc:Footer runat="server" />
</form>

