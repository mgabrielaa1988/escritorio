#ifndef EMPLEADOS_H_INCLUDED
#define EMPLEADOS_H_INCLUDED

typedef struct
{
    int id;
    char nombre[50];
    char apellido[50];
    int dni;
} sEmpleado;


sEmpleado* new_Empleado();

sEmpleado* new_Empleado_Parameters(int idNew, char* nameNew, char* lastNameNew, int dniNew);

int loadEmpelados(ArrayList* this);

int listarEmpleado(sEmpleado* empleado);

int listarEmpleados(ArrayList* this);

int obtenerId(ArrayList* this);

sEmpleado* obtenerDatos(ArrayList* this);

int addEmpleado(ArrayList* this);

sEmpleado* obtenerEmpleado(ArrayList* this, int id);

int setNombre(sEmpleado* empleado,char*nombre);

int setApellido(sEmpleado* empleado,char*apellido);

int setDNI(sEmpleado* empleado,int dni);

int modificarValores(sEmpleado* auxEmpleado);

int verificarEmpleado(ArrayList* this, int id);

int modificarEmpleado(ArrayList* this);

int obtenerEmpleadoBaja(ArrayList* this, int id, sEmpleado* auxEmpleado);

int bajaFisica(ArrayList* this);

#endif // EMPLEADOS_H_INCLUDED
