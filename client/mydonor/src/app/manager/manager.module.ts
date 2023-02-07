import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ManagerRoutingModule } from './manager-routing.module';
import { ManagerHomepageComponent } from './manager-homepage/manager-homepage.component';
import { ManagerLayoutComponent } from './manager-layout/manager-layout.component';
import { ManagerNavbarComponent } from './manager-navbar/manager-navbar.component';


@NgModule({
  declarations: [
    ManagerHomepageComponent,
    ManagerLayoutComponent,
    ManagerNavbarComponent
  ],
  imports: [
    CommonModule,
    ManagerRoutingModule
  ]
})
export class ManagerModule { }
