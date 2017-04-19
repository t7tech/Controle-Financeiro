(function () {
    'use strict';

    angular.module('confin.ui')
           .factory('AccountSettingsProfileFactory', function ($http, URL) {
               return {
                   Update: Update
               };

               // <summary>
               // 
               // </summary>
               function Update(params) {
                   try {

                       return $http({
                           url: URL.ACCOUNT_SETTINGS_PROFILE,
                           headers: { 'Cache-Control': 'no-cache' },
                           method: "POST",
                           data: params
                       });

                   } catch (ex) {
                       throw ex;
                   }
               };

           });

})();