import { Injectable, inject, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Empresa } from "../../model/empresa";


@Injectable({
  providedIn: "root"
})
export class EmpresaServico {

  private baseURL: string;
  private _empresa: Empresa;


  set empresa(empresa: Empresa) {
    sessionStorage.setItem("empresa-autenticado", JSON.stringify(empresa));
    this._empresa = empresa;
  }

  get empresa(): Empresa {
    let empresa_json = sessionStorage.getItem("empresa-autenticado");
    this._empresa = JSON.parse(empresa_json);
    return this._empresa;
  }

  public empresa_autenticado(): boolean {
    return this._empresa != null && this._empresa.email != "" && this._empresa.senha != "";
  }

  public limpar_sessao() {
    sessionStorage.setItem("empresa-autenticado", "");
    this._empresa = null;
  }

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }

  public verificaEmpresa(empresa: Empresa): Observable<Empresa> {

    const headers = new HttpHeaders().set('content-type', 'application/json');
    var body = {
      email: empresa.email,
      senha: empresa.senha
    }

    return this.http.post<Empresa>(this.baseURL + "api/empresa/VerificarEmpresa", body, { headers });
  }
  public cadastrarEmpresa(empresa: Empresa): Observable<Empresa> {

    const headers = new HttpHeaders().set('content-type', 'application/json');

    var body = {
      email: empresa.email,
      senha: empresa.senha,
      nome: empresa.cnpj,
      data: empresa.nomeFantasia,
      celular: empresa.razaoSocial
    }

    return this.http.post<Empresa>(this.baseURL + "api/empresa", body, { headers });
  }
}
