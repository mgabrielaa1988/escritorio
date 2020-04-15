#ifndef REGISTROS_H_INCLUDED
#define REGISTROS_H_INCLUDED

typedef struct
{
    int id_registro;
    int id_empleado;
    int codTarea;
    int cantidadHoras;
    float precioUnitario;
} sRegistro;

sRegistro* new_Registro();

sRegistro* new_Registro_Parameters(int idNew,int idEmpleadoNew,int codTareaNew,int cantHorasNew, float precioUnitarioNew);

int loadRegistros(ArrayList* this);

int listarRegistro(sRegistro* registro);

int listarRegistros(ArrayList* this);

int verificarRegistro(ArrayList* this, int id);

sRegistro* obtenerRegistro(ArrayList* this, int id);

int obtenerRegistroBaja(ArrayList* this, int id, sRegistro* auxRegistro);

int eliminarRegistro(ArrayList* registroList);
#endif // REGISTROS_H_INCLUDED
