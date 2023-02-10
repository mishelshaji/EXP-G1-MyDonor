import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomerRoutingModule } from './customer-routing.module';
import { HomepageComponent } from './homepage/homepage.component';
import { CustomerLayoutComponent } from './customer-layout/customer-layout.component';
import { CustomerNavbarComponent } from './customer-navbar/customer-navbar.component';
import { CustomerFeedbackComponent } from './customer-feedback/customer-feedback.component';
import { CustomerProfileComponent } from './customer-profile/customer-profile.component';
import { CustomerProfileEditComponent } from './customer-profile-edit/customer-profile-edit.component';
import { FormsModule } from '@angular/forms';
import { SignupComponent } from './signup/signup.component';

@NgModule({
  declarations: [
    CustomerLayoutComponent,
    CustomerNavbarComponent,
    CustomerFeedbackComponent,
    CustomerProfileComponent,
    CustomerProfileEditComponent,
    SignupComponent,
    HomepageComponent
  ],
  imports: [
    CommonModule,
    CustomerRoutingModule,
    FormsModule
  ]
})
export class CustomerModule { }
