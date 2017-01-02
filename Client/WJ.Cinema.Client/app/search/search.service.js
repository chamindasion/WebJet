(function (angular) {
    'use strict';

    var searchService = function ($http, wjAppSettings) {

        var getMovies = function (searchCriteria) {            
            return $http.get(wjAppSettings.apiUrl + "movies?searchCriteria=" + searchCriteria)
                .then(function (results) {
                return results.data;
            });
        };        
        
        var getMovieDetail = function (id, type) {            
            return $http.get(wjAppSettings.apiUrl + "movie?id=" + id + "&type=" + type)
                .then(function (results) {
                    return results.data;
                });
        };
        
        var service = {
            getMovies: getMovies,
            getMovieDetail: getMovieDetail
        };
        return service;
    };

    searchService.$inject = ['$http', 'wjAppSettings'];
    angular
        .module('app.search')
        .factory('searchService', searchService);

})(angular);