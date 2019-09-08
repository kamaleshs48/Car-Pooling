/*preloader*/
$(window).load(function () { // makes sure the whole site is loaded
    $('#status').fadeOut(); // will first fade out the loading animation
    $('#preloader').delay(350).fadeOut('slow'); // will fade out the white DIV that covers the website.
    $('body').delay(350).css({ 'overflow': 'visible' });
})
/*preloader close*/

/*google map*/
var source, destination;
var directionsDisplay;
var directionsService = new google.maps.DirectionsService();
google.maps.event.addDomListener(window, 'load', function () {
    new google.maps.places.SearchBox(document.getElementById('txtSource'));
    new google.maps.places.SearchBox(document.getElementById('txtDestination'));
    new google.maps.places.SearchBox(document.getElementById('ViaPoint1'));
    new google.maps.places.SearchBox(document.getElementById('ViaPoint2'));
    new google.maps.places.SearchBox(document.getElementById('ViaPoint3'));
    directionsDisplay = new google.maps.DirectionsRenderer({ 'draggable': true });
    
});
function initialize() {
    directionsDisplay = new google.maps.DirectionsRenderer();
    var mapOptions = {
        zoom: 4,
        scrollwheel: false,
        center: new google.maps.LatLng(38.27268854, 65.21484375),
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    directionsDisplay = new google.maps.DirectionsRenderer({ 'draggable': true });
    var map = new google.maps.Map(document.getElementById('dvMap'),
        mapOptions);
    directionsDisplay.setMap(map);
   
}


//google.maps.event.addDomListener(window, 'load', initialize);
google.maps.event.addDomListener(window, 'load', function () { initialize(); });
//google.maps.event.addDomListener(window, 'mousemove', function () { alert('s'); });
function GetRoute() {
    var Delhi = new google.maps.LatLng(28.9750, 77.8258);
    var mapOptions = {
        zoom: 9,
        scrollwheel: false,
        center: Delhi
    };
    map = new google.maps.Map(document.getElementById('dvMap'), mapOptions);
    directionsDisplay.setMap(map);
    directionsDisplay.setPanel(document.getElementById('dvPanel'));

    //*********DIRECTIONS AND ROUTE**********************//
    source = document.getElementById("txtSource").value;
    destination = document.getElementById("txtDestination").value;

    var request = {
        origin: source,
        destination: destination,
        travelMode: google.maps.TravelMode.DRIVING
    };
    directionsService.route(request, function (response, status) {
        if (status == google.maps.DirectionsStatus.OK) {
            directionsDisplay.setDirections(response);
            $("#directionID").show();
            $("#addHeight").css("height", "630px");
        }
    });

    //*********DISTANCE AND DURATION**********************//
    var service = new google.maps.DistanceMatrixService();
    service.getDistanceMatrix({
        origins: [source],
        destinations: [destination],
        travelMode: google.maps.TravelMode.DRIVING,
        unitSystem: google.maps.UnitSystem.METRIC,
        avoidHighways: false,
        avoidTolls: false
    }, function (response, status) {
        if (status == google.maps.DistanceMatrixStatus.OK && response.rows[0].elements[0].status != "ZERO_RESULTS") {
            var distance = response.rows[0].elements[0].distance.text;
            var duration = response.rows[0].elements[0].duration.text;
            var dvDistance = document.getElementById("dvDistance");
            dvDistance.innerHTML = "";
            dvDistance.innerHTML += "Distance: " + distance + "&nbsp;/&nbsp;";
            dvDistance.innerHTML += "Duration:" + duration;

        } else {
            alert("Unable to find the distance via road.");
        }
    });


}

/*google map close*/



/*google map for mobile view*/
var w = Math.max(document.documentElement.clientWidth, window.innerWidth || 0);

var isDraggable = w > 480 ? true : false;
var mapOptions = {
    draggable: isDraggable,
    scrollwheel: false
};
/*google map for mobile view close*/


window.onload = function setValue() {
    var source = document.getElementById("txtSource");
    var destination = document.getElementById("txtDestination");

    var source1 = document.getElementById("txtSource1");
    if (source1.value != "") {
        source1.value = source.value;
    }
    else {
        source1.value = "delhi";
    }
    var destination1 = document.getElementById("txtDestination1");
    if (destination1.value != "") {
        destination1.value = destination.value;
    }
    else {
        destination1.value = "Gurgaon";
    }
    alert(source.value);
    alert(destination.value);
    alert(source1.value);
    alert(destination1.value);
}

function ShowMapBySource_Destination(s, d) {
    var Delhi = new google.maps.LatLng(28.9750, 77.8258);
    var mapOptions = {
        zoom: 9,
        scrollwheel: false,
        center: Delhi
    };
    map = new google.maps.Map(document.getElementById('dvMap'), mapOptions);
    directionsDisplay.setMap(map);
    directionsDisplay.setPanel(document.getElementById('dvPanel'));

    //*********DIRECTIONS AND ROUTE**********************//
    source = s;
    destination = d;
    var request = {
        origin: source,
        destination: destination,
        travelMode: google.maps.TravelMode.DRIVING
    };
    directionsService.route(request, function (response, status) {
        if (status == google.maps.DirectionsStatus.OK) {
            directionsDisplay.setDirections(response);
            $("#directionID").show();
            $("#addHeight").css("height", "630px");
        }
    });

    //*********DISTANCE AND DURATION**********************//
    var service = new google.maps.DistanceMatrixService();
    service.getDistanceMatrix({
        origins: [source],
        destinations: [destination],
        travelMode: google.maps.TravelMode.DRIVING,
        unitSystem: google.maps.UnitSystem.METRIC,
        avoidHighways: false,
        avoidTolls: false
    }, function (response, status) {
        if (status == google.maps.DistanceMatrixStatus.OK && response.rows[0].elements[0].status != "ZERO_RESULTS") {
            var distance = response.rows[0].elements[0].distance.text;
            var duration = response.rows[0].elements[0].duration.text;
            var dvDistance = document.getElementById("dvDistance");
            dvDistance.innerHTML = "";
            dvDistance.innerHTML += "Distance: " + distance + "&nbsp;/&nbsp;";
            dvDistance.innerHTML += "Duration:" + duration;

        } else {
            alert("Unable to find the distance via road.");
        }
    });


}

(function ($) {
    "use strict";
    //End Menu JS Function Taksi Theme
    $(window).on('load', function () {
        $('.selectpicker').selectpicker({
            'selectedText': 'cat'
        });
        // $('.selectpicker').selectpicker('hide');
    });
    //End Menu JS Function Taksi Theme

    /* ==============================================
    Preloader
    =============================================== */

    jQuery(window).load(function () {
        jQuery("#preloader").delay(500).fadeOut(1000);
        jQuery(".preload-gif").addClass('fadeOutUp');
    });

})(jQuery);
/* ===================== */
/* ==============================================
Parallax
=============================================== */

try {
    $(window).stellar({
        horizontalScrolling: false,

    });
} catch (err) {

}

/* ==============================================*/


/* ==============================================
Animated Custom
=============================================== */
try {
    if ($(".animated")[0]) {
        $('.animated').css('opacity', '1');
    }
    $('.triggerAnimation').waypoint(function () {
        var animation = $(this).attr('data-animate');
        $(this).css('opacity', '');
        $(this).addClass("animated " + animation);

    },
        {
            offset: '80%',
            triggerOnce: true
        }
    );
} catch (err) {

}


/* ==============================================
text-rotator
=============================================== */

/*scroll to top*/
$(document).ready(function () {

    $(window).scroll(function () {
        if ($(this).scrollTop() > 900) {
            $('.scrollToTop').fadeIn();
        }
        else {
            $('.scrollToTop').fadeOut();
        }
    });

    $('.scrollToTop').click(function () {
        $('html, body').animate({ scrollTop: 0 }, 800);
        return false;
    });
    $("input:text").focus(function () { $(this).select(); });
    setValue();
});
/*scroll to top close*/



// JavaScript Document

$(document).ready(function () {

    //div load animation
    wow = new WOW(
      {
          animateClass: 'animated',
          offset: 100,
          callback: function (box) {
              console.log("WOW: animating <" + box.tagName.toLowerCase() + ">")
          }
      }
    );
    wow.init();
    document.getElementById('moar').onclick = function () {
        var section = document.createElement('section');
        section.className = 'section--purple wow fadeInDown';
        this.parentNode.insertBefore(section, this);
    };

});

/*lazy load close*/

$('#loginBtn').click(function () {
    $('#loginTab').show();
    $('#forgetPwdTab').hide();
});

$('#forgetPwdbtn').click(function () {
    $('#loginTab').hide();
    $('#forgetPwdTab').show();
});


/*validations*/
$(document).ready(function () {
    $("#register").click(function () {
        var poolerCost = $("#poolerCost").val();
        var seekerCost = $("#seekerCost").val();
        var poolerSeekerCost = $("#poolerSeekerCost").val();
        var from = $("#txtSource").val();
        var to = $("#txtDestination").val();
        var budget = $("#txtBudget").val();
        var carMake = $("#DDLCarmake").val();
        var carModel = $("#DDLCarModel").val();
        var year = $("#txtYear").val();
        var seatsOffered = $("#DDLNoOfSeats").val();
        var regNo = $("#txtRegNo").val();
        var InStart = $("#DDLInStart").val();
        var InEnd = $("#DDLInEnd").val();
        var OutStart = $("#DDLOutStart").val();
        var OutEnd = $("#DDLOutEnd").val();
        var name = $("#name").val();
        var email = $("#email").val();
        var mobile = $("#mobile").val();
        var gender = $("#gender").val();
        var address = $("#address").val();


        var emailReg = /^([\w-\.]+@([\w-]+\.)+[\w-]{2,4})?$/;

        if (name == '' || email == '') {
            alert("Please fill all fields...!!!!!!");
        }
        else if (!(email).match(emailReg)) {
            alert("Invalid Email...!!!!!!");
        }
        else {
            alert("You have Successfully Registered.....");
            $("form")[0].reset();
        }

    });

});
/*validations close*/


/*toggle button*/


function toggleButton(elm) {
    if (elm.className == "on-btn") {
        elm.className = "off-btn";
        document.getElementById("userState").innerHTML = "Active User";
    } else {
        elm.className = "on-btn";
        document.getElementById("userState").innerHTML = "Non-Active User";
    }
}

/*toggle button close*/
/* Get Only Number */

function IsNumeric(evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode
    if (charCode > 31 && (charCode < 48 || charCode > 57))
        return false;

    return true;

}
/* Get Only Number Close */




function WebForm_OnSubmit() {
    if (typeof (ValidatorOnSubmit) == "function" && ValidatorOnSubmit() == false) {
        for (var i in Page_Validators) {
            try {
                var control = document.getElementById(Page_Validators[i].controltovalidate);
                if (!Page_Validators[i].isvalid) {
                  //  control.className = "ErrorControl";

                } else {
                   // control.className = "";
                }
            } catch (e) {alert () }
        }
        return false;
    }
    return true;
}