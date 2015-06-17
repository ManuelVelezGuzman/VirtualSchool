applicationModule.directive('scrollLoad',['$log','userService',function($log,userService){
    
    
    var link = function(scope,element,attr){
        
        $log.info(element);
        var completeUsersArray = userService.getUsersArray();
        $log.info(scope.usersArray);
        $log.info(completeUsersArray);
        
        element.context.onscroll = function(){
            if((element.context.scrollTop+ element.context.clientHeight) === element.context.scrollHeight){
                $log.info("We've reached the  bootom !");
                var currPosition = scope.usersArray.length;
                                
                var tmpArray = userService.returnNNumberUsers(currPosition,15);
                
                for(var i = 0; i<  tmpArray.length;i++){
                    scope.usersArray.push(tmpArray[i]);
                }
                
                scope.$apply(scope.usersArray);

                $log.info(scope.usersArray);
            }
        };
        
        
        
        
        
    };
    
    
    
    return {
        restrict: "AEC",
        link : link,
        scope:{
            usersArray : "="
        }
        
        
    }
    
    
}]);