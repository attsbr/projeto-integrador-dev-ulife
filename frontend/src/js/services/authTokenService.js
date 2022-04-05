app.factory('AuthTokenService', function ($localStorage) {
  return {
    getToken : function () {
      return $localStorage.whiteboardToken;
    },
    setToken: function (token) {
      $localStorage.whiteboardToken = token;
    },
    getRole : function () {
      return $localStorage.whiteboardRole;
    },
    setRole: function (role) {
      $localStorage.whiteboardRole = role;
    },
    reset : function () {
      if($localStorage.whiteboardToken)
        delete $localStorage.whiteboardToken;  
      if($localStorage.whiteboardRole)
        delete $localStorage.whiteboardRole;     
    },
  };
})

