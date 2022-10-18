import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { Suppliers } from '../Models/SuppliersModel';

@Injectable({
  providedIn: 'root'
})
export class SuppliersServicesService {
  private myAppUrl = 'https://localhost:44390';
  private myApiUrl = '/api/suppliers';
  constructor(private http:HttpClient) { }

  getListSuppliers(): Observable<any> {
    return this.http.get(this.myAppUrl + this.myApiUrl);
  }

  deleteSupplier(id: number): Observable<any> {
    return this.http.delete(this.myAppUrl + this.myApiUrl + "/" + id);
  }

  saveSupplier(supplier: Suppliers): Observable<any> {
    return this.http.post(this.myAppUrl + this.myApiUrl, supplier);
  }

  updateSupplier(id: number, supplier: Suppliers): Observable<any> {
    return this.http.put(this.myAppUrl + this.myApiUrl + "/" + id, supplier);
  }
}
