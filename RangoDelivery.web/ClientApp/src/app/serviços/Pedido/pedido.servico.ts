import { Injectable, Inject, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders, HttpRequest } from "@angular/common/http";
import { Observable, Subscriber } from "rxjs";
import { Pedido } from "../../model/pedido";


@Injectable({
  providedIn: "root"
})
export class PedidoServico implements OnInit {
  private _baseUrl: String;
  public pedidos: Pedido[];
  public teste;
  public picName;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._baseUrl = baseUrl;
  }

  ngOnInit(): void {
    this.pedidos = [];
  }

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json');
  }

  public cadastrar(pedido: Pedido): Observable<Pedido> {

    return this.http.post<Pedido>(this._baseUrl + "api/pedido", JSON.stringify(pedido), { headers: this.headers });
  }
  public salvar(pedido: Pedido): Observable<Pedido> {

    return this.http.post<Pedido>(this._baseUrl + "api/pedido/salvar", JSON.stringify(pedido), { headers: this.headers });
  }
  public deletar(pedido: Pedido): Observable<Pedido[]> {

    return this.http.post<Pedido[]>(this._baseUrl + "api/pedido/deletar", JSON.stringify(pedido), { headers: this.headers });
  }
  public obterTodosPedidos(): Observable<Pedido[]> {
    return this.http.get<Pedido[]>(this._baseUrl + "api/pedido");
  }
  public obterPedido(pedidoId: number): Observable<Pedido> {
    return this.http.get<Pedido>(this._baseUrl + "api/pedido");
  }

  public enviarArquivo(arquivoSelecionado: File): Observable<string> {
    const formData: FormData = new FormData();
    formData.append(arquivoSelecionado.name, arquivoSelecionado);
    return this.http.post<string>(this._baseUrl + "api/pedido/enviarArquivo", formData);
  }

  /*
    public async enviarArquivo(arquivoSelecionado: File): Promise<Observable<string>> {
    const formData: FormData = new FormData();
    formData.append(arquivoSelecionado.name, arquivoSelecionado);

    const uploadReq = new HttpRequest('POST', this._baseUrl + "api/pedido/enviarArquivo", formData);
    this.picName = await this.http.request(uploadReq).toPromise();
    return this.picName;
  }*/
}
