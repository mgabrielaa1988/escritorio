

/** \brief Solicita un numero al usuario
 *
 * \param 'numero': valor de tipo float que representa el numero ingresado
 * \return 'numero': valor de tipo float
 *
 */
float pedirNumero();


/** \brief Suma dos valores
 *
 * \param 'numeroA': valor de tipo float ingresado por el usuario que representa un numero
 * \param 'numeroB': valor de tipo float ingresado por el usuario que representa un numero
 * \return 'total': valor de tipo float, el resultado de la suma de 'numeroA' y 'numeroB'
 *
 */
float sumar (float numeroA, float numeroB);


/** \brief Resta dos valores
 *
 * \param 'numeroA': valor de tipo float ingresado por el usuario que representa un numero
 * \param 'numeroB': valor de tipo float ingresado por el usuario que representa un numero
 * \return 'total': valor de tipo float, el resultado de la resta de 'numeroA' y 'numeroB'
 *
 */
float restar (float numeroA, float numeroB);


/** \brief Division de dos valores
 *
 * \param 'numeroA': valor de tipo float ingresado por el usuario que representa el dividendo
 * \param 'numeroB': valor de tipo float ingresado por el usuario que representa el divisor
 * \return 'total': valor de tipo float, el cociente de la division de 'numeroA' y 'numeroB'
 *
 */
float dividir (float numeroA, float numeroB);


/** \brief Multiplicacion de dos valores
 *
 * \param 'numeroA': valor de tipo float ingresado por el usuario que representa el multiplicando
 * \param 'numeroB': valor de tipo float ingresado por el usuario que representa el multiplicador
 * \return 'total': valor de tipo float, el producto de la multiplicacion de 'numeroA' y 'numeroB'
 *
 */
float multiplicar (float numeroA, float numeroB);


/** \brief Factorial de un valor
 *
 * \param 'numeroA': valor de tipo int ingresado por el usuario que representa un numero natural positivo
 * \return 'total': valor de tipo long long int, el factorial de 'numeroA'
 *
 */
long long int factorial (int numeroA);




/** \brief Valida mediante iteracion que el caracter ingresado se encuentre entre
 *         los valores 48 y 57 inclusive de la tabla ASCII.
           Si el valor esta fuera de estos parametros se pide el reingreso del caracter
 * \param opcionMenu: valor del tipo char que representa un caracter
 * \return opcionMenu: valor de tipo char que cumple con los parametros de la funcion
 *
 */
char validarMenu (char opcionMenu);


/** \brief Valida mediante iteracion que el numero ingresado sea diferente de 0 (cero).
 *         Si es igual a 0, llama a la funcion pedirNumero() para que el usuario reingrese el valor
 * \param numeroB: valor de tipo float que representa el divisor de una division
 * \return numeroB: valor de tipo float que cumple con los parametros de la funcion
 *
 */
float validarCero (float numeroB);


/** \brief Valida mediante iteracion que el numero ingresado sea diferente de 0 (cero) y positivo.
 *          Si es igual o menor a 0, llama a la funcion pedirNumero() para que el usuario
 *          reingrese el valor
 * \param numeroA: valor de tipo float que representa un numero a factorizar
 * \return numeroA: valor de tipo float que cumple con los parametros de la funcion
 *
 */
float validarEntPos (float numeroA);

