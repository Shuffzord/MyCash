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
  people = [];
  testVal: string = "";

  constructor(public navCtrl: NavController, public transactionHistoryProvider: TransactionHistoryProvider) {


    this.items.push({
      cat: "Category1",
      els: [1, 2, 3, 4],
    });
    this.items.push(
      {
        cat: "Category2",
        els: [4, 3, 2, 1],
      });

    this.testVal = "Testowa wartosc";
  }
}
