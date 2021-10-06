import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-sealse-bill',
  templateUrl: './sealse-bill.component.html',
  styleUrls: ['./sealse-bill.component.css']
})
export class SealseBillComponent implements OnInit {
  apiurl = "https://localhost:44358/api/";
  selseBill;
  constructor(private http: HttpClient) {
    http.get(this.apiurl + "SelesBill/GetSeals").subscribe(result => {
      this.selseBill = result;
      console.log(this.selseBill);
    })
  }

 
  ngOnInit() {
  }

}
