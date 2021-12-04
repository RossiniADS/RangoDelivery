import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LojaCarrinho } from '../loja/carrinho/loja.carrinho.component';
import { ClienteServico } from '../serviços/cliente/cliente.servico';
import { EmpresaServico } from '../serviços/empresa/empresa.servico';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {
  isExpanded = false;
  public carrinhoCompras: LojaCarrinho;

  constructor(private router: Router, private clienteServico: ClienteServico,
    private empresaServico: EmpresaServico) {

  }
  ngOnInit(): void {
    this.carrinhoCompras = new LojaCarrinho();
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  public clienteLogado(): boolean {
    return this.clienteServico.cliente_autenticado();
  }
  public cliente_administrador(): boolean {
    return this.clienteServico.cliente_administrador();
  }

  public empresaLogado(): boolean {
    return this.empresaServico.empresa_autenticado();
  }

  sair() {
    if (this.clienteLogado()) {
      this.clienteServico.limpar_sessao();
    } else {
      this.empresaServico.limpar_sessao();
    }
    this.router.navigate(['/']);
  }
  get cliente() {
    return this.clienteServico.cliente;
  }

  public hasItemCarrinhoCompras(): boolean {
    return this.carrinhoCompras.hasItemCarrinhoCompras();
  }
}
