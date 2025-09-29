"use strict";
exports.__esModule = true;
var MedalService_1 = require("./app/MedalService");
var Paris2024Provider_1 = require("./infra/Paris2024Provider");
var provider = new Paris2024Provider_1.Paris2024Provider();
var service = new MedalService_1.MedalService(provider);
service.top(4);
