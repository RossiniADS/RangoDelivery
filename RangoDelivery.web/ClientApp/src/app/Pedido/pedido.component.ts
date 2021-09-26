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
}
