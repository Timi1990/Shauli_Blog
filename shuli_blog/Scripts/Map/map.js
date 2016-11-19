$(document).ready(function () {
    $.getJSON("/Address/GetUsers", {},
        function (data) {
            addresses = data;
            google.maps.event.addDomListener(window, 'load', initialize);
        });
});



function initialize() {

    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 10,
        center: new google.maps.LatLng(32.0662, 34.7778),
        mapTypeId: google.maps.MapTypeId.ROADMAP
    });

    addresses.forEach(function (address) {
        addMarker(map, address.lat, address.len, address.addressName);
    })
}

function addMarker(map, x, y, content) {
    var infowindow = new google.maps.InfoWindow({
        content: content
    });

    var marker = new google.maps.Marker({
        position: new google.maps.LatLng(x, y),
        map: map
    });

    google.maps.event.addListener(marker, 'click', function () {
        infowindow.open(map, marker);
    });
}
