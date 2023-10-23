import { Component } from '@angular/core';

import { EmpleadosService } from 'src/app/core/services/empleados/empleados.service';
import { Empleados } from 'src/app/models/Empleados.interfaces';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {

  public empleados: Empleados[] = [];

  constructor(
    public servicioEmpleado: EmpleadosService
  ) { }
  ngOnInit() {
    this.traerTodos();
  }
  traerTodos() {
    this.servicioEmpleado.getAll().subscribe({
      next: (res: Empleados[]) => {
        if (res) {
          this.empleados = res;
        } else {
          console.log("Se ha generado un error.");
        }
      },
      error: () => {
        console.log("Se ha generado un error.");
      }
    });
  }
}
