import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Empleados } from 'src/app/models/Empleados.interfaces';

@Injectable({
  providedIn: 'root'
})
export class EmpleadosService {

  url = 'http://localhost:45895/api/Empleados'

  constructor(
    private http: HttpClient
  ) { }
  getAll() {
    return this.http.get<Empleados[]>(this.url);
  }
  add(empleado: Empleados) {
    return this.http.post<boolean>(this.url,empleado);
  }
  update(empleado: Empleados) {
    return this.http.put<boolean>(this.url,empleado);
  }
  delete() {
    return this.http.delete<boolean>(this.url);
  }
}
