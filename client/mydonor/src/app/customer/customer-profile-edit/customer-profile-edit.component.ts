import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AccountsService } from 'src/app/services/accounts.service';
import { TokenHelper } from 'src/utilities/helpers/tokenHelper';

@Component({
  selector: 'app-customer-profile-edit',
  templateUrl: './customer-profile-edit.component.html',
  styleUrls: ['./customer-profile-edit.component.css']
})
  
export class CustomerProfileEditComponent {
  updateModel = {
    name: '',
    adress: '',
    phone: '',
    password: '',
  };
  id : string|null;
  constructor(private router: Router,private token:TokenHelper, private service: AccountsService, private route:ActivatedRoute){
    this.id = this.token.getDecodedToken().nameidentifier;
  }
  
  update(){
    this.service.updateUser(this.id as string, this.updateModel).subscribe({
     next:(Data) =>{
      console.log("edit worked");
     },
     error:(err) =>{
      console.error(err);
     }
    });
  }
}
