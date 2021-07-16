import { Component } from "@angular/core";
import { Cliente } from "../../model/cliente";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"] //[] pq é como se fosse lista
})
export class LoginComponent {
  public cliente = new Cliente();
  public usuarioAutenticado: boolean;
  //public usuarios = ["usuario1", "usuario2", "usuario3", "usuario4"]; *ngFor="let us of usuarios" {{us}}
  constructor() {
    this.cliente = new Cliente();
  }

  entrar() {

  }

  //entrar() {
  //  if (this.cliente.email == "rossini.g.r.alves@gmail.com" && this.cliente.senha == "1234") {  //*ngIf="usuarioAutenticado"
  //    this.usuarioAutenticado = true;
  //  }
  //}

  //entrar() {
  //  alert(this.email + " - " + this.senha); [(ngModel)]="senha"
  //}

  /*entrar() {
    alert(this.email); // apenas do componente para o template value="{{email}}"
  }*/

  /*on_keypress() {
    alert('foi digitado no campo de email');
  }*/

}
