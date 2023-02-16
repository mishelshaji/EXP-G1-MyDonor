import { Component } from '@angular/core';

@Component({
  selector: 'app-admin-navbar',
  templateUrl: './admin-navbar.component.html',
  styleUrls: ['./admin-navbar.component.css']
})
export class AdminNavbarComponent {
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
