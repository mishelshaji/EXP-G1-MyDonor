import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UserRoutingModule } from './user-routing.module';
import { LandingpageComponent } from './landingpage/landingpage.component';
import { UserLayoutComponent } from './user-layout/user-layout.component';


@NgModule({
  declarations: [
    LandingpageComponent,
    UserLayoutComponent
  ],
  imports: [
    CommonModule,
    UserRoutingModule
  ]
})
export class UserModule { }
