(function () {
    angular.module('MessageNotificationsApp')
        .controller("InboundNotifierController", InboundNotifierController);

    InboundNotifierController.$inject = ['$scope', '$location', 'messageService'];

    function InboundNotifierController($scope, $location, messageService) {
        var vm = this;

        this.$onInit = () => {
            messageService.getInboundNotifications().then((inboundNotifications) => {
                $scope.inboundMessages = inboundNotifications;
            });
        }
    }
})();
