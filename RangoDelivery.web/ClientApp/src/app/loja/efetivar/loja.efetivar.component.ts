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
  public total: number;

  ngOnInit(): void {
    this.carrinhoCompras = new LojaCarrinho();
    this.pedidos = this.carrinhoCompras.obterPedidos();
    this.atualizarTotal();
  }

  constructor(private pedidoServico: PedidoServico) {

  }

  public atualizarPreco(pedido: Pedido, quantidade: number) {
    if (!pedido.valorOriginal) {
      pedido.valorOriginal = pedido.valor;
    }
    if (quantidade <= 0) {
      quantidade = 1;
      pedido.quantidade = quantidade;
    }

    pedido.valor = pedido.valor * quantidade;
    this.carrinhoCompras.atualizar(this.pedidos);
    this.atualizarTotal();
  }

  public remover(pedido: Pedido) {
    this.carrinhoCompras.removerPedido(pedido);
    this.pedidos = this.carrinhoCompras.obterPedidos();
    this.atualizarTotal();
  }
  public atualizarTotal() {
    // acc = variavel de entrada para o acumulador
    // pedido = variavel que aponta para o pedido, ela da acesso a cada um dos pedidos que existe na lista
    // 0 = a partir de qual index irá fazer a leitura, logo 0 significa o primeiro da lista em diante
    this.total = this.pedidos.reduce((acc, pedido) => acc + pedido.valor, 0);

  }
}
