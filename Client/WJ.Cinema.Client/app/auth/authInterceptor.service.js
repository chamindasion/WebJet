(function (angular) {
    'use strict';

    

    //// (1) define a request interceptor   
    //angular.module("app").service('AuthInterceptorService',
    //    function JsonpProxyRequestInterceptor(wjAppSettings) {

    //        // (2) define a RegEx to extract raw JSON from the proxy response
    //        var callbackRx = /callback\((.+)\);/gm; 

    //        this.request = function (config) {
    //            // (3) check if this is a request that needs to be proxied
    //            if (config.url === wjAppSettings.cinemaWorldUri && config.method === 'GET') {

    //                // (4) save the API URL, and set request URL to 'https://jsonp.afeld.me/'
    //                var apiUrl = config.url;
    //                config.url = 'https://jsonp.afeld.me/';
    //                config.headers['x-access-token'] = 'sjd1HfkjU83ksdsm3802k';
    //                // (5) set the url= and callback= params for https://jsonp.afeld.me/
    //                config.params = angular.extend({}, config.params || {}, {
    //                    url: apiUrl,
    //                    callback: 'callback'
    //                });

    //                // (6) extract the raw JSON from the proxy response
    //                config.transformResponse.unshift(function (data, headers) {
    //                    var matched = callbackRx.exec(data);
    //                    // (7) pass the raw JSON along to the next transformer
    //                    return matched ? matched[1] : data;
    //                });
    //            }

    //            // (8) return the (possibly modified) config
    //            return config;
    //        };

    //    });

    //angular
    //    .module("app")
    //     .factory("AuthInterceptorService", ['$window', '$q', function ($window, $q) {
             
    //         var authFactory = {};
    //         var request = function (config) {                 
    //             config.headers = config.headers || {};                 
    //             alert(config.method);
    //             if (config.method !== 'OPTIONS')
    //                config.headers['x-access-token'] = 'sjd1HfkjU83ksdsm3802k';                 
    //             return config;
    //         };

    //         var responseError = function(rejection) {
    //             if (rejection.status === 401) {
    //                 console.log("Some Error Here");
    //             }
    //             return $q.reject(rejection);
    //         };

    //         authFactory.request = request;
    //         authFactory.responseError = responseError;
    //         return authFactory;
             
    //     }]);

})(angular);