(function () {
    'use strict';

    angular.module('confin.ui')
           .controller('RegisterController', function ($scope, $rootScope) {

               // Model to Form
               $scope.Model = {
                   Email: '',
                   Password: '',
                   ConfirmPassword: '',
                   Name: '',
                   LastName: '',
                   DateBirth: ''
               };

               // <summary>
               // 
               // </summary>
               $scope.OnSubmit = function ($event) {
                   try {

                       $event.preventDefault();

                       console.log($scope.Model.Email);
                       console.log($scope.Model.Password);
                       console.log($scope.Model.ConfirmPassword);
                       console.log($scope.Model.Name);
                       console.log($scope.Model.LastName);
                       console.log($scope.Model.DateBirth);

                   } catch (ex) {

                   }
               };

           });

})();