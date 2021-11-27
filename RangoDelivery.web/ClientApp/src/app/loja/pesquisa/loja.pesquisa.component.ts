import { Component, OnInit } from "@angular/core"
import { Router } from "@angular/router";
import { Pedido } from "../../model/pedido";
import { PedidoServico } from "../../serviços/Pedido/pedido.servico";

@Component({
  selector: "app-loja",
  templateUrl: "./loja.pesquisa.component.html",
  styleUrls: ["./loja.pesquisa.component.css"]
})
export class LojaPesquisaComponent implements OnInit {
  public pedidos: Pedido[];

  ngOnInit(): void {

  }

  constructor(private pedidoServico: PedidoServico, private router: Router) {
    this.pedidoServico.obterTodosPedidos()
      .subscribe(
        pedidos => {
          this.pedidos = pedidos;
        },
        e => {
          console.log(e.error);
        })
  }

  public abrirPedido(pedido: Pedido) {
    sessionStorage.setItem('pedidoDetalhe', JSON.stringify(pedido));
    this.router.navigate(['/loja-pedido']);
  }
}
