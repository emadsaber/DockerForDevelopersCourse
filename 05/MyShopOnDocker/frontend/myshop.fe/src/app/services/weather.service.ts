import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { TemperatureDto } from '../models/TemperatureDto';

const backend_url = 'http://localhost:7119';

@Injectable({
  providedIn: 'root',
})
export class WeatherService {
  constructor(private httpClient: HttpClient) {}

  get(): Observable<TemperatureDto[]> {
    return this.httpClient.get<TemperatureDto[]>(`${backend_url}/WeatherForecast`);
  }
}

