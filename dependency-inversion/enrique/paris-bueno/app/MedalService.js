"use strict";
exports.__esModule = true;
exports.MedalService = void 0;
var MedalService = /** @class */ (function () {
    function MedalService(provider) {
        this.provider = provider;
    }
    MedalService.prototype.top = function (n) {
        console.log("=== Medallero Paris 2024 ===");
        console.table(this.provider.top(n));
    };
    return MedalService;
}());
exports.MedalService = MedalService;
