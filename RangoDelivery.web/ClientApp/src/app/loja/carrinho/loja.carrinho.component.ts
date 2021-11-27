import { Pedido } from "../../model/pedido";

export class LojaCarrinho {
  public pedidos: Pedido[] = [];

  public adicionar(pedido: Pedido) {
    var pedidoLocalStorage = localStorage.getItem("pedidoLocalStorage");
    if (!pedidoLocalStorage) {
      //se não existir nada dentro do localStorage
      this.pedidos.push(pedido);
    } else {
      // se já existir pelo menos um unico item armazenado na sessão(localStorage)
      this.pedidos = JSON.parse(pedidoLocalStorage);
      this.pedidos.push(pedido);
    }

    localStorage.setItem("pedidoLocalStorage", JSON.stringify(this.pedidos));

  }

  public obterPedidos(): Pedido[] {
    var pedidoLocalStorage = localStorage.getItem("pedidoLocalStorage");
    if (pedidoLocalStorage) {
      return JSON.parse(pedidoLocalStorage);
    }
  }
  public removerPedido(pedido: Pedido) {
    var pedidoLocalStorage = localStorage.getItem("pedidoLocalStorage");
    if (pedidoLocalStorage) {
      this.pedidos = JSON.parse(pedidoLocalStorage);
      this.pedidos = this.pedidos.filter(p => p.id != pedido.id);
      localStorage.setItem("pedidoLocalStorage", JSON.stringify(this.pedidos));
    }
  }
  public atualizar(pedidos: Pedido[]) {
    localStorage.setItem("pedidoLocalStorage", JSON.stringify(pedidos));
  }
}
