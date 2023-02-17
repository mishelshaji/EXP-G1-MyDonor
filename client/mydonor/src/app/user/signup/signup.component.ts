import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { SignupService } from 'src/app/services/signup.service';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent {

  status = false;
  password = "";
  confirmpasssword = "";
  display = false;

  userData : signupCreate = {
    name: "mydonor",
    email: "mydonor@gmail.com",
    phone: "9846135859",
    district: 1,
    gender: "male",
    address: "dkjbcdijfidsl",
    bloodId: 1,
    dob: new Date(),
    password: "Aravin@123",
    temporarypass: "Aravin@123"
  };
  constructor(private signupservice: SignupService, private router: Router){}

  signupCustomer(){
    this.signupservice.signup(this.userData).subscribe({
      next:(Data)=>{
        console.log(Data);
      },
      error:(err)=>{
        console.error(err);
      }
    });
  }
  handleDob(dob: any) {

    // function to validate age of customer.
    let date = new Date(dob.value)
    let timeDiff = Math.abs(Date.now() - date.getTime());
    let age = Math.floor((timeDiff / (1000 * 3600 * 24)) / 365.25);
    if (age < 18) {
      this.status = true;
    }
    else {
      this.status = false;
    }
  }

  storePassword(event: any) {
    // Storing password of user for validating confirm password.
    this.password = event.target.attributes['ng-reflect-model'].value;
  }

  handlePassword(event: any) {
    // function to check whether confirm password matches password.
    this.confirmpasssword = event.target.attributes['ng-reflect-model'].value;
    if (this.confirmpasssword !== this.password) {
      this.display = true;
    }
    else {
      this.display = false;
    }
  }
}
