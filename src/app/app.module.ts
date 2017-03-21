import { NgModule, ErrorHandler } from '@angular/core';
import { IonicApp, IonicModule, IonicErrorHandler } from 'ionic-angular';
import { MyApp } from './app.component';
import { TypeScriptTest } from '../pages/TypeScriptTest/TypeScriptTest';
import { Hist } from '../pages/Transactions/History/hist';
import { Main } from '../pages/Transactions/main';

@NgModule({
  declarations: [
    MyApp,
    TypeScriptTest,
    Hist,
    Main
  ],
  imports: [
    IonicModule.forRoot(MyApp)
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    TypeScriptTest,
    Hist,
    Main
  ],
  providers: [{provide: ErrorHandler, useClass: IonicErrorHandler}]
})
export class AppModule {}
