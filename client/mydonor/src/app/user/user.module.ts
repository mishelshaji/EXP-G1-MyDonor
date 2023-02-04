import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserRoutingModule } from './user-routing.module';
import { LoginComponent } from './login/login.component';
import { FormsModule } from "@angular/forms";
import { LandingpageComponent } from './landingpage/landingpage.component';
import { UserLayoutComponent } from './user-layout/user-layout.component';
import { LandingNavbarComponent } from './landing-navbar/landing-navbar.component';
import { NotfoundPageComponent } from './notfound-page/notfound-page.component';
@NgModule({
  declarations: [
    LandingpageComponent,
    UserLayoutComponent,
    LoginComponent,
    LandingNavbarComponent,
    NotfoundPageComponent,
  ],
  imports: [
    CommonModule,
    UserRoutingModule,
    FormsModule
  ]
})
export class UserModule { }
