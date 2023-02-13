import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomepageComponent } from './homepage/homepage.component';
import { BookingComponent } from './booking/booking.component';
import { CustomerFeedbackComponent } from './customer-feedback/customer-feedback.component';
import { CustomerProfileComponent } from './customer-profile/customer-profile.component';
import { CustomerLayoutComponent } from './customer-layout/customer-layout.component';
import { CustomerBloodPurchaseComponent } from './customer-blood-purchase/customer-blood-purchase.component';
import { CustomerProfileEditComponent } from './customer-profile-edit/customer-profile-edit.component';
import { CustomerHistoryComponent } from './customer-history/customer-history.component';

const routes: Routes = [
  {
    path: '', component: CustomerLayoutComponent, children: [
      { path: 'home', component: HomepageComponent },
      { path: 'feedback', component: CustomerFeedbackComponent },
      { path: 'profile', component: CustomerProfileComponent },
      { path: 'booking', component: BookingComponent },
      { path: 'purchase', component: CustomerBloodPurchaseComponent },
      { path: 'profile/edit', component: CustomerProfileEditComponent },
      { path: 'history', component: CustomerHistoryComponent }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CustomerRoutingModule { }
