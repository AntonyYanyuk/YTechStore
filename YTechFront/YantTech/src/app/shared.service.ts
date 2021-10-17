import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
readonly ApiUrl="https://localhost:5001/api"
  constructor(private http:HttpClient) { }

  getAllSmart():Observable<any[]>{
    return this.http.get<any>(this.ApiUrl+ '/AllSmartphones');
  }
  addSmartphones(val:any){
      return this.http.post(this.ApiUrl+ '/AddSmartphone', val)
    }
  }

