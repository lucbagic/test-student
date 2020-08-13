import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

//zašto on nema browsermodule

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { ReceptionModule } from './reception/reception.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    //on je zakomentirao browserModule
    BrowserAnimationsModule,
    AppRoutingModule,
    ToastrModule.forRoot(),
    BrowserModule,
    ReceptionModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
