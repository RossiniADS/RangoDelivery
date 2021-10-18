import { Injectable, Inject, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders, HttpRequest } from "@angular/common/http";
import { Observable } from "rxjs";
import { Pedido } from "../../model/pedido";


@Injectable({
  providedIn: "root"
})
export class PedidoServico implements OnInit {
  private _baseUrl: String;
  public pedidos: Pedido[];

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

    return this.http.post<Pedido>(this._baseUrl + "api/pedido/cadastrar", JSON.stringify(pedido), { headers: this.headers });
  }
  public salvar(pedido: Pedido): Observable<Pedido> {

    return this.http.post<Pedido>(this._baseUrl + "api/pedido/salvar", JSON.stringify(pedido), { headers: this.headers });
  }
  public deletar(pedido: Pedido): Observable<Pedido> {

    return this.http.post<Pedido>(this._baseUrl + "api/pedido/deletar", JSON.stringify(pedido), { headers: this.headers });
  }
  public obterTodosPedidos(): Observable<Pedido[]> {
    return this.http.get<Pedido[]>(this._baseUrl + "api/pedido");
  }
  public obterPedido(pedidoId: number): Observable<Pedido> {
    return this.http.get<Pedido>(this._baseUrl + "api/pedido");
  }
  public enviarArquivo(arquivoSelecionado: File): Observable<boolean> {
    const formData: FormData = new FormData();
    formData.append(arquivoSelecionado.name, arquivoSelecionado);
    
    const uploadReq = new HttpRequest('POST', this._baseUrl + "api/pedido/enviarArquivo", formData, {
      reportProgress: true,
    });

    this.http.request(uploadReq).subscribe();

    return;
    //return this.http.post<boolean>(this._baseUrl + "api/pedido/enviarArquivo", FormData);

    //return this.http.post<boolean>(this._baseUrl + "api/pedido/enviarArquivo", FormData, {
    //  reportProgress: true,
    //});

  }

}
