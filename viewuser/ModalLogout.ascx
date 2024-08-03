<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ModalLogout.ascx.vb" Inherits="carspot.ModalLogout" %>

 <!-- Logout Modal -->
<div class="modal fade" id="ModalLogout" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="ModalLogoutLabel" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="ModalLogoutLabel">Konfirmasi Logout</h5>
                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
            </div>
            <div class="modal-body">
                <p>Apakah Anda yakin ingin logout?</p>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Tidak</button>
                <a href="Logout.aspx" class="btn btn-danger">Ya</a>
            </div>
        </div>
    </div>
</div>