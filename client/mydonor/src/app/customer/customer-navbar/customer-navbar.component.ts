import { Component } from '@angular/core';

@Component({
  selector: 'app-customer-navbar',
  templateUrl: './customer-navbar.component.html',
  styleUrls: ['./customer-navbar.component.css']
})
export class CustomerNavbarComponent {
  buttonClicked = true;
  show() {
    if (this.buttonClicked == true) {
      this.buttonClicked = false;
    }
    else {
      this.buttonClicked = true;
    }
  }
}
