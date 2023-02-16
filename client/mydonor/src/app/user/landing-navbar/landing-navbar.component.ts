import { Component } from '@angular/core';

@Component({
  selector: 'app-landing-navbar',
  templateUrl: './landing-navbar.component.html',
  styleUrls: ['./landing-navbar.component.css']
})
export class LandingNavbarComponent {

  buttonClicked = true;
  
  show() {
    this.buttonClicked = !this.buttonClicked;
  }
}

