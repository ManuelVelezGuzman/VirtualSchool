applicationModule.directive('sortBy',['$log',function($log){
    
    
    
    return {
     
        require: '^stTable',
        restrict:"A"
        
    }
    
}]);