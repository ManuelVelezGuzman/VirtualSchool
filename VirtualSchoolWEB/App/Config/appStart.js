var applicationModule = angular.module('virtualSchool',['ngRoute','smart-table']);

applicationModule.config(function($routeProvider){
 
   $routeProvider
    .when('/',{
       templateUrl:'Views/Home/homeView.html',
       controller:'homeController'
   }) 
   
    .when('/Users',{
       templateUrl:'Views/Users/userView.html',
       controller:'userController'
       
   }) 
   
    .when('/Catalogs',{
       templateUrl:'Views/Catalogs/catalogView.html',
       controller:'catalogController'
   }) 
    .when('/About',{
       templateUrl:'Views/About/aboutView.html',
       controller:'aboutController'
   }) 
   
    .when('/Contact',{
       templateUrl:'Views/Contact/contactView.html',
       controller:'contactController'
   }) 
});


applicationModule.controller('indexController',['$log',function($log){
    
}]);