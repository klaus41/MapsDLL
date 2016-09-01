var routeCoordinates = [];
var map;
var i = 0;
function initMap() {

    map = new google.maps.Map(document.getElementById('map'), {
        zoom: 10,
        mapTypeId: 'terrain'
    });

    coordinates();
}

var coordinates = function () {
    $.ajax({
        url: "http://localhost:52707/coordinates/getcoordinates",
        success: function (result) {
            changeMe(result);

        }
    });
};
var changeMe = function (stuff) {
    for (var i = 0; i < stuff.length; i++) {
        routeCoordinates.push({
            lat: stuff[i].lat,
            lng: stuff[i].lng
        });
        console.log(routeCoordinates);
    }
    //routeCoordinates.splice(0, 1);

    var route = new google.maps.Polyline({
        path: routeCoordinates,
        geodesic: true,
        strokeColor: '#FF0000',
        strokeOpacity: 1.0,
        strokeWeight: 2
    });
    map.panTo({ lat: routeCoordinates[0].lat, lng: routeCoordinates[0].lng });
    var routeCoordinateLength = routeCoordinates.length - 1;
    var marker = new google.maps.Marker({
        position: { lat: routeCoordinates[0].lat, lng: routeCoordinates[0].lng },
        map: map,
        icon: "http://maps.google.com/mapfiles/ms/icons/green-dot.png"
    });

    var endMarker = new google.maps.Marker({
        position: { lat: routeCoordinates[routeCoordinateLength].lat, lng: routeCoordinates[routeCoordinateLength].lng },
        map: map,
        icon: "http://maps.google.com/mapfiles/ms/icons/red-dot.png"
    });
    marker.setMap(map);
    route.setMap(map);
}
