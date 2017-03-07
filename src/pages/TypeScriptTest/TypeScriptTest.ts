import { Component } from '@angular/core';

import { NavController } from 'ionic-angular';
import { TransactionHistoryProvider } from '../../providers/transaction-history-provider';

@Component({
  selector: 'TypeScriptTest',
  templateUrl: 'TypeScriptTest.html',
  providers: [TransactionHistoryProvider]
})
export class TypeScriptTest {
  people = [];
  constructor(public navCtrl: NavController, public transactionHistoryProvider: TransactionHistoryProvider) {
    this.loadPeople();
  }

  loadPeople() {
    this.transactionHistoryProvider.load()
      .then(data => {
        this.people = data;
      });
  }

}
