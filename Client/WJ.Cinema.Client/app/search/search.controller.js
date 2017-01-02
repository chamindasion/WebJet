(function (angular) {
    'use strict';

    var searchController = function (searchService, $window) {
        var vm = this;

        vm.getMovies = function (searchCriteria) {            
            var getMoviesPromise = searchService.getMovies(searchCriteria);
            getMoviesPromise.then(function (result) {
                vm.Movies = result;                
            }, function (error) {
                $window.alert('Error on  getCinemaMovies: ' + error.message);
            });
        };

        vm.showPriceModal = function (movie, type) {                                              
            var getMovieDetailPromise = searchService.getMovieDetail(movie.id, type);
            getMovieDetailPromise.then(function (result) {
                vm.movieDetail = result;                
                $('#viewModal').modal('show');                                
            }, function (error) {
                $window.alert('Error on  getPrice: ' + error.message);
            });
        };
    };

    searchController.$inject = ['searchService', '$window'];

    angular.module('app.search').controller('SearchController', searchController);
})(angular);
