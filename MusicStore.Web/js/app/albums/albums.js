var app = angular.module('app', ['app.albums']);

angular
    .module('app.albums', [])
    .controller('albums', albums);

function albums($scope, $http) {
    var vm = this;

    vm.albums = {
        Results: [],
        TotalCount: 0
    };

    vm.albums = getAlbumsBetweenReleaseDates();

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
        }).then(getResults);
    }

    function getResults(response)
    {
        return response.data;
    }
}

alert('hello world 123');