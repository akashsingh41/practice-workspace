var myAngularMVCApp = angular.module('myAngularMVCApp', ['ngRoute']);
myAngularMVCApp.controller('LandingPageController', LandingPageController);
myAngularMVCApp.controller('LoginController', LoginController);
myAngularMVCApp.controller('RegisterController', RegisterController);


myAngularMVCApp.factory('AuthenticationResponseInterceptor', AuthenticationResponseInterceptor);
myAngularMVCApp.factory('LoginFactory', LoginFactory);
myAngularMVCApp.factory('RegistrationFactory', RegistrationFactory);


var configFunction = function ($routeProvider, $httpProvider) {
    $routeProvider.
        when('/routeOne', {
            templateUrl: 'Routes/One'
        })
        .when('/routeTwo/:count', {
            templateUrl: function (params) { return 'Routes/Two?count=' + params.count; }
        })
        .when('/routeThree', {
            templateUrl: 'Routes/Three'
        })
        .when('/login', {
            templateUrl: '/Account/Login',
            Controller: LoginController 
        })
        .when('/register', {
        templateUrl: '/Account/Register',
        controller: RegisterController
        });


    $httpProvider.interceptors.push('AuthenticationResponseInterceptor');
}
configFunction.$inject = ['$routeProvider','$httpProvider'];

myAngularMVCApp.config(configFunction);