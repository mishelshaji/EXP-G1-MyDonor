import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BookingService } from 'src/app/services/booking.service';

@Component({
  selector: 'app-customer-blood-purchase',
  templateUrl: './customer-blood-purchase.component.html',
  styleUrls: ['./customer-blood-purchase.component.css']
})
export class CustomerBloodPurchaseComponent implements OnInit{
  value:number|any = 1;
  stock:number|any = 0;
  status:boolean = false;

 constructor(private service: BookingService, private router: Router){}

  updateQuantity(symbol:string){
   if(symbol === '+'){
    this.value++;
    console.log(this.value)
   }
   else if(symbol === '-'){
    if(this.value === 1){
      this.status = true;
    }else{
      this.value--;
      console.log(this.value);
    }
   }
  }

  buyBlood(){
    if(this.value >= this.stock ){
      alert("purchase not possible");
    }
    localStorage.setItem("quantity", this.value);
    this.router.navigate(['/customer/payment']);
  }
  ngOnInit(){
    let bloodId = localStorage.getItem('bloodId');
    let district = localStorage.getItem('districtid');
    this.service.getStock(bloodId,district).subscribe({
      next:(Data)=>{
        this.stock = Data;
        console.log(Data);
      }
    })
  }
}
