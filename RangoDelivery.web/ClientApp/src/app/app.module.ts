import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { ClienteComponent } from './Cliente/cliente.component';
import { LoginComponent } from './Login/login.component';
import { LoginEmpresaComponent } from './LoginEmpresa/login.empresa.component';
import { GuardaRotas } from './autorizacao/guarda.rotas';
import { ClienteServico } from './serviços/cliente/cliente.servico';
import { EmpresaServico } from './serviços/empresa/empresa.servico';
import { CadastroClienteComponent } from './Cadastro/cadastro.component';
import { PedidoServico } from './serviços/Pedido/pedido.servico';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    ClienteComponent,
    LoginComponent,
    CadastroClienteComponent,
    LoginEmpresaComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'cliente', component: ClienteComponent },
      { path: 'entrar', component: LoginComponent },
      { path: "cadastrar", component: CadastroClienteComponent },
      { path: "login-empresa", component: LoginEmpresaComponent }
    ])
  ],
  providers: [ClienteServico, EmpresaServico, PedidoServico],
  bootstrap: [AppComponent]
})
export class AppModule { }

//{ path: 'cliente', component: ClienteComponent, canActivate: [GuardaRotas] },
