import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ClienteServico } from '../serviços/cliente/cliente.servico';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  constructor(private router: Router, private clienteServico: ClienteServico) {

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
  sair() {
    this.clienteServico.limpar_sessao();
    this.router.navigate(['/']);
  }
}
