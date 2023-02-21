import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AccountsService } from 'src/app/services/accounts.service';

@Component({
  selector: 'app-otp-page',
  templateUrl: './otp-page.component.html',
  styleUrls: ['./otp-page.component.css']
})
export class OtpPageComponent {
  otp: any;

  constructor(private service: AccountsService, private router: Router) { }

  validateOtp() {
    let userid: string | null = localStorage.getItem('userid');
    console.log(userid);
    this.service.authenticate(this.otp, userid).subscribe({
      next: (data) => {
        if (data) {
          alert("Registration sucessfull");
          this.router.navigate(['user/login']);
        }
      }, error: (err) => {
        console.error(err);
      }
    })
  }
}
