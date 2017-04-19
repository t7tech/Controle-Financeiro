(function () {
    'use strict';

    /*
     * Attributes
     */
    var timeout = null;

    angular.module('confin.ui')
           .directive('userUnique', function ($http, URL) {
               return {
                   require: 'ngModel',
                   link: function (scope, element, attrs, ngModel) {

                       /*
                        * Catch change Value from Element
                        */
                       scope.$watch(
                           attrs.ngModel,
                           function (newValue, oldValue, scope) {
                               try {

                                   if (newValue.length == 0 && oldValue.length == 0)
                                       throw 'Argumentos vazios';

                                   if (newValue == oldValue)
                                       throw 'Argumentos iguais';

                                   if (timeout != null)
                                       clearTimeout(timeout);

                                   timeout = setTimeout(function () {

                                       /*
                                        * Send Data to Server
                                        */
                                       $http({
                                           method: 'POST',
                                           url: URL.OAUTH_CHECK_EMAIL_UNIQUE,
                                           data: {
                                               'Email': newValue
                                           }
                                       })
                                       .then(function (response, status, headers, cfg) {
                                           ngModel.$setValidity('unique', response.data.isUnique);
                                       },
                                       function (data, status, headers, cfg) {
                                           throw 'username error';
                                       });

                                   }, 500);

                               } catch (ex) {
                                   ngModel.$setValidity('unique', true);
                                   return;
                               }
                           });

                   }
               };
           });

})();