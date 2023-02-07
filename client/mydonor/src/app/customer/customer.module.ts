import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomerRoutingModule } from './customer-routing.module';
import { CustomerLayoutComponent } from './customer-layout/customer-layout.component';
import { CustomerNavbarComponent } from './customer-navbar/customer-navbar.component';
import { CustomerFeedbackComponent } from './customer-feedback/customer-feedback.component';

@NgModule({
  declarations: [
    CustomerLayoutComponent,
    CustomerNavbarComponent,
    CustomerFeedbackComponent
  ],
  imports: [
    CommonModule,
    CustomerRoutingModule
  ]
})
export class CustomerModule { }
