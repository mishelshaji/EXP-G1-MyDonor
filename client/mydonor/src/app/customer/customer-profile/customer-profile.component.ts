import { AccountsService } from './../../services/accounts.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-customer-profile',
  templateUrl: './customer-profile.component.html',
  styleUrls: ['./customer-profile.component.css']
})
export class CustomerProfileComponent implements OnInit {

  profile = {
    Name: '',
    email: '',
  }

  constructor(private service: AccountsService) { }

  ngOnInit(): void {

    this.service.getProfile().subscribe({
      next: (response: any) => {
        this.profile.Name = response.Name;
        this.profile.email = response.email;
      }
    })
  }
}