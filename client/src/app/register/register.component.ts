import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  
  @Output() cancelRegister = new EventEmitter();
  model: any = {};

  constructor(private accoutnService: AccountService) { }

  ngOnInit(): void {
  }

  register(){
    this.accoutnService.register(this.model).subscribe(response => {
      console.log(response);
      this.cancel();
    }, error => console.log(error)
    );
  }

  cancel(){
    this.cancelRegister.emit(false);
  }

}
