(function () {
    'use strict';

    angular.module('confin.ui')
           .controller('OAuthLoginController', function ($scope, $rootScope, Regex, OAuthLoginFactory) {

               /*
                * Model to Form
                */
               $scope.Model = {
                   Email: 'emei',
                   Password: 'senha',
                   Remember: false
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
                           Remember: $scope.Model.Remember
                       };

                       // Show Sending Element
                       $scope.Status.Sending = true;
                       $rootScope.status.loading = true;

                       // Send Data to Server
                       OAuthLoginFactory.Validate(model)
                            .then(function (response) {

                                switch (parseInt(response.data.status)) {
                                    case 0:

                                        /*
                                         * Check if has Redirect Page
                                         */
                                        var redirect = decodeURIComponent(window.location.search).toLowerCase();
                                        if (redirect)
                                            // Redirect to Page
                                            window.location = redirect.replace('?returnurl=', '');
                                        else
                                            // Redirect to Main Page
                                            window.location = '/home';

                                        break;
                                    case 1:
                                        // Redirect to Lockout Page
                                        window.location = '/lockout';
                                        break;
                                    case 2:
                                        // Redirect to TwoFactory Page
                                        window.location = '/oauth/twofactory/sendcode?u=/home&r=false';
                                        break;
                                    default:
                                        break;
                                }

                            },
                            function (response) {

                                // Show Error
                                $rootScope.OnError(response.data, 1, 'Desculpe, não foi possível finalizar seu cadastro. Tente novamente.');
                                $rootScope.status.loading = false;

                            });

                   } catch (ex) {

                       // Show Error
                       $rootScope.OnError(null, 1, 'Desculpe, não foi possível finalizar seu cadastro. Tente novamente.');
                       $rootScope.status.loading = false;

                   }
               };

           });

})();