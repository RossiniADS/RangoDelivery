import { Component, OnInit } from "@angular/core";
import { Local } from "protractor/built/driverProviders";
import { Empresa } from "../model/empresa";
import { ActivatedRoute, Router } from "@angular/router";
import { EmpresaServico } from "../serviços/empresa/empresa.servico";
import { Subscriber } from "rxjs";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginEmpresaComponent implements OnInit {
  public empresa;
  public empresaAutenticado: boolean;
  public returnUrl: string;
  public mensagem: string;
  private ativar_spinner: boolean;

  constructor(private router: Router, private activatedRouter: ActivatedRoute,
    private empresaServico: EmpresaServico) {

  }

  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.empresa = new Empresa();
  }

  entrar() {
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
