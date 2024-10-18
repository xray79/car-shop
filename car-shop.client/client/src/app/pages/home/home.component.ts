import { Component, OnInit } from '@angular/core';
import {ApiService} from "../../services/api/api.service";
import { HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [HttpClientModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent implements OnInit {
  public cars: any;

  constructor(private api: ApiService) {
  }

    ngOnInit(): void {
      this.api.getAllCars().subscribe(res => this.cars = res)
    }
}
