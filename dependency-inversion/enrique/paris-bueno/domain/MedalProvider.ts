import { MedalTable } from "./MedalTable";

export interface MedalProvider {
  top(n: number): Array<MedalTable>;
}
