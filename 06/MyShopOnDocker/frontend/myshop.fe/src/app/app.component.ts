import { Component, OnInit } from '@angular/core';
import { WeatherService } from './services/weather.service';
import { TemperatureDto } from './models/TemperatureDto';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'myshop.fe';
  temperatures: TemperatureDto[] = [];
  constructor(private weatherSvc: WeatherService){}

  ngOnInit(): void {
    this.weatherSvc.get().subscribe(res => this.temperatures = res);
  }
}
