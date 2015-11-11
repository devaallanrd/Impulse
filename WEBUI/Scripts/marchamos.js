
    function GetArduino() {
        $.get("/Home/GetArduino/", function (data) {

            if ((data[1] == null) | (data[1] == "")) {
                GetArduino();
            }
            else {
                
                $("#pulse-id").html(data[1]);
                $("#pulse-prop").html(data[2]); 
                $("#pulse-auto").html(data[3]);
                $("#pulse-vencido").html(data[4]);
                $("#pulse-multas").html(data[5]);
                //hola que hace gfgfg ewewewe
                $("#xyz").trigger('load');
                $("#xyz").trigger('play');

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
                $("#search-id").html(data[cont].ID);
                $("#search-prop").html(data[cont].Propietario);
                $("#search-auto").html(data[cont].Auto);
                $("#search-vencido").html(data[cont].Vencido);
                $("#search-multas").html(data[cont].Multas);
            }
            cont = cont + 1;
        }
        // alert(data[0].Nombre);

    });
}



function RegisterT() {

    var codeR = $('#codeR').val();
    var idR = $('#idR').val();
    var prR = $('#prR').val();
    var auR = $('#auR').val();
    var vdR = $('#vdR').val();

    $.get("/Arduino/Insert", {
        code: codeR,
        id: idR,
        prop: prR,
        aut: auR,
        ven: vdR
    }, function (data) {
        alert(data);
    });
  
   
}




function Register() {
    $.get("/Arduino/GetArduino/", function (data) {

    
        if ((data == null) | (data == "")) {
            Register();
        }
        else {

           
            $("#codeR").val(data);
            $("#xyz").trigger('load');
            $("#xyz").trigger('play');
            setTimeout(function () {
                Register();
            }, 2000);
        }


    });
}