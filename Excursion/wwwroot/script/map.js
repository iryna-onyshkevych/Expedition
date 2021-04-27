function initMap() {
    let options = {
        center: {lat: 49.84018787756092, lng: 24.02218512282289},
        zoom: 17
    };
    let info = new google.maps.InfoWindow({
        content: '<h3>Львівський національний університет імені І.Франка</h3> <img src="images/gallery-photo-u4.jpg" alt="service">'
    })
    let mainMap = new google.maps.Map(document.getElementById("map"), options);
    let marker1 = new google.maps.Marker({
        position: {
            lat: 49.83876990605667, 
            lng: 24.020388384844203
        },
        map: mainMap,
        title: 'Університетський парк'
    });
    let marker2 = new google.maps.Marker({
        position: {
            lat: 49.84017263077666, 
            lng: 24.02204327508773
        },
        map: mainMap,
        title: 'Університет'
    });
    marker2.addListener('click', function() {
        info.open(mainMap, marker2);
    });
}