/// <reference path="C:\Users\Dell\Desktop\API_Angular\Git\WebSite\NewFolder1/angular/angular.js" />

(function () {
    angular.module('shopExample', ['shopExample.products', 'common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller: "homeController"
        });
        $urlRouterProvider.otherwise('/admin');
    }
})();
