<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="carspot.Login" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Car Spot - Login</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet">
    <style>
        body {
            background-image: linear-gradient(to bottom, #81C408, #f0f0f0);
            height: 100vh;
            display: flex;
            justify-content: center;
            align-items: center;
            margin: 0;
        }
        .login-container {
            max-width: 900px;
            padding: 20px;
            background-color: #fff;
            border: 1px solid #ddd;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        .login-header {
            text-align: center;
            margin-bottom: 20px;
        }
        .login-header h2 {
            font-weight: bold;
            color: #333;
        }
        .btn-login {
            background-color: #81C408;
            color: #fff;
            border: none;
        }
        .btn-login:hover {
            background-color: #6c9c04;
        }
        .btn-batal {
            background-color: #ccc;
            color: #333;
            border: none;
        }
        .btn-batal:hover {
            background-color: #bbb;
        }
    </style>
</head>
<body>
    <div class="login-container">
        <div class="login-header">
            <h2>Car Spot - Login</h2>
        </div>
        <form id="form1" runat="server">
            <div class="mb-3">
                <label for="TxtUsername" class="form-label">Username</label>
                <asp:TextBox ID="TxtUsername" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="TxtPassword" class="form-label">Password</label>
                <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="d-grid gap-2">
                <asp:Button ID="BtnLogin" runat="server" Text="Login" CssClass="btn btn-login btn-block" />
                <asp:Button ID="BtnBatal" runat="server" Text="Batal" CssClass="btn btn-batal btn-block" />
            </div>
        </form>
    </div>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/5.0.2/js/bootstrap.min.js"></script>
</body>
</html>
