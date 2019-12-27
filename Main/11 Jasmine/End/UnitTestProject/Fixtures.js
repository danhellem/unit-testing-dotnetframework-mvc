
/// <reference path="../samplewebformapplication/scripts/jquery-2.1.1.js" />
/// <reference path="./scripts/jasmine-jquery.js" />
/// <reference path="../samplewebformapplication/samples/stateandcountry/statedropdown.js" />

describe("Country list test", function () {    

    beforeEach(function () {
        $('<select id="countrySelect" name="country">' +
                    '<option value="USA">USA</option>' +
                '</select>' +
                '<select id="stateSelect" name="state">' +
                '</select>').appendTo('body');
    });

    afterEach(function () {

    });

    it("US state drop down list to have 63 items", function () {
        var stateSelect = document.getElementById('stateSelect');

        // the dropdown includes all the states PLUS a 'Select State' option    
        initCountry('US');
        expect(stateSelect.options.length).toBe(63);
    });
});