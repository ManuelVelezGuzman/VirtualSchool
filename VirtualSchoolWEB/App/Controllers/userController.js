applicationModule.controller('userController',['$log','$scope','userService',function($log,$scope,userService){
    $scope.users = [];

    $scope.totArray = userService.getUsersArray();
    $scope.myId = $scope.totArray[0];
    
    $scope.generateUsers = function (){
        userService.getUsers();
        $scope.users =  userService.returnNNumberUsers(0,15);
    };
    

      
    $scope.generateUsers();
    
     
    
}]);

