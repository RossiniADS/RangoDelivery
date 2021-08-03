import { Component, OnInit } from "@angular/core";
import { Local } from "protractor/built/driverProviders";
import { Cliente } from "../../model/cliente";
import { ActivatedRoute, Router } from "@angular/router";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"] //[] pq é como se fosse lista
})
export class LoginComponent implements OnInit {
  public cliente;
  public usuarioAutenticado: boolean;
  public returnUrl: string;

  constructor(private router: Router, private activatedRouter: ActivatedRoute) {
    
  }

  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.cliente = new Cliente();
  }

  entrar() {
    if (this.cliente.email == "rossini.g.r.alves@gmail.com" && this.cliente.senha == "1234") {
      sessionStorage.setItem("usuario-autenticado", "1");
      this.router.navigate([this.returnUrl]);
    }
  }
}
