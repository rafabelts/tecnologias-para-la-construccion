"use strict";
exports.__esModule = true;
exports.Paris2024Provider = void 0;
var Paris2024Provider = /** @class */ (function () {
    function Paris2024Provider() {
    }
    Paris2024Provider.prototype.top = function (n) {
        var data = [
            { rank: 1, country: "usa", gold: 40, silver: 44, bronze: 42 },
            { rank: 2, country: "chn", gold: 40, silver: 27, bronze: 24 },
            { rank: 3, country: "usa", gold: 25, silver: 23, bronze: 26 },
            { rank: 4, country: "usa", gold: 16, silver: 26, bronze: 22 },
            { rank: 5, country: "usa", gold: 18, silver: 19, bronze: 16 },
        ];
        return data.slice(0, n);
    };
    return Paris2024Provider;
}());
exports.Paris2024Provider = Paris2024Provider;
