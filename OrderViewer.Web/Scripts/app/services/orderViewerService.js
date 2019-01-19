angular.module("orderViewerServiceModule",[])
    .service("orderViewerService",
        ["$http", "$q",
    function ($http, $q) {
        return {
            getAllOrders: function () {
                var deferred = $q.defer();

                $http.get("http://localhost:41728/api/OrderViewer").then(successCallback, errorCallback);

                function successCallback(response) {
                    deferred.resolve(response.data);
                }
                function errorCallback(error) {
                    deferred.reject({
                        errorMessage: error,
                        statusCode: error
                    });
                }
                return deferred.promise;
            }
        }
    }
    ])