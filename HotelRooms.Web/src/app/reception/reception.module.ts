import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ReceptionRoutingModule } from './reception-routing.module';
//import { ProtestListComponent } from './protest-list/protest-list.component';
//import { ProtestDetailComponent } from './protest-detail/protest-detail.component';
import { HttpClientModule } from '@angular/common/http';
import { NgxPaginationModule } from 'ngx-pagination';
import { FormsModule } from '@angular/forms';
//import { ProtestFormComponent } from './protest-form/protest-form.component';
import { RouterModule } from '@angular/router';
import { GuestListComponent } from './guest-list/guest-list.component';
import { ToastrModule } from 'ngx-toastr';


@NgModule({
  declarations: [
      GuestListComponent
    //, ProtestDetailComponent, ProtestFormComponent
],
  imports: [
    CommonModule,
    RouterModule,
    ToastrModule.forRoot(),
    ReceptionRoutingModule,
    HttpClientModule,
    FormsModule,
    NgxPaginationModule
  ]
})
export class ReceptionModule { }
