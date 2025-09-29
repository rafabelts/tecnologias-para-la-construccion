import { MedalService } from "./app/MedalService";
import { Paris2024Provider } from "./infra/Paris2024Provider";

const provider = new Paris2024Provider();
const service = new MedalService(provider);

service.top(4);
