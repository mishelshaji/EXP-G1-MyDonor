import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminRoutingModule } from './admin-routing.module';
import { AdminHomeComponent } from './admin-home/admin-home.component';
import { StockviewComponent } from './stockview/stockview.component';
import { AdminNavbarComponent } from './admin-navbar/admin-navbar.component';
import { ManagerRegistrationComponent } from './manager-registration/manager-registration.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AdminHomeComponent,
    StockviewComponent,
    AdminNavbarComponent,
    ManagerRegistrationComponent
  ],
  imports: [
    CommonModule,
    AdminRoutingModule,
    FormsModule
  ]
})
export class AdminModule { }
