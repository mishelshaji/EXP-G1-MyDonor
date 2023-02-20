import { Component } from '@angular/core';
import { BookingService } from 'src/app/services/booking.service';
import { TokenHelper } from 'src/utilities/helpers/tokenHelper';
@Component({
  selector: 'app-booking',
  templateUrl: './booking.component.html',
  styleUrls: ['./booking.component.css']
})
export class BookingComponent {

  model = {
    districtid: '',
    date: new Date(),
    time: '',
    userid: ''
  };

  data : any;
  constructor(private token: TokenHelper, private service: BookingService) { }

  checkBooking() {
    this.model.userid = this.token.getDecodedToken().nameidentifier;
    this.service.getBookings(this.model).subscribe({
      next: (Data) => {
        this.data = Data;        
      },
      error: (err) => {
        console.error(err);
      }
    })
  }

  saveData() {
    this.model.userid = this.token.getDecodedToken().nameidentifier;
    this.service.saveBookings(this.model).subscribe({
      next: (Data) => {
      },
      error: (err) => {
        console.error(err);
      }
    })
  }

}
