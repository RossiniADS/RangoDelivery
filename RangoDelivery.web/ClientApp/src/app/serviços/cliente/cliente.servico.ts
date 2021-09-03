import { Injectable, inject, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Cliente } from "../../model/cliente";


@Injectable({
  providedIn: "root"
})
export class ClienteServico {

  private baseURL: string;
  private _cliente: Cliente;


  set cliente(cliente: Cliente) {
    sessionStorage.setItem("cliente-autenticado", JSON.stringify(cliente));
    this._cliente = cliente;
  }

  get cliente(): Cliente {
    let cliente_json = sessionStorage.getItem("cliente-autenticado");
    this._cliente = JSON.parse(cliente_json);
    return this._cliente;
  }

  public cliente_autenticado(): boolean {
    return this._cliente != null && this._cliente.email != "" && this._cliente.senha != "";
  }

  public limpar_sessao() {
    sessionStorage.setItem("cliente-autenticado", "");
    this._cliente = null;
  }

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }

  public verificaCliente(cliente: Cliente): Observable<Cliente> {

    const headers = new HttpHeaders().set('content-type', 'application/json');
    var body = {
      email: cliente.email,
      senha: cliente.senha
    }

    return this.http.post<Cliente>(this.baseURL + "api/cliente/VerificarCliente", body, { headers });
  }
  public cadastrarCliente(cliente: Cliente): Observable<Cliente> {

    const headers = new HttpHeaders().set('content-type', 'application/json');

    var body = {
      email: cliente.email,
      senha: cliente.senha,
      nome: cliente.nome,
      data: cliente.dataNascimento,
      celular: cliente.celular
    }

    return this.http.post<Cliente>(this.baseURL + "api/cliente", body, { headers });
  }
}
