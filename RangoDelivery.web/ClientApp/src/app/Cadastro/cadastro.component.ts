import { Component, OnInit } from "@angular/core";
import { Cliente } from "../model/cliente";
import { ClienteServico } from "../serviços/cliente/cliente.servico";

@Component({
  selector: "cadastrar",
  templateUrl: "./cadastro.component.html",
  styleUrls: ["./cadastro.component.css"]
})
export class CadastroUsuarioComponent implements OnInit {
  public cliente: Cliente;
  public mensagem: string;

  constructor(private clienteServico: ClienteServico) {

  }

  ngOnInit(): void {
    this.cliente = new Cliente();
  }

  public cadastrar() {
    this.clienteServico.cadastrarCliente(this.cliente).subscribe(
      clienteJson => {

      },
      err => {
        console.log(err.error);
        this.mensagem = err.error;
      }
    );
  }
}
