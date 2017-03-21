import { Component } from '@angular/core';

import { NavController } from 'ionic-angular';


@Component({
  selector: 'main',
  templateUrl: 'main.html'
})
export class Main {
  items = [];
  testVal: string = "";

  constructor(public navCtrl: NavController) {
  }
    
}
