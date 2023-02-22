import { Component } from '@angular/core';

@Component({
  selector: 'app-manager-management',
  templateUrl: './manager-management.component.html',
  styleUrls: ['./manager-management.component.css']
})
export class ManagerManagementComponent {
  district = '';

  updateManager(){
    console.log(this.district);
    localStorage.setItem('district', this.district);
  }
}
