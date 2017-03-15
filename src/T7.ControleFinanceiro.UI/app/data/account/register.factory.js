(function () {
    'use strict';

    angular.module('confin.ui')
           .factory('AccountRegisterFactory', function ($http, APP_CONFIG, URL) {

               return {
                   Create:Create
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

           });

})();