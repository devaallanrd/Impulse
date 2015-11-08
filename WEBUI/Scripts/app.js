(function () {

    //Create a module
    var app = angular.module('MyApp');

    app.controller('MyController', function($scope) {

        $scope.yourName = 'Wait';

        $scope.message = 'Hey this works';


        $scope.arduino = function GetArduino() {
            $.get("/Home/GetArduino", function (data) {


                $("#codex").html(data);

                GetArduino();
            });

           }
        });
      
});