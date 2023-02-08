import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomepageComponent } from './homepage/homepage.component';
import { NgModule } from '@angular/core';
import { BookingComponent } from './booking/booking.component';
import { SignupComponent } from './signup/signup.component';
import { CustomerFeedbackComponent } from './customer-feedback/customer-feedback.component';
import { CustomerProfileComponent } from './customer-profile/customer-profile.component';

const routes: Routes = [
  {
    path: '', component: CustomerLayoutComponent, children: [
      { path: 'home', component: HomepageComponent },
      { path: 'feedback', component: CustomerFeedbackComponent },
      { path: 'profile', component: CustomerProfileComponent },
      { path : 'signup', component:SignupComponent },
      { path : 'booking', component:BookingComponent }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CustomerRoutingModule { }
