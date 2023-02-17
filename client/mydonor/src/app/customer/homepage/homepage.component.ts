import { Component } from '@angular/core';

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
}
