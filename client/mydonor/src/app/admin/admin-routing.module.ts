import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminHomeComponent } from './admin-home/admin-home.component';
import { ManagerRegistrationComponent } from './manager-registration/manager-registration.component';
import { StockviewComponent } from './stockview/stockview.component';

const routes: Routes = [
  {
    path: '', component: AdminHomeComponent, children: [
      {path: 'home', component:StockviewComponent},
      {path: 'manager-registration', component:ManagerRegistrationComponent}
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
