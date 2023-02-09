import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminRoutingModule } from './admin-routing.module';
import { AdminHomeComponent } from './admin-home/admin-home.component';
import { StockviewComponent } from './stockview/stockview.component';
import { AdminNavbarComponent } from './admin-navbar/admin-navbar.component';
import { AdminFeedbackviewComponent } from './admin-feedbackview/admin-feedbackview.component';
import { AdminLayoutComponent } from './admin-layout/admin-layout.component';
import { FeedbacksComponent } from './feedbacks/feedbacks.component';
import { AdminUsermanagementComponent } from './admin-usermanagement/admin-usermanagement.component';
import { UsersviewComponent } from './usersview/usersview.component';

@NgModule({
  declarations: [
    AdminHomeComponent,
    StockviewComponent,
    AdminNavbarComponent,
    AdminFeedbackviewComponent,
    AdminLayoutComponent,
    FeedbacksComponent,
    AdminUsermanagementComponent,
    UsersviewComponent
  ],
  imports: [
    CommonModule,
    AdminRoutingModule
  ]
})
export class AdminModule { }
