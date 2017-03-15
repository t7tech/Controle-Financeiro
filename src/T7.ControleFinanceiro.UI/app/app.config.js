(function () {
    'use strict';

    angular.module('confin.ui')
           .constant('APP_CONFIG', {
               'VERSION': '0.0.1',
               'CURR_ENV': 'dev',
               'SERVICE_URL': ''
           })
           .constant('Regex', {
               CPF: /^(\d{3})\.(\d{3})\.(\d{3})\-(\d{2})$/i,
               EMAIL: /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
           })
           .constant('URL', {
               ACCOUNT_REGISTER_CREATE: '/ajax/register/create'
           })
           .run(function ($rootScope, $location, APP_CONFIG) {

               $rootScope.OnLog = function (args) {
                   console.log(args);
               };

           });
})();