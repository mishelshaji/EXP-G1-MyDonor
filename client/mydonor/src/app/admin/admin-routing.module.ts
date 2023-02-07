import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminFeedbackviewComponent } from './admin-feedbackview/admin-feedbackview.component';
import { AdminHomeComponent } from './admin-home/admin-home.component';
import { AdminLayoutComponent } from './admin-layout/admin-layout.component';

const routes: Routes = [
  {
    path: '', component: AdminLayoutComponent, children: [
      { path: '', component: AdminHomeComponent },
      { path: 'feedback', component: AdminFeedbackviewComponent }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
