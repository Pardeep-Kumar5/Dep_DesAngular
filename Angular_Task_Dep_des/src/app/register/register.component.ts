import { Component } from '@angular/core';
import { count } from 'rxjs';
import { Department } from '../department';
import { Register } from '../register';
import { RegisterService } from '../register.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent {
  RegisterList:Register[]=[];
  DepartmentList:Department[]=[];
  DesignationList:Department[]=[];
  NewRegister:Register=new Register();
  constructor(private registerservice:RegisterService){}
  
  ngOnInit()
  {
    this.registerservice.GetDepartment().subscribe(
      count=>{
        this.DepartmentList=count;
      }
  
     )
     this.registerservice.GetDesignation().subscribe(
      count=>{
        this.DesignationList=count;
      }
  
     )
    this.getall();
  }
  getall()
  {
    this.registerservice.GetallRegister().subscribe(
      (response)=>{
        this.RegisterList=response;

      },
      (Error)=>{
        console.log(Error);
      }
    )
  }
  SaveClick()
  {
    alert(this.NewRegister.name)
  this.registerservice.SaveRegister(this.NewRegister).subscribe(
    (Response)=>{
      this.getall();
      this.NewRegister.name="";
      this.NewRegister.address="";
      this.NewRegister.department="";
      this.NewRegister.designation="";
     
    },
    (error)=>{
  console.log(error);
    }
  )
  }
}
