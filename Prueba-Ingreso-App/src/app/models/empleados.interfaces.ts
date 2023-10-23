import { Cargos } from "./cargos.interfaces";
import { Salario } from "./salario.interfaces";

export interface Empleados {
    cedula: number,
    nombre1: string,
    nombre2: string,
    apellido1: string,
    apellido2: string,
    cod_cargo: string,
    id_salario: number,
    cargo: Cargos,
    salario: Salario
}