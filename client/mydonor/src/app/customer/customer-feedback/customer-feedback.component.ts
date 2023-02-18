import { Component } from '@angular/core';
import { AccountsService } from 'src/app/services/accounts.service';
import { TokenHelper } from 'src/utilities/helpers/tokenHelper';

@Component({
  selector: 'app-customer-feedback',
  templateUrl: './customer-feedback.component.html',
  styleUrls: ['./customer-feedback.component.css']
})
export class CustomerFeedbackComponent {
  model = {
    content: ""
  };

  constructor(private service: AccountsService, private token: TokenHelper) { }

  onSubmit() {
    let id = this.token.getDecodedToken().nameidentifier;
    this.service.feedbackReg(this.model, id).subscribe({
      next: (Data) => {
      }
    })
  }
}
