$("#btnguardarcat").click(function () {

    var nombrecategoria = $(".nombre-categoria").val();
    var descripcioncategoria = $(".descripcion-categoria").val();
    var fechacategoria = $(".fecha-categoria").val();

    var xhr = $.ajax({
        url: "Crearcateg",
        type: "POST",
        data: {
            "Nombre": nombrecategoria,
            "Descripcion": descripcioncategoria,
            "Fecha": fechacategoria
        }
    });

    xhr.done(function () {
        notif({
            msg: "Categoria Guardada Correctamente",
            type: "success"
        });
    });

    xhr.fail(function () {
        notif({
            msg: "Error al guardar Categoria",
            type: "error"
        });
    });

});