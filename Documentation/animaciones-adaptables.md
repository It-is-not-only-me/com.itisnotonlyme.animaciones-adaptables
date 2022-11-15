# Documentacion
---

La estructura esta dada por las siguientes dos interfaces:
 * INodo
 * IInfluencia

### INodo
---
La idea de esta interfaz es el lugar concentrado que determina el valor de un objeto. 

##### Nodo y NodoBehaviour
---
Esta clase es una implementacion de INodo, donde las funciones comunes ya estan implementadas, si se quiere hacer una implementación de INodo se recomiendo heredar de Nodo.

### IInfluencia
---
La idea de esta interfaz es donde cada elemento modifica la influencia, y esta modifica en conjunto al nodo.