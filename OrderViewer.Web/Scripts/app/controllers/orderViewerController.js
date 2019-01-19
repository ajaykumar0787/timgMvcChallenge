angular.module("orderViewerControllerModule",[])
    .controller("orderViewerController",
    [
        "$rootScope", "$scope", "orderViewerService",
        function ($rootScope, $scope, orderViewerService) {
            $scope.init = function () {
                $scope.isLoading = true;
                orderViewerService.getAllOrders().then(function (ordersResult) {
                    $scope.isLoading = false;
                    $scope.orders = ordersResult;
                }, function (error) {
                    $scope.isLoading = false;
                    $scope.orderRetrievalError = error;
                });
            }
        }
    ]
    )