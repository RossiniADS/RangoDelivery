import { Cliente_has_endereco } from "./Cliente_has_endereco";

export class Endereco {
  public id: number;
  public cep: string;
  public complemento: string;
  public bairroId: number;

  public cliente_has_endereco: Cliente_has_endereco[];

  constructor() {
    this.cliente_has_endereco = [];
  }
}
