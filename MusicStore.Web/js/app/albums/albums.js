var app = angular.module('app', ['app.albums']);

angular
    .module('app.albums', [])
    .controller('albums', albums);

function albums($http, $scope) {
    function getAlbumsBetweenReleaseDates(startdate, enddate) {
        var daterange = {
            'StartDate': startdate || '',
            'EndDate': enddate || ''
        };

        var dto = JSON.stringify(daterange);

        var requestUrl = "/api/music/albums";
        return $http({
            method: 'post',
            url: requestUrl,
            data: dto,
            headers: {
                'Content-Type': 'application/json'
            }
        }).Results;
    }

    $scope.albums = getAlbumsBetweenReleaseDates();
}