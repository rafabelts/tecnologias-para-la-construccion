import { MedalProvider } from "../domain/MedalProvider";
import { MedalTable } from "../domain/MedalTable";

export class Paris2024Provider implements MedalProvider {
  top(n: number): Array<MedalTable> {
    const data = [
      { rank: 1, country: "usa", gold: 40, silver: 44, bronze: 42 },
      { rank: 2, country: "chn", gold: 40, silver: 27, bronze: 24 },
      { rank: 3, country: "usa", gold: 25, silver: 23, bronze: 26 },
      { rank: 4, country: "usa", gold: 16, silver: 26, bronze: 22 },
      { rank: 5, country: "usa", gold: 18, silver: 19, bronze: 16 },
    ];

    return data.slice(0, n);
  }
}
