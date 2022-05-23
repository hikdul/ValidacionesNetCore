# Validaciones
en este corto ejemplo muestro como es el usar validaciones para el .Net.
cada endPoint se explicara a detalle

---
## Validaciones Por Defecto

Estas son las que trae por defecto el Framework. No las use todas.. solo di un ejemplo de su uso.

---
## Validaciones Personalizadas por atributo

de seguro que por estas estas aqui pues con estas es que se generan las validaciones para casos especifico y nos muestra un orden.

La mejor de este tipo de validacion es que es completamente reutilizable

para crearlas debemos seguir los siguientes pasos:

1. Se crea en una carpeta una clase con el final ...attribute (esto indica que es un atributo), esta clase debe heredar de * ValidationAttribute * (yo cree esta clase en la carpeta validaciones, la clase se llama "primeraLetraMayAttribute.cs"); esta clase proviene de:

```C#
System.ComponentModel.DataAnnotations
```
2. Se sobreescribe la funcion 'isValid', esta es donde se creara la validacion en si; se usa la siguiente exprecion para ello (override IsValid + TAB) y obtenemos lo siguiente
    

```C#
        public override bool IsValid(object? value)
        {
            return base.IsValid(value);
        }

```
 Aqui escribimos nuestro codigo de validacion

3. ya solo queda el usar este elemento como decoracion de un atributo.

___

## Validaciones Por Modelo (clase)

estas son validaciones especificas para un modelo. se usan para hacer una validacion de mas de 1 atributo detro de la misma clase. Para crear una validacion por modelo se debe:

1. en la clase o modelo se implementa la interface *IValidableObject* la cual nos entrega una funcion en la que generaremos nuestras validaciones. Al Final todo nos quedaria de la siguiente manera

``` C#
public class clase:IValidableObject
{
    ...
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
}

```
ya dentro de la clase se generan las validaciones de todo el modelo.