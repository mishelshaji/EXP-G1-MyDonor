import { Component } from '@angular/core';

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
    password: '',
    cpassword: ''
  };

  onSubmit(form:any) {
    console.log(form);
  }

  storePassword(e:any) {
    this.password = e.target.attributes['ng-reflect-model'].value; 
  }

  handlePassword(event:any) {
    this.confirmpasssword = event.target.attributes['ng-reflect-model'].value;
    
    if(this.confirmpasssword !== this.password) {
      this.display = true;
    }
    
    else {
      this.display = false;
    }
  }
}
