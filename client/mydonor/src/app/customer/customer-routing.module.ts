import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BookingComponent } from './booking/booking.component';
import { SignupComponent } from './signup/signup.component';
import { CustomerFeedbackComponent } from './customer-feedback/customer-feedback.component';
import { CustomerLayoutComponent } from './customer-layout/customer-layout.component';

const routes: Routes = [
  {
    path: '', component: CustomerLayoutComponent, children: [
      { path: 'feedback', component: CustomerFeedbackComponent },
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
