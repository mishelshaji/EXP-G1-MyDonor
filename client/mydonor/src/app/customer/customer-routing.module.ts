import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BookingComponent } from './booking/booking.component';
import { SignupComponent } from './signup/signup.component';

const routes: Routes = [
  {path:'signup', component:SignupComponent},
  {path:'booking', component:BookingComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CustomerRoutingModule { }
