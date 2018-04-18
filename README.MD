## Implementación BDD de CRUD en varios entornos y soportes

La aplicación realiza un crud entero en txt, Json, Xml, SQL , Sql y sql por stored procedures.
Intenta implemetar principios SOLID así como uso de patrones.

#### Patrones implementados hasta ahora:
* Adapter Patter: Usados para utilizar un contratoc omún entre dos tipos diferentes de framework de log (Log4Net y SeriLog).
* Abstract Factory: Usado para devolver una implementación acorde al formato concreto a utilizar de los anteriores mencionados
* Singletons: A modo de prueba, para cargar el memória algunos datos predefinidos.

#### Capas implementadas hasta ahora:
* Common: Tenemos todos los modelos asi como las clases "util" o "helper" para las demás capas
* Business: Nuestra lógica de negocio para cumplimentar los datos faltantes.
* DAO: Acceso a datos de (JSon, xml...)
* Presentation: TODO - capa de web api en aspnet core con una por encima de Angular5.


