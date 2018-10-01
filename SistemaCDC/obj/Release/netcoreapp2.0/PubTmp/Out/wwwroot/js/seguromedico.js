
class seguromedico {
    constructor(nombre, apellido,sexo, edad,fechanacimiento,nombrepadre,estado,action)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.sexo = sexo;
        this.edad = edad;
        this.fechanacimiento = fechanacimiento;
        this.nombrepadre = nombrepadre;
        this.estado = estado;
        this.action = action;
    }
    agregarRegistro()
    {
        if (this.nombre === "") {
            document.getElementById("nombre").focus();
        }
        else
        {
            if (this.apellido === "") {
                document.getElementById("apellido").focus();
            }
            else
            {
                if (this.sexo === "") {
                    document.getElementById("sexo").focus();
                }
                else {
                    if (this.edad === "") {
                        document.getElementById("edad").focus();
                    }
                    else {
                        if (this.fechanacimiento === "") {
                            document.getElementById("fechanacimiento").focus();
                        }
                        else {
                            if (this.nombrepadre === "") {
                                document.getElementById("nombrepadre").focus();
                            }
                            else {
                                if (this.estado === "0") {
                                    document.getElementById("mensaje").innerHTML = "Seleccione un estado";
                                }
                                else {
                                    alert("el nombre es: " + this.nombre);
                                    var nombre = this.nombre;
                                    var apellido = this.apellido;
                                    var sexo= this.sexo;
                                    var edad = this.edad;
                                    var nombrepadre = this.nombrepadre;
                                    var estado = this.estado;
                                    var fechanacimiento = this.fechanacimiento;
                                    $.ajax({
                                        type: "POST",
                                        url: action,
                                        data:
                                        {
                                            nombre, apellido, sexo, edad, nombrepadre, estado, fechanacimiento
                                        },
                                        success: (response) =>
                                        {

                                        }
                                    });
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
