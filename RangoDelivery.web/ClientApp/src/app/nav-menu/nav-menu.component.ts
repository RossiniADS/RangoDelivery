import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ClienteServico } from '../serviços/cliente/cliente.servico';
import { EmpresaServico } from '../serviços/empresa/empresa.servico';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  constructor(private router: Router, private clienteServico: ClienteServico,
    private empresaServico: EmpresaServico) {

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
}
