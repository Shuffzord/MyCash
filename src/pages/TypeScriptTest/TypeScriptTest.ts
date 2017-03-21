import { Component } from '@angular/core';

import { NavController } from 'ionic-angular';

@Component({
  selector: 'TypeScriptTest',
  templateUrl: 'TypeScriptTest.html',
})
export class TypeScriptTest {
  people = [];
  constructor(public navCtrl: NavController) {
  }

}
