(function () {
    'use strict';

    var app = angular.module('appLogo', ['ngRoute']);

    app.factory('saldos', function ($http) {
        return {
            getSaldos: function () {
                var url = "http://localhost:15487/api/Saldos";
                var result = $http.get(url);
                return result;
        //        return [
        //{ Id: 1, Nombre: "Persona 1", GastosBar: 10.00, GastosKiosco: 3.50, Pago: 10.00, SaldoAnt: 40.50, getSaldo: getSaldoPersona },
        //{ Id: 2, Nombre: "Persona 2", GastosBar: 15.00, GastosKiosco: 4.25, Pago: 20.00, SaldoAnt: 30.25, getSaldo: getSaldoPersona },
        //{ Id: 3, Nombre: "Persona 3", GastosBar: 25.00, GastosKiosco: 8.00, Pago: 15.00, SaldoAnt: 104.5, getSaldo: getSaldoPersona }
        //        ];
            }
        };
    });

    app.controller('personasController', function ($scope, saldos) {
        $scope.controller = this;
                saldos.getSaldos().success(function (data) {
                    $scope.controller.listaPersonas = data;
                    $scope.controller.getTotalGastosBar = function () { return getTotal($scope.controller.listaPersonas, 'GastosBar') };
                    $scope.controller.getTotalGastosKiosco = function () { return getTotal($scope.controller.listaPersonas, 'GastosKiosco') };
                    $scope.controller.getTotalPagos = function () { return getTotal($scope.controller.listaPersonas, 'Pago') };
                    $scope.controller.getTotalSaldosAnt = function () { return getTotal($scope.controller.listaPersonas, 'SaldoAnt') };

                    for(var i = 0; i < data.length; i++)
                        $scope.controller.listaPersonas[i].getSaldo = getSaldoPersona;

                    // TODO: Rever
                    this.getTotalSaldos = function () { getTotal($scope.controller.listaPersonas, 'getSaldo') };
        });

        //
        //    var total = 0;
        //    for (var i = 0; i < $scope.listaPersonas.length; i++) {
        //        var persona = $scope.listaPersonas[i];
        //        total += persona.getSaldo();
        //    }
        //    return total;
        //}

        this.addPersona = function()
        {
            this.listaPersonas.push({ id: 1, Nombre: "Nombre", GastosBar: 0, GastosKiosco: 0, Pago: 0, SaldoAnt: 0, getSaldo: getSaldoPersona });
        }
    });
})();

function getTotal(lista, propName) {
    var total = 0;
    for (var i = 0; i < lista.length; i++) {
        var persona = lista[i];
        total += persona[propName];
    }
    return total;
};

function getSaldoPersona() {
    return this.SaldoAnt + this.GastosBar + this.GastosKiosco - this.Pago;
}