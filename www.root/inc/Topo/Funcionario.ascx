﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Funcionario.ascx.cs" Inherits="inc_Topo_Funcionario" %>
<%@ Register TagPrefix="uc" TagName="Login" Src="~/inc/Login.ascx" %>
<div>
    <!-- Menu de Navegação -->
    <nav class="navbar navbar-expand-xl navbar-dark bg-dark  " role="navigation" id="menu">
        <div class=" container-fluid">
            <!-- Menu  -->
            <div class=" navbar-brand"></div>
            <button type="button" class="navbar-toggler" data-toggle="collapse" data-target=".navbar-collapse">
                <span class=" navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse">
                <ul class="navbar-nav mr-auto ">
                    <li class=" nav-item"><a class="nav-link" href="/">Home</a></li>
                    <li class=" nav-item"><a class="nav-link" href="/Funcionario/cadastrar.aspx">Conta</a></li>                    
                     <li class="nav-item dropdown">
                        <a class=" nav-link dropdown-toggle" data-toggle="dropdown" href="javascript:void(0)">Ponto</a>
                        <div class="dropdown-menu">
                            <a class="dropdown-item" href="/Ponto/Ponto.aspx">Registrar</a>   
                            <a class="dropdown-item" href="Ponto/Default.aspx">Espelho de ponto</a>                          
                        </div>
                    </li>
                     <li class="nav-item"><a class=" nav-link" href="/Contato">Mobile</a></li>
                </ul>
            <uc:login runat="server" id="ucLogin" />
            </div>
        </div>
        <!-- fim do menu-->

    </nav>
    <!-- Navbar -->
</div>
