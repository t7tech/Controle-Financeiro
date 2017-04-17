(function () {
    'use strict';

    angular.module('confin.ui')
           .factory('OAuthLoginFactory', function ($http, APP_CONFIG, URL) {

               return {
                   Validate: Validate
               };

               // <summary>
               // 
               // </summary>
               function Validate(params) {
                   return $http({
                       url: URL.OAUTH_VALIDATE_LOGIN,
                       headers: { 'Cache-Control': 'no-cache' },
                       method: "POST",
                       data: params
                   });
               };

           });

})();