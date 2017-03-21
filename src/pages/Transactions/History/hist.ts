import { Component } from '@angular/core';

import { NavController } from 'ionic-angular';

import { TransactionProvider } from '../../../providers/transaction-provider';

@Component({
  selector: 'hist',
  templateUrl: 'hist.html',
  providers: [TransactionProvider]
})
export class Hist {
  items = [];
  testVal: string = "";

  constructor(public navCtrl: NavController, public transactionProvider: TransactionProvider) {
   this.loadHistory();
  }
  
    loadHistory() {
    this.transactionProvider.history()
      .then(data => {
        this.items = data;
      });
  }
}
