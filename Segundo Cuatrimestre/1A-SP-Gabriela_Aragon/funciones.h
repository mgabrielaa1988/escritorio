
typedef struct{
    int id;
    char nombre[20];
    int horasTrab;
    float sueldo;
}eEmpleado;

int mostrar_Empleado(eEmpleado* auxEmpleado);

eEmpleado* new_Empleado();

eEmpleado* empleado_New_Parameters(int id, char* nombre,int hsTrab);

int parser_parseEmpleados(char* fileName, ArrayList* listaEmpleados);

void em_calcularSueldo(void* p);
