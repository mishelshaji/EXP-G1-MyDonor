import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminRoutingModule } from './admin-routing.module';
import { AdminHomeComponent } from './admin-home/admin-home.component';
import { StockviewComponent } from './stockview/stockview.component';
import { AdminNavbarComponent } from './admin-navbar/admin-navbar.component';
import { AdminFeedbackviewComponent } from './admin-feedbackview/admin-feedbackview.component';
import { AdminLayoutComponent } from './admin-layout/admin-layout.component';


@NgModule({
  declarations: [
    AdminHomeComponent,
    StockviewComponent,
    AdminNavbarComponent,
    AdminFeedbackviewComponent,
    AdminLayoutComponent
  ],
  imports: [
    CommonModule,
    AdminRoutingModule
  ]
})
export class AdminModule { }
