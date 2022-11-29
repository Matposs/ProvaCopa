import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { MatSnackBar } from "@angular/material/snack-bar";
import { ActivatedRoute, Router } from "@angular/router";
import { Jogo } from "src/app/models/jogo.model";
import { palpite } from "src/app/models/palpite.model";
import { Selecao } from "src/app/models/selecao.model";

@Component({
  selector: "app-palpitar-jogo",
  templateUrl: "./palpitar-jogo.component.html",
  styleUrls: ["./palpitar-jogo.component.css"],
})
export class PalpitarJogoComponent implements OnInit {
	id!: number;
	criadoEm!: string;
	placarA!: number;
	placarB!: number;
	selecaoAId!: number;
	selecaoBId!: number;
	selecaoA! : Selecao;
	selecaoB! : Selecao;
	erro! : string;
	jogo! : Jogo;

  constructor(
    private http: HttpClient,
    private router: Router,
    private route: ActivatedRoute,
    private _snackBar: MatSnackBar
  ) {}

  ngOnInit(): void {
    this.route.params.subscribe((params) => {
      let { id } = params;
      if (id !== undefined) {
        this.http.get<palpite>(`https://localhost:5001/api/jogo/buscar/${id}`).subscribe({
          next: (jogo) => {
            this.selecaoA = jogo.selecaoA;
            this.selecaoB = jogo.selecaoB;
			this.placarA  = jogo.placarA!;
			this.placarB = jogo.placarB!;
            this.id = jogo.id!;
          },
        });
      }
    });
  }

  palpitar(): void {
    let palpite: palpite = {
      id: this.id,
      placarA: this.placarA,
      placarB: this.placarB 
    };
    //Configuração da requisição
    this.http
      .patch<palpite>("https://localhost:5001/api/jogo/alterar", palpite)
      //Execução da requisição
      .subscribe({
        //Aqui executamos algo quando a requisição for bem-sucedida
        next: (jogo) => {
          this._snackBar.open("Palpite Feito", "Ok!", {
            horizontalPosition: "right",
            verticalPosition: "top",
          });
          this.router.navigate(["pages/jogo/listar"]);
        },
        //Aqui executamos algo quando a requisição for mal-sucedida
        error: (error) => {
          if (error.status == 400) {
            this.erro = "Erro de validação";
          } else if (error.status == 0) {
            this.erro = "Está faltando iniciar a sua API!";
          }
        },
      });
  }

}
