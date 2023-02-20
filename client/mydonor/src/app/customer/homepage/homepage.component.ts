import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css']
})
export class HomepageComponent {
  users = [
    {
      "name": "Aravind",
      "bloodgroup": "A+ve",
      "District": "Trivandrum"
    },
    {
      "name": "Abhinav",
      "bloodgroup": "A+ve",
      "District": "Ernakulam"
    },
    {
      "name": "Donamol",
      "bloodgroup": "O-ve",
      "District": "Ernakulam"
    },
    {
      "name": "Gokul",
      "bloodgroup": "A+ve",
      "District": "Ernakulam"
    },
    {
      "name": "Nandana",
      "bloodgroup": "B+ve",
      "District": "Ernakulam"
    },
    {
      "name": "Abhay",
      "bloodgroup": "A+ve",
      "District": "Ernakulam"
    },
    {
      "name": "Arjun",
      "bloodgroup": "AB-ve",
      "District": "Ernakulam"
    }
  ]

  model = {
    districtid: "",
    bloodid: ""
  }
  constructor(private router:Router){}
  saveData(){
   localStorage.setItem('districtid', this.model.districtid);
   localStorage.setItem('bloodId', this.model.bloodid);
   console.log(localStorage.getItem('districtid'));
   this.router.navigate(['/customer/purchase']);
  }
}
