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
                           DateBirth: moment($scope.Model.DateBirth, 'DD/MM/YYYY').format('YYYY-MM-DD')
                       };

                       // Show Sending Element
                       $scope.Sending = true;

                       // Send Data to Server
                       AccountRegisterFactory.Create(model)
                            .then(function (response) {

                                // Redirect to Main Page
                                window.location = '/home';

                            },
                            function (response) {

                                // Show Error
                                $rootScope.OnError(response, 1, 'Desculpe, não foi possível finalizar seu cadastro. Tente novamente.');

                            });

                   } catch (ex) {

                       // Show Error
                       $rootScope.OnError(null, 1, 'Desculpe, não foi possível finalizar seu cadastro. Tente novamente.');

                   }
               };

           });

})();