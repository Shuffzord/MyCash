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
import { TransactionHistoryProvider } from '../../providers/transaction-history-provider';
var TypeScriptTest = (function () {
    function TypeScriptTest(navCtrl, transactionHistoryProvider) {
        this.navCtrl = navCtrl;
        this.transactionHistoryProvider = transactionHistoryProvider;
        this.people = [];
        this.loadPeople();
    }
    TypeScriptTest.prototype.loadPeople = function () {
        var _this = this;
        this.transactionHistoryProvider.load()
            .then(function (data) {
            _this.people = data;
        });
    };
    return TypeScriptTest;
}());
TypeScriptTest = __decorate([
    Component({
        selector: 'TypeScriptTest',
        templateUrl: 'TypeScriptTest.html',
        providers: [TransactionHistoryProvider]
    }),
    __metadata("design:paramtypes", [NavController, TransactionHistoryProvider])
], TypeScriptTest);
export { TypeScriptTest };
//# sourceMappingURL=TypeScriptTest.js.map