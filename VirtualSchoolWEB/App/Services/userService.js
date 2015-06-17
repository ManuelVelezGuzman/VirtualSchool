applicationModule.factory('userService',['$log',function($log){
    
    var service = {
     
        getUsers:getUsers,
        setUsersArray : setUsersArray, 
        getUsersArray : getUsersArray,
        returnNNumberUsers:returnNNumberUsers
        
    }
    
    var users = [];
    return service;
    
    
    function getUsers(){
        for(var i = 0 ; i < 100 ; i++){
        users[i] = {
            id : i,
            name : generateRandomName(),
            lastName1: generateLastName(),
            lastName2: generateLastName()
         }    
        }
    }
    
    
    function setUsersArray(array){
        users = null;
        users = array;
    }
    
    function getUsersArray() {
        return users;   
    }
    
    
        
    function generateRandomName(){
      var array = [
        "alejandro", "concha","ernesto","ramiro","jose",
          "felipe","john","antony","web","marisol","isabel",
          "rocio","veronica","manuel","valentin","socorro",
          "paola","roberto","emilio","carlos","wendy"
      ];
        
  
        
      var value = array[Math.round( ( (Math.random() * 20) + 1 ))];
    
    return value; 
    }
    
    
    function generateLastName(){
         var lastNames = [
        "esparza","rodriguez","jimenez","suarez","montes","velez","hernandez",
        "flores","guzman","perez","lopez","gomez","castillo","aguilar","bueno",
        "tirado","toledo","rico","iturbide","hornedo","sanchez"
        ];     
        
        return lastNames[Math.round(((Math.random() * 20) + 1 ))];
    }
    
    
    
    function returnNNumberUsers(index,n){
        var length = n || users.length;
        var tmpUsers=[];
        
        var count=0;
        for(var i = index;i < users.length;i++){
            $log.info("if ("+count+" < "+n+"){");
            if (count < n){
                tmpUsers[count] = {
                    id : i,
                    name : users[i].name,
                    lastName1: users[i].lastName1,
                    lastName2: users[i].lastName2
                };
                count++;
            }else{
                return tmpUsers;
            }
        }
        return tmpUsers;
    }
    
    
}]);