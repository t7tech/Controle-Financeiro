(function () {
    'use strict';

    angular.module('confin.ui')
           .constant('APP_CONFIG', {
               'VERSION': '0.0.1',
               'CURR_ENV': 'dev',
               'SERVICE_URL': ''
           })
           .constant('Regex', {
               CPF: /^(\d{3})\.(\d{3})\.(\d{3})\-(\d{2})$/i,
               EMAIL: /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/,
               DATE: {
                   ptBR: /^[0-9]{2}[/][0-9]{2}[/][0-9]{4}$/
               }
           })
           .constant('URL', {
               ACCOUNT_REGISTER_CREATE: '/api/account/create',
               ACCOUNT_REGISTER_CONFIRM: '/api/account/confirm',
               ACCOUNT_CHECK_EMAIL_UNIQUE: '/api/account/uniqueemail',
               OAUTH_VALIDATE_LOGIN: '/api/oauth/login'
           })
           .run(function ($rootScope, $location, APP_CONFIG) {

               /*
                * Object for request status
                */
               $rootScope.status = {
                   loading: false
               };

               /*
                * Object for message text
                */
               $rootScope.message = {
                   loading: 'Loading...'
               };

               /*
                * Function to Show Logs
                */
               $rootScope.OnLog = function (args) {
                   console.log(args);
               };

               /*
                * Show message error
                */
               $rootScope.OnError = function (response, typeMessage, defaultMessage) {

                   if (response) {
                       switch (response.status) {
                           case 400:
                               angular.element('#modal-alert .modal-body').html(message);
                               break;
                           case 500:
                               angular.element('#modal-alert .modal-body').html(defaultMessage);
                               break;
                       }
                   } else {
                       angular.element('#modal-alert .modal-body').html(defaultMessage);
                   }

                   angular.element('#modal-alert').modal('show');

               };

           });
})();