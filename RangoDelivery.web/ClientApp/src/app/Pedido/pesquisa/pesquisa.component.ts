import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { Pedido } from "../../model/pedido";
import { PedidoServico } from "../../serviços/Pedido/pedido.servico";

@Component({
  selector: "pesquisa-pedido",
  templateUrl: "./pesquisa.component.html",
  styleUrls: ["./pesquisa.component.css"]
})

export class PesquisaPedidoComponent implements OnInit {
  public pedidos: Pedido[];

  ngOnInit(): void {
    throw new Error("Method not implemented.");
  }

  constructor(private pedidoServico: PedidoServico, private router: Router) {
    this.pedidoServico.obterTodosPedidos()
      .subscribe(
        pedidos => {
          this.pedidos = pedidos
        },
        e => {
          console.log(e.error);
        });
  }

  public adicionarPedido() {
    this.router.navigate(['/pedido'])
  }
}
