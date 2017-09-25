import { Component, OnInit } from '@angular/core';
import { PersonelService } from "../../services/personel.service";

@Component({
    selector: 'app-personel',
    templateUrl: './personel.component.html',
    styleUrls: ['./personel.component.css']
})
export class PersonelComponent implements OnInit {

    personeller: any[];

    constructor(private personelService: PersonelService) { }

    ngOnInit() {
        this.personelService.getPersonel().subscribe(personel =>
            this.personeller = personel);
    }

}
