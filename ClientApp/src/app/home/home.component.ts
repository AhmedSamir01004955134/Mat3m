import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  
  productNumper: any;
  products: any;
    Catogres: Object;
    FiltarProduct: Object;
    dlevaryName: any;
  Dlevary: Object;
  selesDetalis: selesDetalis[] = [];
  model: selseBill = { Cash: 0, Discount: 0, DlaveryId: 0, DlaveryName: "", OrderOn: 0, Totale: 0, details: [] }
  baseUrl: "https://localhost:44358/";
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get(baseUrl + "api/Product/ProductNews").subscribe(resalt => {
      this.products = resalt;
      this.FiltarProduct = resalt;
    });


    http.get(baseUrl + "api/Product/GetCatogreys").subscribe(resalt => {
      this.Catogres = resalt;

      http.get(baseUrl + "api/Delavry/GetDlevaries").subscribe(resalt => {
        this.Dlevary = resalt;
       
      })
    });

  }
  productChange(catogryID) {
    this.FiltarProduct = this.products.filter(function (productf) {

      return productf.catogryId == catogryID
    })
    
  }

  toogleDelivery() {
    let PopUpMulti = document.querySelector('.multi-pop-up');
    PopUpMulti.classList.toggle("show")
  }

  changDlevary(dlavary) {
    this.model.DlaveryName = dlavary.name;
    this.model.DlaveryId = dlavary.id
    
    this.toogleDelivery()
  }

  addItem(product) {
    if (this.selesDetalis && this.selesDetalis.length > 0) {
      var existingProduct = this.selesDetalis.filter(x => x.product.id === product.id);
      if (existingProduct && existingProduct.length > 0) {
        existingProduct[0].quantity += 1;
        this.calculateDetallis();
        return;
      }
    }
    this.selesDetalis.push(
      {
        product: product,
        quantity: 1,
        totale: product.price

        

      });
    this.calculateDetallis();
  }
  removProduct(index) {
//track by index angular for
    this.selesDetalis.splice(index, 1);
    this.calculateDetallis();
    if (this.model.Discount > this.model.Cash) {
      this.model.Discount = 0;
      this.model.Cash = 0;
      this.model.Cash = this.model.Totale;
    }
  }
  increase(selesDetalis) {
    selesDetalis.quantity += 1;
    selesDetalis.totale =  selesDetalis.product.price;
    this.calculateDetallis();
  }
  dncrease(selesDetalis) {
    if (selesDetalis.quantity <= 1) {
      return;
    }
    selesDetalis.quantity -= 1;
    selesDetalis.totale = selesDetalis.product.price;
    this.calculateDetallis();
  }
  calculateDetallis() {
    if (this.model.Cash = 0) {
      this.model.Discount = 0;
    }
    if (this.model.Discount > this.model.Totale) {
      this.model.Discount = 0; 
    }
    if (this.model.Discount <1) {
      this.model.Discount  = 0;
    }
   
    this.model.Totale = 0;
    for (var i = 0; i < this.selesDetalis.length; i++) {
      this.model.Totale += this.selesDetalis[i].totale * this.selesDetalis[i].quantity;
      this.model.Cash = this.model.Totale - this.model.Discount;
     
    }
    
    
   
  
  }

  clearDeteals() {
    this.selesDetalis = [];
    this.model.Cash = 0;
    this.model.Totale = 0;
    this.model.Discount = 0;
    this.model.DlaveryId = 0;
    this.model.DlaveryName = "";

  }
  SaveSeals(selesDetalis) {

    console.log(selesDetalis);
    this.model.details = selesDetalis;
  
    if (this.selesDetalis.length < 1) {
      return alert("ادخل البيانات");
     
    }
    if (this.model.DlaveryId == 0 ) {
      alert("add dleavary");
      return;
    }
   
   
    
    this.http.post(`${'api/SelesBill/SaveSeals'}`, this.model).subscribe(() => {
      this.clearDeteals();
      alert("تم الحفظ بنجاح");
    },error => {
        alert("خطأ حدث اتناء الحفظ");
      
        
    })
    
   
 
    }


  
  }

class selseBill {
  DlaveryName: string;
  DlaveryId: number;
  Discount: number;
  Cash: number;
  Totale: number;
  OrderOn: number;
  details: selesDetalis[];


}

class selesDetalis {
  product: any;
  quantity: number;
  totale: number;
 

}
