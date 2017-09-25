import { Injectable } from '@angular/core';
import { Http } from "@angular/http";


import 'rxjs/add/operator/map';

@Injectable()
export class PersonelService {

    constructor(private http: Http) { }

    getPersonel() {
        return this.http.get('/api/Personel')
        .map(res => res.json());
    }

}
