import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { TruncateModule } from 'ng2-truncate';

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
import { PedidoComponent } from './Pedido/cadastrar/cadastro.component';
import { PesquisaPedidoComponent } from './Pedido/pesquisa/pesquisa.component';
import { LojaPesquisaComponent } from './loja/pesquisa/loja.pesquisa.component';
import { LojaPedidoComponent } from './loja/Pedido/loja.pedido.component';
import { LojaEfetivarComponent } from './loja/efetivar/loja.efetivar.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    ClienteComponent,
    LoginComponent,
    CadastroClienteComponent,
    LoginEmpresaComponent,
    PedidoComponent,
    PesquisaPedidoComponent,
    LojaPesquisaComponent,
    LojaPedidoComponent,
    LojaEfetivarComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    TruncateModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'cliente', component: ClienteComponent },
      { path: 'entrar', component: LoginComponent },
      { path: "cadastrar", component: CadastroClienteComponent },
      { path: "login-empresa", component: LoginEmpresaComponent },
      { path: "cadastro-pedido", component: PedidoComponent },
      { path: "pesquisar-pedido", component: PesquisaPedidoComponent },
      { path: "loja-pedido", component: LojaPedidoComponent },
      { path: "loja-efetivar", component: LojaEfetivarComponent }

    ])
  ],
  providers: [ClienteServico, EmpresaServico, PedidoServico],
  bootstrap: [AppComponent]
})
export class AppModule { }

//{ path: 'cliente', component: ClienteComponent, canActivate: [GuardaRotas] },
