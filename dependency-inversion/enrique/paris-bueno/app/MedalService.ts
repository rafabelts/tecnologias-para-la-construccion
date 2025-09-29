import { MedalProvider } from "../domain/MedalProvider";

export class MedalService {
  private provider: MedalProvider;

  constructor(provider: MedalProvider) {
    this.provider = provider;
  }

  top(n: number) {
    console.log("=== Medallero Paris 2024 ===");
    console.table(this.provider.top(n));
  }
}
