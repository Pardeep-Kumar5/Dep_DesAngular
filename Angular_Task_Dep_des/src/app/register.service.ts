import { Injectable } from '@angular/core';
import{HttpClient} from'@angular/common/http';
import { Register } from './register';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {

  constructor(private httpclient:HttpClient) { }
  GetallRegister():Observable<any>
  {
    return this.httpclient.get<any>("https://localhost:44343/api/Registration/GetRegister");
  }
  GetDepartment():Observable<any>
  {
    return this.httpclient.get<any>("https://localhost:44343/api/Dep_Des/GetDepartment");
  }
  GetDesignation():Observable<any>
  {
    return this.httpclient.get<any>("https://localhost:44343/api/Dep_Des/GetDesignation");
  }
  SaveRegister(NewRegister:Register):Observable<Register>
  {
    return this.httpclient.post<Register>("https://localhost:44343/api/Registration/SaveRegister",NewRegister);
  }
}

