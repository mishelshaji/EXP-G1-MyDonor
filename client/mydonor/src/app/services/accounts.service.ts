import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AccountsService {

  url = "https://localhost:7197/api/accounts";

  constructor(private http: HttpClient) {

  }

  login(model: LoginDto) {
    return this.http.post(this.url + "/login", model);
  }
}