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
               $scope.IsRequested = false;
               $scope.IsSuccess = false;

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
                                $scope.IsSuccess = true;
                                $scope.IsRequested = true;

                            },
                            function (response) {

                                $scope.Sending = false;
                                $scope.IsSuccess = false;
                                $scope.IsRequested = true;

                            });

                   } catch (ex) {

                       /*
                        * Show Error
                        */
                       $rootScope.OnError(null, 2);
                       $scope.IsSuccess = false;
                       $scope.IsRequested = false;

                   }
               };

               /*
                * Call Start Function
                */
               $scope.OnSend();

           });

})();