(function () {
    'use strict';

    angular.module('confin.ui')
           .controller('AccountRegisterController', function ($scope, $rootScope, Regex, AccountRegisterFactory) {

               /*
                * Model to Form
                */
               $scope.Model = {
                   Email: '',
                   Password: '',
                   ConfirmPassword: '',
                   Name: '',
                   LastName: '',
                   DateBirth: ''
               };

               /*
                * Regex
                */
               $scope.Regex = {
                   Email: Regex.EMAIL,
                   DateBirth: Regex.DATE['ptBR']
               };

               /*
                * Request Status
                */
               $scope.Status = {
                   Sending: false
               };

               /*
                * Request Message
                */
               $rootScope.message.loading = 'Aguarde...';

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
                       $scope.Status.Sending = true;
                       $rootScope.status.loading = true;

                       // Send Data to Server
                       AccountRegisterFactory.Create(model)
                            .then(function (response) {

                                // Redirect to Main Page
                                window.location = '/home';

                            },
                            function (response) {

                                // Show Error
                                $rootScope.OnError(response, 1, 'Desculpe, não foi possível finalizar seu cadastro. Tente novamente.');
                                $rootScope.status.loading = false;

                            });

                   } catch (ex) {

                       // Show Error
                       $rootScope.OnError(null, 1, 'Desculpe, não foi possível finalizar seu cadastro. Tente novamente.');
                       $rootScope.status.loading = false;

                   }
               };

               // <summary>
               // 
               // </summary>
               $scope.GetMessageNameValidation = function () {
                   try {

                       if ($scope.formCreateAccount.txtName.$error.required)
                           return 'Este campo é obrigatório';

                       if ($scope.formCreateAccount.txtName.$error.minlength)
                           return 'Este campo deve ter entre 3 e 50 caracteres';

                       if ($scope.formCreateAccount.txtName.$error.maxlength)
                           return 'Este campo deve ter entre 3 e 50 caracteres';

                   } catch (ex) {

                   }
               };

               // <summary>
               // 
               // </summary>
               $scope.GetMessageLastNameValidation = function () {
                   try {

                       if ($scope.formCreateAccount.txtLastName.$error.required)
                           return 'Este campo é obrigatório';

                       if ($scope.formCreateAccount.txtLastName.$error.minlength)
                           return 'Este campo deve ter entre 3 e 50 caracteres';

                       if ($scope.formCreateAccount.txtLastName.$error.maxlength)
                           return 'Este campo deve ter entre 3 e 50 caracteres';

                   } catch (ex) {

                   }
               };

               // <summary>
               // 
               // </summary>
               $scope.GetMessageEmailValidation = function () {
                   try {

                       if ($scope.formCreateAccount.txtEmail.$error.required)
                           return 'Este campo é obrigatório';

                       if ($scope.formCreateAccount.txtEmail.$error.pattern)
                           return 'Informe um e-mail válido';

                       if ($scope.formCreateAccount.txtEmail.$error.minlength)
                           return 'Este campo deve ter entre 5 e 50 caracteres';

                       if ($scope.formCreateAccount.txtEmail.$error.maxlength)
                           return 'Este campo deve ter entre 5 e 50 caracteres';

                       if ($scope.formCreateAccount.txtEmail.$error.unique)
                           return 'O e-mail informado está sendo utilizado';

                   } catch (ex) {

                   }
               };

               // <summary>
               // 
               // </summary>
               $scope.GetMessageDateBirthValidation = function () {
                   try {

                       if ($scope.formCreateAccount.txtDateBirth.$error.required)
                           return 'Este campo é obrigatório';

                       if ($scope.formCreateAccount.txtDateBirth.$error.pattern)
                           return 'Informe uma data válida';

                   } catch (ex) {

                   }
               };

               // <summary>
               // 
               // </summary>
               $scope.GetMessagePasswordValidation = function () {
                   try {

                       if ($scope.formCreateAccount.txtPassword.$error.required)
                           return 'Este campo é obrigatório';

                       if ($scope.formCreateAccount.txtPassword.$error.minlength)
                           return 'Este campo deve ter entre 8 e 50 caracteres';

                       if ($scope.formCreateAccount.txtPassword.$error.maxlength)
                           return 'Este campo deve ter entre 8 e 50 caracteres';

                   } catch (ex) {

                   }
               };

               // <summary>
               // 
               // </summary>
               $scope.GetMessageConfirmPasswordValidation = function () {
                   try {

                       if ($scope.formCreateAccount.txtConfirmPassword.$error.required)
                           return 'Este campo é obrigatório';

                       if ($scope.formCreateAccount.txtConfirmPassword.$error.minlength)
                           return 'Este campo deve ter entre 8 e 50 caracteres';

                       if ($scope.formCreateAccount.txtConfirmPassword.$error.maxlength)
                           return 'Este campo deve ter entre 8 e 50 caracteres';

                       if ($scope.formCreateAccount.txtConfirmPassword.$error.compare)
                           return 'As senhas não conferem';

                   } catch (ex) {

                   }
               };

           });

})();