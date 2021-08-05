import { Injectable, inject, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Cliente } from "../../model/cliente";


@Injectable({
  providedIn: "root"
})
export class ClienteServico {

  private baseURL: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }

  public verificaCliente(cliente: Cliente): Observable<Cliente> {

    const headers = new HttpHeaders().set('content-type', 'application/json');
    var body = {
      email: cliente.email,
      senha: cliente.senha
    }

    //this.baseURL = raiz do site que pode ser exemplo.: http://www.quickbuy.com/

    return this.http.post<Cliente>(this.baseURL + "api/cliente/VerificarCliente", body, { headers });
  }
}
