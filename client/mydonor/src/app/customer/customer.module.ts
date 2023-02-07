import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomerRoutingModule } from './customer-routing.module';
import { CustomerLayoutComponent } from './customer-layout/customer-layout.component';
import { CustomerNavbarComponent } from './customer-navbar/customer-navbar.component';
import { CustomerFeedbackComponent } from './customer-feedback/customer-feedback.component';
import { CustomerProfileComponent } from './customer-profile/customer-profile.component';
import { CustomerProfileEditComponent } from './customer-profile-edit/customer-profile-edit.component';

@NgModule({
  declarations: [
    CustomerLayoutComponent,
    CustomerNavbarComponent,
    CustomerFeedbackComponent,
    CustomerProfileComponent,
    CustomerProfileEditComponent
  ],
  imports: [
    CommonModule,
    CustomerRoutingModule
  ]
})
export class CustomerModule { }
