(function (angular) {
    'use strict';
    
    angular
        .module("app", ['ui.router', 'app.search'])
        .config(function ($httpProvider) {

            //$httpProvider.interceptors.push('AuthInterceptorService');
            
            $httpProvider.defaults.useXDomain = true;
            delete $httpProvider.defaults.headers.common['X-Requested-With'];
            $httpProvider.defaults.headers.post['Content-Type'] = 'application/x-www-form-urlencoded; charset=UTF-8';

        })
        .constant('wjAppSettings', {
            apiUrl : "http://localhost:54673/api/"        
    });
})(angular);