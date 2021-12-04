import { Cliente_has_endereco } from "./Cliente_has_endereco";

export class Cliente {
  id: number;
  nome: string;
  email: string;
  senha: string;
  sexo: string;
  celular: string;
  dataNascimento: Date;
  urlFoto: string;
  ehAdministrador: boolean;

  public cliente_has_endereco: Cliente_has_endereco[];

  constructor() {
    this.cliente_has_endereco = [];
  }
}
