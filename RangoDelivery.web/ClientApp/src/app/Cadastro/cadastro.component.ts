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
  public clienteCadastrado: boolean;
  public empresaCadastrada: boolean;
  public ativar_spinner: boolean;
  
  constructor(private clienteServico: ClienteServico, private empresaServico: EmpresaServico) {

  }

  ngOnInit(): void {
    this.cliente = new Cliente();
    this.empresa = new Empresa();
  }

  public cadastrar() {
    this.ativar_spinner = true;
    this.clienteServico.cadastrarCliente(this.cliente).subscribe(
      clienteJson => {
        this.clienteCadastrado = true;
        this.mensagem = "";
        this.ativar_spinner = false;
      },
      err => {
        this.mensagem = err.error;
        this.ativar_spinner = false;
      }
    );
  }
  public cadastrarEmp() {
    this.ativar_spinner = true;
    this.empresaServico.cadastrarEmpresa(this.empresa).subscribe(
      clienteJson => {
        this.empresaCadastrada = true;
        this.mensagem = "";
        this.ativar_spinner = false;
      },
      err => {
        this.mensagem = err.error;
        this.ativar_spinner = false;
      }
    );
  }
}
