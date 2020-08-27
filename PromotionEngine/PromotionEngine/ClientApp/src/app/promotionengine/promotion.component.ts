import { Component, Inject, ViewChild, ElementRef } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-promotion',
  templateUrl: './promotion.component.html'
})
export class PromotionEngineComponent {

  @ViewChild('Input') InputRef: ElementRef;

  public cartItemIds: string;
  totalPrice: number = 0;
  baseUrl: string;
  httpClient: HttpClient;
  errorMessage: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
    this.httpClient = http;
  }


  onSubmitItems() {

    const input = this.InputRef.nativeElement.value;

    const url = `${this.baseUrl}api/PromotionEngine/checkoutprice?inputSkuIds=${input}`;    

    this.httpClient.get<number>(url).subscribe((result: number) => {
      this.totalPrice = result;
    }, error => console.error(error));
  }
}
