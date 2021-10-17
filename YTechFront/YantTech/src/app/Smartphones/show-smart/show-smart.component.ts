import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-show-smart',
  templateUrl: './show-smart.component.html',
  styleUrls: ['./show-smart.component.css']
})
export class ShowSmartComponent implements OnInit {

  constructor(private service: SharedService) { }

SmartphoneList:any=[];

  ngOnInit(): void {
    this.SmartphoneList();
  }

  refreshDeplict(){
    this.service.getAllSmart().subscribe(data => {
      this.SmartphoneList = data;
    });
  }

}
