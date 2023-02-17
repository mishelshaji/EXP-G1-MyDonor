import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-customer-payment',
  templateUrl: './customer-payment.component.html',
  styleUrls: ['./customer-payment.component.css']
})

export class CustomerPaymentComponent {
  title = 'rough';
  model = {
    cardnumber: '',
    cardholder: '',
    expirydate: '',
    cvv: ''
  };

  minDate: any = "2023-02";
  
    getDate() {
      var date = new Date();
      var toDate = date.getDate();
    }

  payment() {
    console.log(this.model);

  }
}

