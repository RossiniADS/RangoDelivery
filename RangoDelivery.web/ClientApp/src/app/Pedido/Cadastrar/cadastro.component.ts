import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { Pedido } from "../../model/pedido";
import { PedidoServico } from "../../serviços/Pedido/pedido.servico";

@Component({
  selector: "app-pedido",
  templateUrl: "./cadastro.component.html",
  styleUrls: ["./cadastro.component.css"] //[] pq é como se fosse lista
})
export class PedidoComponent implements OnInit {
  public pedido: Pedido
  public arquivoSelecionado: File;
  public ativar_spinner: boolean;
  public mensagem: string;

  constructor(private pedidoServico: PedidoServico, private router: Router) {

  }

  ngOnInit(): void {
    var pedidoSession = sessionStorage.get('pedidoSession');
    if (pedidoSession) {
      this.pedido = JSON.parse(pedidoSession);
    } else {
      this.pedido = new Pedido();
    }
  }

  public cadastrar() {
    this.ativar_spinner = true;
    this.pedidoServico.cadastrar(this.pedido)
      .subscribe(
        pedidoJson => {
          console.log(pedidoJson);
          this.ativar_spinner = false;
          this.router.navigate(['pesquisar-pedido']);
        },
        e => {
          console.log(e.error);
          alert(e.error)
          this.mensagem = e.error;
          this.ativar_spinner = false;
        }
      );
  }

  public inputChange(files: FileList) {
    this.arquivoSelecionado = files.item(0);
    this.ativar_spinner = true;
    this.pedidoServico.enviarArquivo(this.arquivoSelecionado)
      .subscribe(nomeArquivo => {
        this.pedido.nomeArquivo = nomeArquivo;
        this.ativar_spinner = false;
      },
        e => {
          console.log(e.error);
          this.ativar_spinner = false;
        });
  }

  /*public async inputChange(files: FileList) {
    this.arquivoSelecionado = files.item(0);
    this.ativar_spinner = true;
    await this.pedidoServico.enviarArquivo(this.arquivoSelecionado)
      .then(response => {
        //this.pedido.nomeArquivo = response;
        console.log(response);
        this.ativar_spinner = false;
      }).catch(e => {
        console.log(e);
        alert("Erro");
      });
  }*/
}
