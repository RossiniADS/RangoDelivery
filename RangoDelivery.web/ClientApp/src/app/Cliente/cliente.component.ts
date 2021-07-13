import { Component } from "@angular/core"

@Component({
  selector: "app-cliente",
  template: "<html><body>{{obterNome()}}</body></html>",

})
export class ClienteComponent { //Nome das classes começando com maiusculo por conta da convenção PascalCase
  /*camelCase para variaveis, atributos e nomes das funções*/
  public nome: string;
  public email: string;

  public obterNome(): string {
    return "Samsung";
  }
}
