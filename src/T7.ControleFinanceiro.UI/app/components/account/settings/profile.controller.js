(function () {
    'use strict';

    angular.module('confin.ui')
           .controller('AccountSettingsProfileController', function ($scope, $rootScope, AccountSettingsProfileFactory) {

               $scope.Model = {
                   Name: model.Name,
                   LastName: model.LastName,
                   Email: model.Email,
                   DateBirth: model.DateBirth
               };

               // <summary>
               // 
               // </summary>
               $scope.OnSubmit = function ($event) {
                   try {

                       /*
                        * Prevent Default Action
                        */
                       $event.preventDefault();

                       /*
                        * Send Data to Server
                        */
                       AccountSettingsProfileFactory.Update($scope.Model)
                            .then(function (response) {

                                /*
                                 * Show Success Message
                                 */
                                $rootScope.OnSuccess('Seu perfil foi atualizado.');

                            },
                            function (response) {
                                /*
                                 * Show Success Message
                                 */
                                $rootScope.OnError(response, null, null);
                            });

                   } catch (ex) {
                       /*
                        * Show Success Message
                        */
                       $rootScope.OnError(null, null, 'Não foi possível atualizar seu perfil.');
                   }
               };

           });

})();