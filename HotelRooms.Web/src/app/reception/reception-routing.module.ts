import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GuestListComponent } from './guest-list/guest-list.component';

const routes: Routes = [
  //ima života na 4200/guests
  { path: 'reception/guests', component: GuestListComponent,  }
  //{ path: 'new', component: ProtestFormComponent, },
  //{ path: ':id', component: ProtestDetailComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ReceptionRoutingModule { }