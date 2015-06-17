applicationModule.directive('showInfo',[function($log){
   
   return{
       restrict:"E",
       templateUrl:"/Basico/scripts/site/templates/userShowInfoTemplate.html"
   }
    
}]);



applicationModule.directive('editInfo',[function($log){
      return{
       restrict:"E",
       templateUrl:"/Basico/scripts/site/templates/userEditInfoTemplate.html"
   }
    
}]);