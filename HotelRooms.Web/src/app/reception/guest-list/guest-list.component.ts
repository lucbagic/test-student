import { Component, OnInit } from '@angular/core'

import { GuestService } from '../guest.service';

import { GuestListResponse } from './guest-list.response';

@Component({
    selector: 'app-guest-list',
    templateUrl: './guest-list.component.html',
    styleUrls: ['./guest-list.component.scss']
})

export class GuestListComponent implements OnInit{
    vm: GuestListResponse = { page: 1 } as GuestListResponse;

    searchText?: string;
  
    constructor(
      private guestService: GuestService
    ) { }
  
    ngOnInit(): void {
      this.loadGuests();
    }
  
    //ne kužiiim
    loadGuests() {
      let params: any = { page: this.vm?.page || 1 };
      if(this.searchText) { params.search = this.searchText; }
      /*
        {
          page: 1,
          search: 'abc'
        }
      */
  
      this.guestService
        .getGuests(params)
        .subscribe(response => {
          this.vm = response;
      });
    }
}