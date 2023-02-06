import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LandingpageComponent } from './landingpage/landingpage.component';
import { UserLayoutComponent } from './user-layout/user-layout.component';
import { LoginComponent } from './login/login.component';
import { NotfoundPageComponent } from './notfound-page/notfound-page.component';

const routes: Routes = [
  {
    path: '', component: UserLayoutComponent, children: [
      { path: '', component: LandingpageComponent },
      { path: 'login', component: LoginComponent },
      { path: '**', component: NotfoundPageComponent }
    ]
  }
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class UserRoutingModule { }
