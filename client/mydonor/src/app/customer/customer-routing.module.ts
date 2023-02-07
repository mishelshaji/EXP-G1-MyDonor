import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CustomerFeedbackComponent } from './customer-feedback/customer-feedback.component';
import { CustomerLayoutComponent } from './customer-layout/customer-layout.component';
import { CustomerProfileComponent } from './customer-profile/customer-profile.component';

const routes: Routes = [
  {
    path: '', component: CustomerLayoutComponent, children: [
      { path: 'feedback', component: CustomerFeedbackComponent },
      { path: 'profile', component: CustomerProfileComponent }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CustomerRoutingModule { }
