(function () {
    'use strict';

    angular.module('confin.ui')
           .controller('AccountRegisterController', function ($scope, $rootScope, Regex, AccountRegisterFactory) {

               // Model to Form
               $scope.Model = {
                   Email: '',
                   Password: '',
                   ConfirmPassword: '',
                   Name: '',
                   LastName: '',
                   DateBirth: ''
               };

               $scope.Regex = {
                   Email: Regex.EMAIL
               };

               $scope.Sending = false;

               // <summary>
               // 
               // </summary>
               $scope.OnSubmit = function ($event) {
                   try {

                       // Prevent Default Form Event
                       $event.preventDefault();

                       // Create Model to Ajax
                       var model = {
                           Email: $scope.Model.Email,
                           Password: $scope.Model.Password,
                           ConfirmPassword: $scope.Model.ConfirmPassword,
                           Name: $scope.Model.Name,
                           LastName: $scope.Model.LastName,
                           DateBirth: $scope.Model.DateBirth
                       };

                       // Show Sending Element
                       $scope.Sending = true;

                       // Send Data to Server
                       AccountRegisterFactory.Create(model)
                                             .success(function (response) {

                                             })
                                             .error(function (response) {

                                             });

                   } catch (ex) {

                   }
               };

           });

})();