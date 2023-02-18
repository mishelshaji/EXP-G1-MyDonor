import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AccountsService } from 'src/app/services/accounts.service';

@Component({
  selector: 'app-manager-registration',
  templateUrl: './manager-registration.component.html',
  styleUrls: ['./manager-registration.component.css']
})
export class ManagerRegistrationComponent {
  password = "";
  confirmpasssword = "";
  display = false;

  model = {
    email: '',
    district: '',
    password: '',
    cpassword: ''
  };

  constructor(private service: AccountsService, private route: Router) { }

  onSubmit(form: any) {
    console.log(this.model);
    this.service.managerRegistration(this.model).subscribe({
      next: (Data) => {
        console.log(Data);
        this.route.navigate(['/user/login'])
      },
      error: (err) => {
        console.error(err);
      }
    });
  }

  storePassword(e: any) {
    this.password = e.target.attributes['ng-reflect-model'].value;
  }

  handlePassword(event: any) {
    this.confirmpasssword = event.target.attributes['ng-reflect-model'].value;
    if (this.confirmpasssword !== this.password) {
      this.display = true;
    }
    else {
      this.display = false;
    }
  }
}