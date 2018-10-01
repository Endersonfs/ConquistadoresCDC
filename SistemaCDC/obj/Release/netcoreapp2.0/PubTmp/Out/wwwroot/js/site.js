// Write your JavaScript code.
$('#modalAC').on('shown.bs.modal', function ()
{
    $('nombre').focus();
});

var registrar = () =>
{
   // alert("hola");
    var nombre = document.getElementById("nombre").value;
    var apellido = document.getElementById("apellido").value;
    var sexo = document.getElementById("sexo").value;
    var edad = document.getElementById("edad").value;
    var fechanacimiento = document.getElementById("fechanacimiento").value;
    var nombrepadre = document.getElementById("nombrepadre").value;
    var estados = document.getElementById("estado");
    var estado = estados.options[estados.selectedIndex].value;
    var action = "seguromedico/agregarRegistro";
    var seguromedico = new seguromedico(nombre, apellido, sexo, edad, fechanacimiento, nombrepadre, estado,action);
    seguromedico.registrar();
}
