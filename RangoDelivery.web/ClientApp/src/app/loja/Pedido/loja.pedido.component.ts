import { Component, OnInit } from "@angular/core"
import { Router } from "@angular/router";
import { Pedido } from "../../model/pedido";
import { PedidoServico } from "../../serviços/Pedido/pedido.servico";
import { LojaCarrinho } from "../carrinho/loja.carrinho.component";

@Component({
  selector: "loja-app-pedido",
  templateUrl: "./loja.pedido.component.html",
  styleUrls: ["./loja.pedido.component.css"]
})
export class LojaPedidoComponent implements OnInit {
  public pedido: Pedido;
  public carrinhoCompras: LojaCarrinho;

  ngOnInit(): void {
    this.carrinhoCompras = new LojaCarrinho();
    var pedidoDetalhe = sessionStorage.getItem('pedidoDetalhe');
    if (pedidoDetalhe) {
      this.pedido = JSON.parse(pedidoDetalhe);
    }
  }

  constructor(private pedidoServico: PedidoServico, private router: Router) {

  }

  public comprar() {
    this.carrinhoCompras.adicionar(this.pedido);
    this.router.navigate(['/loja-efetivar']);
  }
}
