var Paris2024Provider = /** @class */ (function () {
    function Paris2024Provider() {
    }
    Paris2024Provider.prototype.top = function (n) {
        var data = [
            { rank: 1, country: "usa", gold: 40, silver: 44, bronze: 42 },
            { rank: 2, country: "usa", gold: 40, silver: 44, bronze: 42 },
            { rank: 3, country: "usa", gold: 40, silver: 44, bronze: 42 },
            { rank: 4, country: "usa", gold: 40, silver: 44, bronze: 42 },
            { rank: 5, country: "usa", gold: 40, silver: 44, bronze: 42 },
        ];
        return data.slice(0, n);
    };
    return Paris2024Provider;
}());
var MedalService = /** @class */ (function () {
    function MedalService() {
        this.provider = new Paris2024Provider();
    }
    MedalService.prototype.showTop = function (n) {
        var rows = this.provider.top(n);
        console.log("\n=== Paris 2025 ===");
        console.table(rows);
    };
    return MedalService;
}());
var medallero = new MedalService();
medallero.showTop(5);
