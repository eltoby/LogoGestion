(function () {
    'use strict';

    var app = angular.module('appLogo', ['ngRoute']);

    app.controller('personasController', function () {
        this.listaPersonas = lista;
        this.version = "Alpha";

        this.getTotalGastosBar = function () {
            var total = 0;
            for(var i = 0; i < this.listaPersonas.length; i++)
            {
                var persona = this.listaPersonas[i];
                total += persona.gastosBar;
            }
            return total;
        };

        this.getTotalGastosKiosco = function () {
            var total = 0;
            for(var i = 0; i < this.listaPersonas.length; i++)
            {
                var persona = this.listaPersonas[i];
                total += persona.gastosKiosco;
            }
            return total;
        }

        this.getTotalPagos = function () {
            var total = 0;
            for (var i = 0; i < this.listaPersonas.length; i++) {
                var persona = this.listaPersonas[i];
                total += persona.pago;
            }
            return total;
        }

        this.getTotalSaldosAnt = function () {
            var total = 0;
            for (var i = 0; i < this.listaPersonas.length; i++) {
                var persona = this.listaPersonas[i];
                total += persona.saldoAnt;
            }
            return total;
        }

        this.getTotalSaldos = function () {
            var total = 0;
            for (var i = 0; i < this.listaPersonas.length; i++) {
                var persona = this.listaPersonas[i];
                total += persona.getSaldo();
            }
            return total;
        }

        this.addPersona = function()
        {
//            this.version = "Beta";
            this.listaPersonas.push({ id: 1, nombre: "Nombre", gastosBar: 0, gastosKiosco: 0, pago: 0, saldoAnt: 0, getSaldo: getSaldoPersona });
        }
    });

    var lista = [
        { id:1, nombre: "Persona 1", gastosBar: 10.00, gastosKiosco: 3.50, pago: 10.00, saldoAnt: 40.50, getSaldo: getSaldoPersona },
        { id: 2, nombre: "Persona 2", gastosBar: 15.00, gastosKiosco: 4.25, pago: 20.00, saldoAnt: 30.25, getSaldo: getSaldoPersona },
        { id: 3, nombre: "Persona 3", gastosBar: 25.00, gastosKiosco: 8.00, pago: 15.00, saldoAnt: 104.5, getSaldo: getSaldoPersona }
    ];    
})();

function getSaldoPersona() {
    return this.saldoAnt + this.gastosBar + this.gastosKiosco - this.pago;
}