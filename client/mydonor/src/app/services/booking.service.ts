import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BookingService {
  url = "https://localhost:7197/api/CustomerBuyAndBookings/Customer";

  constructor(private http: HttpClient) { }

  getBookings(model: any) {
    return this.http.post(this.url + '/BookingDetail', model);
  }

  saveBookings(model: any) {
    return this.http.post(this.url + '/Booking', model)
  }
}
