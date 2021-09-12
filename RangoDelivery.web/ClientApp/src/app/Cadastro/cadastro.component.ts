import { Component, OnInit } from "@angular/core";
import { Cliente } from "../model/cliente";
import { Empresa } from "../model/empresa";
import { ClienteServico } from "../serviços/cliente/cliente.servico";
import { EmpresaServico } from "../serviços/empresa/empresa.servico";

@Component({
  selector: "cadastrar",
  templateUrl: "./cadastro.component.html",
  styleUrls: ["./cadastro.component.css"]
})
export class CadastroClienteComponent implements OnInit {
  public cliente: Cliente;
  public mensagem: string;
  public empresa: Empresa;

  constructor(private clienteServico: ClienteServico, private empresaServico: EmpresaServico) {

  }

  ngOnInit(): void {
    this.cliente = new Cliente();
    this.empresa = new Empresa();
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
  public cadastrarEmp() {
    this.empresaServico.cadastrarEmpresa(this.empresa).subscribe(
      clienteJson => {

      },
      err => {
        console.log(err.error);
        this.mensagem = err.error;
      }
    );
  }
}
