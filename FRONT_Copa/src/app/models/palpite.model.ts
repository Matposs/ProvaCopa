import { Jogo } from "./jogo.model";
import { Selecao } from "./selecao.model";

export interface palpite {
  id?: number;
  jogoId?: Jogo;
  selecaoA?: any;
  selecaoB?: any;
  placarA?: number;
  placarB?: number;
  criadoEm?: string;
}
