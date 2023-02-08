import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CustomerRoutingModule } from './customer-routing.module';
import { HomepageComponent } from './homepage/homepage.component';
import { CustomerLayoutComponent } from './customer-layout/customer-layout.component';

@NgModule({
  declarations: [
    HomepageComponent,
    CustomerLayoutComponent,
  ],
  imports: [
    CommonModule,
    CustomerRoutingModule
  ]
})
export class CustomerModule { }
