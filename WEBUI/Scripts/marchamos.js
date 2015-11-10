
    function GetArduino() {
        $.get("/Home/GetArduino/", function (data) {


            $("#codex").html(data);

            if ((data == "")) {
                GetArduino();
            }
            else {
              //  $("#xyz").trigger('load');
             //   $("#xyz").trigger('play');
                setTimeout(function () {
                    GetArduino();
                }, 2000);
            }


        });
    }

function getUserData() {
    var s = $('#idU').val();

    $.get("/Arduino/GetUsers/", function (data) {

        var cont = 0;


        while (cont != data.length) {

            if (data[cont].ID == s) {
                $('#nombre').html(data[cont].Propietario);
                $('#tarjeta').html(data[cont].Code);
                $('#auto').html(data[cont].Auto);
                $('#multas').html(data[cont].Multas);
            }
            cont = cont + 1;
        }
        // alert(data[0].Nombre);

    });
}
