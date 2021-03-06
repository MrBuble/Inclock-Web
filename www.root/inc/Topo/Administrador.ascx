﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Administrador.ascx.cs" Inherits="inc_Topo_Administrador" %>
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
                    <li class=" nav-item"><a class="nav-link" href="/Logout">Acessos</a></li>
                    <li class="nav-item dropdown">
                        <a class=" nav-link dropdown-toggle" data-toggle="dropdown" href="/Funcionario">Funcionarios</a>
                        <div class="dropdown-menu">
                            <a class="dropdown-item" href="/Funcionario/cadastrar.aspx">Cadastrar</a>
                            <a class="dropdown-item" href="/Funcionario">Listar</a>
                        </div>
                    </li>
                    <li class="nav-item dropdown">
                        <a class=" nav-link dropdown-toggle" data-toggle="dropdown" href="javascript:void(0)">Relatorios</a>
                        <div class="dropdown-menu">
                            <a class="dropdown-item" href="/Relatorios">Graficos</a>
                            <a class="dropdown-item" href="/Relatorios/Funcionario.aspx">Pontos</a>
                        </div>
                    </li>
                    <li class="nav-item dropdown">
                        <a class=" nav-link dropdown-toggle" data-toggle="dropdown" href="javascript:void(0)">Ponto</a>
                        <div class="dropdown-menu">
                            <a class="dropdown-item" href="/Ponto/Ponto.aspx">Registrar</a>
                            <a class="dropdown-item" href="Ponto/Default.aspx">Espelho de ponto</a>
                        </div>
                    </li>
                    <li class="nav-item"><a class="nav-link" href="/avisos">Avisos</a></li>

                </ul>
                <uc:Login runat="server" ID="ucLogin" />
            </div>
        </div>
        <!-- fim do menu-->

    </nav>
    <!-- Navbar -->
</div>
