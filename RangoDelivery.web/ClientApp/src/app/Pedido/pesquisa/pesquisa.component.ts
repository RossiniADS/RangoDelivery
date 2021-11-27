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
    sessionStorage.setItem('pedidoSession', "");
    this.router.navigate(['/pedido'])
  }

  public deletarPedido(pedido: Pedido) {
    var retorno = confirm("Deseja realmente deletar o pedido selecionado?");
    if (retorno == true) {
      this.pedidoServico.deletar(pedido).subscribe(
        pedidos => {
          this.pedidos = pedidos;
        }, e => {
          console.log(e.errors);
        });
    }
  }
  public editarPedido(pedido: Pedido) {
    sessionStorage.setItem('pedidoSession', JSON.stringify(pedido));
    this.router.navigate(['/pedido']);

    var retorno = confirm("Deseja realmente deletar o pedido selecionado?");
    if (retorno == true) {
      this.pedidoServico.deletar(pedido).subscribe(
        pedidos => {
          this.pedidos = pedidos;
        }, e => {
          console.log(e.errors);
        });
    }
  }
}
