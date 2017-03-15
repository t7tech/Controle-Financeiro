(function () {
    'use strict';

    angular.module('confin.ui')
           .directive("compareTo", [function () {
               return {
                   require: "ngModel",
                   restrict: "A",
                   link: function (scope, element, attrs, ngModel) {

                       ngModel.$parsers.unshift(function (value) {

                           if (value.length > 0) {

                               var isValid = scope.$eval(attrs.compareTo) == value;

                               ngModel.$setValidity("compare", isValid);

                               return isValid ? value : undefined;
                           }

                       });

                       // Force-trigger the parsing pipeline.
                       scope.$watch(attrs.compareTo, function (newValue, oldValue, scope) {

                           if (newValue == undefined) return;

                           if (newValue.length > 0)
                               ngModel.$setViewValue(ngModel.$viewValue);

                       });

                   }
               };
           }]);

})();