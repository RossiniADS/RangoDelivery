import { Component, OnInit } from "@angular/core";
import { Local } from "protractor/built/driverProviders";
import { Cliente } from "../model/cliente";
import { ActivatedRoute, Router } from "@angular/router";
import { ClienteServico } from "../serviços/cliente/cliente.servico";
import { Subscriber } from "rxjs";
import { EmpresaServico } from "../serviços/empresa/empresa.servico";
import { Empresa } from "../model/empresa";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"] //[] pq é como se fosse lista
})
export class LoginComponent implements OnInit {
  public cliente;
  public empresa;
  public usuarioAutenticado: boolean;
  public empresaAutenticado: boolean;
  public returnUrl: string;
  public mensagem: string;
  private ativar_spinner: boolean;

  constructor(private router: Router, private activatedRouter: ActivatedRoute,
    private clienteServico: ClienteServico, private empresaServico: EmpresaServico) {

  }

  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.cliente = new Cliente();
    this.empresa = new Empresa();
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
  entrarEmp() {
    this.ativar_spinner = true;
    this.empresaServico.verificaEmpresa(this.empresa)
      .subscribe(
        empresa_json => {

          this.empresaServico.empresa = empresa_json;

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
