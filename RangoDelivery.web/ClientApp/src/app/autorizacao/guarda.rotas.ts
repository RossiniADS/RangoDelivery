import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Route } from "@angular/router";
import { ClienteServico } from "../serviços/cliente/cliente.servico";

@Injectable({
  providedIn: 'root'              //fornecido em... na raiz!
})
export class GuardaRotas implements CanActivate {

  constructor(private router: Router, private clienteServico: ClienteServico) {

  }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {

    //var autenticado = sessionStorage.getItem("cliente-autenticado");

    if (this.clienteServico.cliente_autenticado()) {
      return true;
    }
    this.router.navigate(['/entrar'], { queryParams: { returnUrl: state.url } });
    return false;
  }

}
