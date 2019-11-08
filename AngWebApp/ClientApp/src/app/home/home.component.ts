import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
    constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {}

    clicked() {
        this.http.get(this.baseUrl + 'Customer').subscribe(result => {
            this.customers = result;
        }, error => console.error(error));
    }
    customers: any;
}
