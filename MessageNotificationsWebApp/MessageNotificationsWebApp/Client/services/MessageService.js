(function () {
    angular.module('MessageNotificationsApp')
        .factory('messageService', MessageService);

    MessageService.$inject = ['$http', '$q'];

    function MessageService($http, $q) {
        var service = {};

        service.getInboundNotifications = () => {
            var deferred = $q.defer();

            $http({
                method: "GET",
                url: "api/InboundMessages"
            }).then(
                function(d) { deferred.resolve(d.data); },
                function(d) { deferred.reject(d.data); }
            );

            return deferred.promise;
        }

        return service;
    }
})();