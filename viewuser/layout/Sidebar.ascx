<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="Sidebar.ascx.vb" Inherits="carspot.Sidebar" %>

<div class="sidebar-header d-flex align-items-center justify-content-start">
    <a href="#" class="navbar-brand">

        <!--Logo start-->
        <div class="logo-main">
            <div class="logo-normal">
                <svg class=" icon-30" viewBox="0 0 30 30" fill="none" xmlns="http://www.w3.org/2000/svg">
                    <rect x="-0.757324" y="19.2427" width="28" height="4" rx="2" transform="rotate(-45 -0.757324 19.2427)" fill="currentColor" />
                    <rect x="7.72803" y="27.728" width="28" height="4" rx="2" transform="rotate(-45 7.72803 27.728)" fill="currentColor" />
                    <rect x="10.5366" y="16.3945" width="16" height="4" rx="2" transform="rotate(45 10.5366 16.3945)" fill="currentColor" />
                    <rect x="10.5562" y="-0.556152" width="28" height="4" rx="2" transform="rotate(45 10.5562 -0.556152)" fill="currentColor" />
                </svg>
            </div>
            <div class="logo-mini">
                <svg class=" icon-30" viewBox="0 0 30 30" fill="none" xmlns="http://www.w3.org/2000/svg">
                    <rect x="-0.757324" y="19.2427" width="28" height="4" rx="2" transform="rotate(-45 -0.757324 19.2427)" fill="currentColor" />
                    <rect x="7.72803" y="27.728" width="28" height="4" rx="2" transform="rotate(-45 7.72803 27.728)" fill="currentColor" />
                    <rect x="10.5366" y="16.3945" width="16" height="4" rx="2" transform="rotate(45 10.5366 16.3945)" fill="currentColor" />
                    <rect x="10.5562" y="-0.556152" width="28" height="4" rx="2" transform="rotate(45 10.5562 -0.556152)" fill="currentColor" />
                </svg>
            </div>
        </div>
        <!--logo End-->




        <h6 class="logo-title">Car Spot</h6>
    </a>
    <div class="sidebar-toggle" data-toggle="sidebar" data-active="true">
        <i class="icon">
            <svg width="20" height="20" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
                <path d="M4.25 12.2744L19.25 12.2744" stroke="currentColor" stroke-width="1.5" stroke-linecap="round" stroke-linejoin="round"></path>
                <path d="M10.2998 18.2988L4.2498 12.2748L10.2998 6.24976" stroke="currentColor" stroke-width="1.5" stroke-linecap="round" stroke-linejoin="round"></path>
            </svg>
        </i>
    </div>
</div>
<div class="sidebar-body pt-0 data-scrollbar">
    <div class="sidebar-list">
        <!-- Sidebar Menu Start -->
        <ul class="navbar-nav iq-main-menu" id="sidebar-menu">
            <% 
                Dim level As String = Session("level")
                Dim home As String
                If level = "customer" Then
                    home = "../PenjualanCust.aspx"
                Else
                    home = "../Beranda.aspx"
                End If
%>
            <% If level = "admin" Then%>

            <li class="nav-item static-item">
                <a class="nav-link static-item disabled" href="#" tabindex="-1">
                    <span class="default-icon">Home</span>
                    <span class="mini-icon">-</span>
                </a>
            </li>
            <!-- <li class="nav-item">
                <a class="nav-link <?= $menu == 'dashboard' ? 'active' : '' ?>" aria-current="page" href="<?= base_url('/') ?>">
                    <i class="icon">
                        <svg width="20" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg" class="icon-20">
                            <path opacity="0.4" d="M16.0756 2H19.4616C20.8639 2 22.0001 3.14585 22.0001 4.55996V7.97452C22.0001 9.38864 20.8639 10.5345 19.4616 10.5345H16.0756C14.6734 10.5345 13.5371 9.38864 13.5371 7.97452V4.55996C13.5371 3.14585 14.6734 2 16.0756 2Z" fill="currentColor"></path>
                            <path fill-rule="evenodd" clip-rule="evenodd" d="M4.53852 2H7.92449C9.32676 2 10.463 3.14585 10.463 4.55996V7.97452C10.463 9.38864 9.32676 10.5345 7.92449 10.5345H4.53852C3.13626 10.5345 2 9.38864 2 7.97452V4.55996C2 3.14585 3.13626 2 4.53852 2ZM4.53852 13.4655H7.92449C9.32676 13.4655 10.463 14.6114 10.463 16.0255V19.44C10.463 20.8532 9.32676 22 7.92449 22H4.53852C3.13626 22 2 20.8532 2 19.44V16.0255C2 14.6114 3.13626 13.4655 4.53852 13.4655ZM19.4615 13.4655H16.0755C14.6732 13.4655 13.537 14.6114 13.537 16.0255V19.44C13.537 20.8532 14.6732 22 16.0755 22H19.4615C20.8637 22 22 20.8532 22 19.44V16.0255C22 14.6114 20.8637 13.4655 19.4615 13.4655Z" fill="currentColor"></path>
                        </svg>
                    </i>
                    <span class="item-name">Dashboard</span>
                </a>
            </li> -->
            <li class="nav-item">
                <a class="nav-link" aria-current="page" href="../viewuser/Beranda.aspx">
                    <i class="icon">
                        <svg width="20" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg" class="icon-20">
                                    <path opacity="0.4" d="M16.0756 2H19.4616C20.8639 2 22.0001 3.14585 22.0001 4.55996V7.97452C22.0001 9.38864 20.8639 10.5345 19.4616 10.5345H16.0756C14.6734 10.5345 13.5371 9.38864 13.5371 7.97452V4.55996C13.5371 3.14585 14.6734 2 16.0756 2Z" fill="currentColor"></path>
                                    <path fill-rule="evenodd" clip-rule="evenodd" d="M4.53852 2H7.92449C9.32676 2 10.463 3.14585 10.463 4.55996V7.97452C10.463 9.38864 9.32676 10.5345 7.92449 10.5345H4.53852C3.13626 10.5345 2 9.38864 2 7.97452V4.55996C2 3.14585 3.13626 2 4.53852 2ZM4.53852 13.4655H7.92449C9.32676 13.4655 10.463 14.6114 10.463 16.0255V19.44C10.463 20.8532 9.32676 22 7.92449 22H4.53852C3.13626 22 2 20.8532 2 19.44V16.0255C2 14.6114 3.13626 13.4655 4.53852 13.4655ZM19.4615 13.4655H16.0755C14.6732 13.4655 13.537 14.6114 13.537 16.0255V19.44C13.537 20.8532 14.6732 22 16.0755 22H19.4615C20.8637 22 22 20.8532 22 19.44V16.0255C22 14.6114 20.8637 13.4655 19.4615 13.4655Z" fill="currentColor"></path>
                                </svg>
                    </i>
                    <span class="item-name">Dashboard</span>
                </a>
            </li>
            <li class="nav-item static-item">
    <a class="nav-link static-item disabled" href="#" tabindex="-1">
        <span class="default-icon">Data Master</span>
        <span class="mini-icon">-</span>
    </a>
