(function () {
    'use strict';

    angular.module('confin.ui')
           .factory('AccountRegisterFactory', function ($http, APP_CONFIG, URL) {

               return {
                   Create: Create,
                   Confirm: Confirm
               };

               // <summary>
               // 
               // </summary>
               function Create(params) {
                   return $http({
                       url: URL.ACCOUNT_REGISTER_CREATE,
                       headers: { 'Cache-Control': 'no-cache' },
                       method: "POST",
                       data: params
                   });
               };

               // <summary>
               // 
               // </summary>
               function Confirm(params) {
                   return $http({
                       url: URL.ACCOUNT_REGISTER_CONFIRM,
                       headers: { 'Cache-Control': 'no-cache' },
                       method: "POST",
                       data: params
                   });
               };

           });

})();