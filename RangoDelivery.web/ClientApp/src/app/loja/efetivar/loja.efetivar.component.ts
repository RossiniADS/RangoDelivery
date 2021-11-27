import { Component, OnInit } from "@angular/core"
import { Pedido } from "../../model/pedido";
import { PedidoServico } from "../../serviços/Pedido/pedido.servico";
import { LojaCarrinho } from "../carrinho/loja.carrinho.component";

@Component({
  selector: "loja-efetivar",
  templateUrl: "./loja.efetivar.component.html",
  styleUrls: ["./loja.efetivar.component.css"]
})
export class LojaEfetivarComponent implements OnInit {
  public carrinhoCompras: LojaCarrinho;
  public pedidos: Pedido[];

  ngOnInit(): void {
    this.carrinhoCompras = new LojaCarrinho();
    this.pedidos = this.carrinhoCompras.obterPedidos();
  }

  constructor(private pedidoServico: PedidoServico) {

  }
}
