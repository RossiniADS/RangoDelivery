import { Component, OnInit } from "@angular/core";
import { Pedido } from "../model/pedido";
import { PedidoServico } from "../serviços/Pedido/pedido.servico";

@Component({
  selector: "app-pedido",
  templateUrl: "./pedido.component.html",
  styleUrls: ["./pedido.component.css"] //[] pq é como se fosse lista
})
export class PedidoComponent implements OnInit {
  public pedido: Pedido
  public arquivoSelecionado: File;
  public ativar_spinner: boolean;

  constructor(private pedidoServico: PedidoServico) {

  }

  ngOnInit(): void {
    this.pedido = new Pedido();
  }

  public cadastrar() {
    //this.pedido
    this.pedidoServico.cadastrar(this.pedido)
      .subscribe(
        pedidoJson => {
          console.log(pedidoJson);
        },
        e => {
          console.log(e.error);
        }
      );
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
}
