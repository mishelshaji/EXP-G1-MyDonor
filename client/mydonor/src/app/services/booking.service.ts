import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BookingService {
  url = "https://localhost:7197/api/CustomerBuyAndBookings/Customer";
  stock = "https://localhost:7197/api/CustomerBuyAndBookings";

  constructor(private http: HttpClient) { }

  getBookings(model: any) {
    return this.http.post(this.url + "/BookingDetail", model);
  }

  saveBookings(model: any) {
    return this.http.post(this.url + "/Booking", model)
  }

  buy(data: any) {
    return this.http.post(this.url + '/Buying', data);
  }

  getStock(bloodId: any, district: any) {
    return this.http.get(this.stock + '/' + bloodId + '/' + district);
  }
}
