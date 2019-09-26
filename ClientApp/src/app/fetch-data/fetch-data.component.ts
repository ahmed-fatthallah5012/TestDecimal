import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
    public id: number;

    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        http.get<number>(baseUrl + 'api/SampleData').subscribe(result => {
      this.id = result;
    }, error => console.error(error));
  }
}

