import { Component } from '@angular/core';

import { NavController } from 'ionic-angular';

@Component({
  selector: 'hist',
  templateUrl: 'hist.html'
})
export class Hist {
  items = [];
  testVal: string = "";

  constructor(public navCtrl: NavController) {
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
