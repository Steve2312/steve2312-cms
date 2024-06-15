import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Model } from '../interfaces/model.interface';
import { CreateModel } from '../interfaces/create-model.interface';

@Injectable({
  providedIn: 'root',
})
export class ModelService {
  constructor(private http: HttpClient) {}

  public getModels(): Observable<Model[]> {
    return this.http.get<Model[]>('http://localhost:5198/api/models');
  }

  public createModel(createModel: CreateModel): Observable<Model> {
    return this.http.put<Model>(
      'http://localhost:5198/api/models',
      createModel,
    );
  }
}
