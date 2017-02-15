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
           })
           .run(function ($rootScope, $location, APP_CONFIG) {

           });
})();