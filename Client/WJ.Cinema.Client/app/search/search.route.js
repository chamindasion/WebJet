(function (angular) {
    'use strict';

    var routeConfig = function ($stateProvider) {

        var searchHome = {
            url: '/search',
            templateUrl: 'app/search/search.html',
            controller: 'SearchController',
            controllerAs: 'vm',
            data: {                
            }
        };
        $stateProvider.state('search', searchHome);
    };

    routeConfig.$inject = ['$stateProvider'];

    angular.module('app.search').config(routeConfig);

})(angular);