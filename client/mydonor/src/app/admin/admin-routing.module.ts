import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminFeedbackviewComponent } from './admin-feedbackview/admin-feedbackview.component';
import { AdminHomeComponent } from './admin-home/admin-home.component';
import { ManagerRegistrationComponent } from './manager-registration/manager-registration.component';
import { AdminLayoutComponent } from './admin-layout/admin-layout.component';
import { AdminUsermanagementComponent } from './admin-usermanagement/admin-usermanagement.component';

const routes: Routes = [
  {
    path: '', component: AdminLayoutComponent, children: [
      { path: 'home', component: AdminHomeComponent },
      { path: 'manager-registration', component: ManagerRegistrationComponent },
      { path: 'feedback', component: AdminFeedbackviewComponent },
      { path: 'customer-manage', component: AdminUsermanagementComponent }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
