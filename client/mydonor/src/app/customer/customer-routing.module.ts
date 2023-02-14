import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CustomerFeedbackComponent } from './customer-feedback/customer-feedback.component';
import { CustomerLayoutComponent } from './customer-layout/customer-layout.component';
import { CustomerPaymentComponent } from './customer-payment/customer-payment.component';

const routes: Routes = [
  {
    path: '', component: CustomerLayoutComponent, children: [
      { path: 'feedback', component: CustomerFeedbackComponent },
      {path: 'payment', component:CustomerPaymentComponent}
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CustomerRoutingModule { }
