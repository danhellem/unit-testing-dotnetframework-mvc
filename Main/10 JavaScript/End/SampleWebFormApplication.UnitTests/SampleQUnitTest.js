
/// <reference path="../samplewebformapplication/samples/stateandcountry/statedropdown.js" />
/// <reference path="../samplewebformapplication/scripts/jquery-2.1.3.js"/>

module("State Dropdown Tests:", {
    setup: function () {
        $("#qunit-fixture").append(
                '<select id="countrySelect" name="country">' +
                    '<option value="USA">USA</option>' +
                '</select>' +
                '<select id="stateSelect" name="state">' +
                '</select>'
        );
    }
});

test("test States", function () {    
    //postCountry = '';    
    //postState = '';     
    
    var stateSelect = document.getElementById('stateSelect');     
    
    // the dropdown includes all the states PLUS a 'Select State' option    
    initCountry('US');
    equal(stateSelect.options.length, 62 + 1);

    initCountry('UK');
    equal(stateSelect.options.length, 43 + 1);

    initCountry('CA');
    equal(stateSelect.options.length, 15 + 1);

    initCountry('ZA');
    equal(stateSelect.options.length, 0 + 1);
});