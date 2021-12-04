import { error } from "@angular/compiler/src/util";
import { Component, OnInit } from "@angular/core";
import { Cliente } from "../../model/cliente";
import { Cliente_has_endereco } from "../../model/Cliente_has_endereco";
import { Endereco } from "../../model/Endereco";
import { ClienteServico } from "../../serviços/cliente/cliente.servico";

@Component({
  selector: "app-meusDados",
  templateUrl: "./meusDados.component.html",
  styleUrls: ["./meusDados.component.css"]
})
export class MeusDadosComponent implements OnInit {
  public cliente;
  public endereco;

  ngOnInit(): void {
    this.cliente = new Cliente();
    this.endereco = new Endereco();

  }

  constructor(private clienteServico: ClienteServico) {

  }

  public salvarDados() {
    this.clienteServico.atualizarCliente(this.criarDados()).subscribe(
      cliente => {
        alert("Foi");
      },
      err => {
        alert(err);
      });
    //let endereco = new Endereco();
    //let cliente_has_endereco = new Cliente_has_endereco();

  }

  public criarDados() {
    let cliente = new Cliente();
    cliente.id = this.clienteServico.cliente.id; //usuario autenticado no sistema
    cliente.celular = this.cliente.celular;
    cliente.dataNascimento = this.cliente.dataNascimento;
    cliente.email = this.cliente.email;
    cliente.nome = this.cliente.nome;
    cliente.senha = this.clienteServico.cliente.senha;
    cliente.sexo = this.cliente.sexo;
    cliente.urlFoto = this.clienteServico.cliente.urlFoto;

    return cliente;
    //let endereco = new Endereco();
    //endereco.id
  }
}
