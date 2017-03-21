var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { TransactionProvider } from '../../../providers/transaction-provider';
var Hist = (function () {
    function Hist(navCtrl, transactionProvider) {
        this.navCtrl = navCtrl;
        this.transactionProvider = transactionProvider;
        this.items = [];
        this.testVal = "";
        this.loadHistory();
    }
    Hist.prototype.loadHistory = function () {
        var _this = this;
        this.transactionProvider.history()
            .then(function (data) {
            _this.items = data;
        });
    };
    return Hist;
}());
Hist = __decorate([
    Component({
        selector: 'hist',
        templateUrl: 'hist.html',
        providers: [TransactionProvider]
    }),
    __metadata("design:paramtypes", [NavController, TransactionProvider])
], Hist);
export { Hist };
//# sourceMappingURL=hist.js.map