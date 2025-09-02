"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
exports.__esModule = true;
exports.Duck = void 0;
var animal_1 = require("./animal");
var Duck = /** @class */ (function (_super) {
    __extends(Duck, _super);
    function Duck(name) {
        return _super.call(this, name) || this;
    }
    Duck.prototype.makeSound = function () {
        console.log("Sonido de pato");
    };
    Duck.prototype.sleep = function () {
        console.log("El pato duerme");
    };
    Duck.prototype.fly = function () {
        console.log("Fly fly fly");
    };
    Duck.prototype.swim = function () {
        console.log("blub blub");
    };
    return Duck;
}(animal_1.Animal));
exports.Duck = Duck;
