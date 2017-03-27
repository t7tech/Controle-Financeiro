(function () {
    'use strict';

    angular.module('confin.ui')
           .controller('AccountConfirmEmailController', function ($scope, $rootScope, AccountRegisterFactory) {

               /*
                * Model to Request
                */
               $scope.Model = {
                   UserId: model.UserId,
                   Code: model.Code
               };

               $scope.Sending = false;

               // <summary>
               // 
               // </summary>
               $scope.OnSend = function () {
                   try {

                       /*
                        * Show Sending Element
                        */
                       $scope.Sending = true;

                       /*
                        * Send Data to Server
                        */
                       AccountRegisterFactory.Confirm($scope.Model)
                            .then(function (response) {

                                $scope.Sending = false;


                            },
                            function (response) {

                                $scope.Sending = false;

                                /*
                                 * Show Error
                                 */
                                $rootScope.OnError(response, 2, 'Desculpe, não foi possível finalizar seu cadastro. Tente novamente.');

                            });

                   } catch (ex) {

                       /*
                        * Show Error
                        */
                       $rootScope.OnError(null, 2, 'Desculpe, não foi possível finalizar seu cadastro. Tente novamente.');

                   }
               };

               /*
                * Call Start Function
                */
               $scope.OnSend();

           });

})();