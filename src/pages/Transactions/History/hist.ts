import { Component } from '@angular/core';

import { NavController } from 'ionic-angular';

import { TransactionHistoryProvider } from '../../../providers/transaction-history-provider';

@Component({
  selector: 'hist',
  templateUrl: 'hist.html',
  providers: [TransactionHistoryProvider]
})
export class Hist {
  items = [];
  testVal: string = "";

  constructor(public navCtrl: NavController, public transactionHistoryProvider: TransactionHistoryProvider) {
    this.testVal = "Testowa wartosc";
    this.loadHistory();
  }
  
    loadHistory() {
    this.transactionHistoryProvider.load()
      .then(data => {
        this.items = data;
      });
  }
}