</li>
            <li class="nav-item">
                <a class="nav-link" aria-current="page" href="../viewuser/Merek.aspx">
                    <i class="icon">
                        <svg class="icon-20" width="20" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
                            <path fill-rule="evenodd" clip-rule="evenodd" d="M7.81 2H16.191C19.28 2 21 3.78 21 6.83V17.16C21 20.26 19.28 22 16.191 22H7.81C4.77 22 3 20.26 3 17.16V6.83C3 3.78 4.77 2 7.81 2ZM8.08 6.66V6.65H11.069C11.5 6.65 11.85 7 11.85 7.429C11.85 7.87 11.5 8.22 11.069 8.22H8.08C7.649 8.22 7.3 7.87 7.3 7.44C7.3 7.01 7.649 6.66 8.08 6.66ZM8.08 12.74H15.92C16.35 12.74 16.7 12.39 16.7 11.96C16.7 11.53 16.35 11.179 15.92 11.179H8.08C7.649 11.179 7.3 11.53 7.3 11.96C7.3 12.39 7.649 12.74 8.08 12.74ZM8.08 17.31H15.92C16.319 17.27 16.62 16.929 16.62 16.53C16.62 16.12 16.319 15.78 15.92 15.74H8.08C7.78 15.71 7.49 15.85 7.33 16.11C7.17 16.36 7.17 16.69 7.33 16.95C7.49 17.2 7.78 17.35 8.08 17.31Z" fill="currentColor"></path>
                        </svg>
                    </i>
                    <span class="item-name">Merek</span>
                </a>
            </li>
            <li class="nav-item">
                <a class="nav-link" aria-current="page" href="../viewuser/Mobil.aspx">
                    <i class="icon">
                        <svg class="icon-20" width="20" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
                            <path fill-rule="evenodd" clip-rule="evenodd" d="M7.81 2H16.191C19.28 2 21 3.78 21 6.83V17.16C21 20.26 19.28 22 16.191 22H7.81C4.77 22 3 20.26 3 17.16V6.83C3 3.78 4.77 2 7.81 2ZM8.08 6.66V6.65H11.069C11.5 6.65 11.85 7 11.85 7.429C11.85 7.87 11.5 8.22 11.069 8.22H8.08C7.649 8.22 7.3 7.87 7.3 7.44C7.3 7.01 7.649 6.66 8.08 6.66ZM8.08 12.74H15.92C16.35 12.74 16.7 12.39 16.7 11.96C16.7 11.53 16.35 11.179 15.92 11.179H8.08C7.649 11.179 7.3 11.53 7.3 11.96C7.3 12.39 7.649 12.74 8.08 12.74ZM8.08 17.31H15.92C16.319 17.27 16.62 16.929 16.62 16.53C16.62 16.12 16.319 15.78 15.92 15.74H8.08C7.78 15.71 7.49 15.85 7.33 16.11C7.17 16.36 7.17 16.69 7.33 16.95C7.49 17.2 7.78 17.35 8.08 17.31Z" fill="currentColor"></path>
                        </svg>
                    </i>
                    <span class="item-name">Mobil</span>
                </a>
            </li>
                        <li class="nav-item static-item">
    <a class="nav-link static-item disabled" href="#" tabindex="-1">
        <span class="default-icon">Data Penjualan</span>
        <span class="mini-icon">-</span>
    </a>
