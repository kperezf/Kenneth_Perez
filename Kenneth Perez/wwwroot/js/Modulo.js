
$("#btnguardar").click(function () {

    var idpropetario = $(".idpropetario").val();
    var nombrepropetario = $(".nombre-propetario").val();
    var descripcion = $(".descripcion").val();
    var fecha = $(".fecha").val();

    var xhr = $.ajax({
        url: "Crearmodulo",
        type: "POST",
        data: {
            "IdPropietario": idpropetario,
            "Nombre": nombrepropetario,
            "Descripcion": descripcion,
            "Fecha": fecha
        }
    });

    xhr.done(function () {
        notif({
            msg: "Modulo Guardado Correctamente",
            type: "success"
        });
    });

    xhr.fail(function () {
        notif({
            msg: "Error al guardar Modulo",
            type: "error"
        });
    });

});