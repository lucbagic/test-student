import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { GuestListResponse } from './guest-list/guest-list.response';
import { environment } from '../../environments/environment';
import { Guest } from './guest';

//šta ovo radi
@Injectable({
    providedIn: 'root'
  })

export class GuestService {
  
    constructor (
      private http: HttpClient
    ) { }
  
    getGuests(params = {}) {
      // GET req na localhost:5001/api/protests?search=abc
      return this.http.get<GuestListResponse>(environment.apiUrl + '/guests', { params });
    }
  
    getGuest(id: number) {
      return this.http.get<Guest>(environment.apiUrl + '/guests/' + id);
    }
  
    deleteguest(id: number) {
      return this.http.delete(environment.apiUrl + '/guests/' + id);
    }
  
    postgGuest(guest: Guest) {
      return this.http.post<Guest>(environment.apiUrl + '/guests', guest);
    }
  }