</li>
            <li class="nav-item">
                <a class="nav-link" aria-current="page" href="../viewuser/Penjualan.aspx">
                    <i class="icon">
                        <svg class="icon-20" width="20" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
                            <path fill-rule="evenodd" clip-rule="evenodd" d="M7.81 2H16.191C19.28 2 21 3.78 21 6.83V17.16C21 20.26 19.28 22 16.191 22H7.81C4.77 22 3 20.26 3 17.16V6.83C3 3.78 4.77 2 7.81 2ZM8.08 6.66V6.65H11.069C11.5 6.65 11.85 7 11.85 7.429C11.85 7.87 11.5 8.22 11.069 8.22H8.08C7.649 8.22 7.3 7.87 7.3 7.44C7.3 7.01 7.649 6.66 8.08 6.66ZM8.08 12.74H15.92C16.35 12.74 16.7 12.39 16.7 11.96C16.7 11.53 16.35 11.179 15.92 11.179H8.08C7.649 11.179 7.3 11.53 7.3 11.96C7.3 12.39 7.649 12.74 8.08 12.74ZM8.08 17.31H15.92C16.319 17.27 16.62 16.929 16.62 16.53C16.62 16.12 16.319 15.78 15.92 15.74H8.08C7.78 15.71 7.49 15.85 7.33 16.11C7.17 16.36 7.17 16.69 7.33 16.95C7.49 17.2 7.78 17.35 8.08 17.31Z" fill="currentColor"></path>
                        </svg>
                    </i>
                    <span class="item-name">Penjualan</span>
                </a>
            </li>
            <% End If %>
           
            <% If level = "customer" Then%>
                                    <li class="nav-item static-item">
    <a class="nav-link static-item disabled" href="#" tabindex="-1">
        <span class="default-icon">Data Pembelian</span>
        <span class="mini-icon">-</span>
    </a>
</li>
            <li class="nav-item">
                <a class="nav-link" aria-current="page" href="../viewuser/PenjualanCust.aspx">
                    <i class="icon">
                        <svg class="icon-20" width="20" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
                            <path fill-rule="evenodd" clip-rule="evenodd" d="M7.81 2H16.191C19.28 2 21 3.78 21 6.83V17.16C21 20.26 19.28 22 16.191 22H7.81C4.77 22 3 20.26 3 17.16V6.83C3 3.78 4.77 2 7.81 2ZM8.08 6.66V6.65H11.069C11.5 6.65 11.85 7 11.85 7.429C11.85 7.87 11.5 8.22 11.069 8.22H8.08C7.649 8.22 7.3 7.87 7.3 7.44C7.3 7.01 7.649 6.66 8.08 6.66ZM8.08 12.74H15.92C16.35 12.74 16.7 12.39 16.7 11.96C16.7 11.53 16.35 11.179 15.92 11.179H8.08C7.649 11.179 7.3 11.53 7.3 11.96C7.3 12.39 7.649 12.74 8.08 12.74ZM8.08 17.31H15.92C16.319 17.27 16.62 16.929 16.62 16.53C16.62 16.12 16.319 15.78 15.92 15.74H8.08C7.78 15.71 7.49 15.85 7.33 16.11C7.17 16.36 7.17 16.69 7.33 16.95C7.49 17.2 7.78 17.35 8.08 17.31Z" fill="currentColor"></path>
                        </svg>
                    </i>
                    <span class="item-name">Pembelian</span>
                </a>
            </li>
            <% End If %>

            <ul class="sub-nav collapse" id="sidebar-special" data-bs-parent="#sidebar-menu">
                <li class="nav-item">
                    <a class="nav-link " href="../template/hopeui/dashboard/special-pages/billing.html">
                        <i class="icon">
                            <svg class="icon-10" xmlns="http://www.w3.org/2000/svg" width="10" viewBox="0 0 24 24" fill="currentColor">
                                <g>
                                    <circle cx="12" cy="12" r="8" fill="currentColor"></circle>
                                </g>
                            </svg>
                        </i>
                        <i class="sidenav-mini-icon"> B </i>
                        <span class="item-name">Billing</span>
                    </a>
                </li>
                <li class="nav-item">
                    <a class="nav-link " href="../template/hopeui/dashboard/special-pages/calender.html">
                        <i class="icon">
                            <svg class="icon-10" xmlns="http://www.w3.org/2000/svg" width="10" viewBox="0 0 24 24" fill="currentColor">
                                <g>
                                    <circle cx="12" cy="12" r="8" fill="currentColor"></circle>
                                </g>
                            </svg>
                        </i>
                        <i class="sidenav-mini-icon"> C </i>
                        <span class="item-name">Calender</span>
                    </a>
                </li>
            </ul>
            </li>
        </ul>
        <!-- Sidebar Menu End -->
    </div>
</div>
<div class="sidebar-footer"></div>
