(function (angular) {
    'use strict';

    angular
        .module('app')
        .controller('MainController', mainController);

    function mainController() {        
        var vm = this;
        vm.appTitle = "TestTitle";        
    }

})(angular);

