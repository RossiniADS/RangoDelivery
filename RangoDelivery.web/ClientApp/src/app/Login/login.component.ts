import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { Cliente } from "../model/cliente";
import { ClienteServico } from "../serviços/cliente/cliente.servico";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"] //[] pq é como se fosse lista
})
export class LoginComponent implements OnInit {
  public cliente;
  public empresa;
  public usuarioAutenticado: boolean;
  public returnUrl: string;
  public mensagem: string;
  private ativar_spinner: boolean;

  constructor(private router: Router, private activatedRouter: ActivatedRoute,
    private clienteServico: ClienteServico) {

  }

  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.cliente = new Cliente();
  }

  entrar() {
    this.ativar_spinner = true;
    this.clienteServico.verificaCliente(this.cliente)
      .subscribe(
        cliente_json => {

          this.clienteServico.cliente = cliente_json;

          if (this.returnUrl == null) {
            this.router.navigate(['/']);
          } else {
            this.router.navigate([this.returnUrl]);
          }

        },
        err => {
          console.log(err.error);
          this.mensagem = err.error;
          this.ativar_spinner = false;
        }
      );
  }
}
