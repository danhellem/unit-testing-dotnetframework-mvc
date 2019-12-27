/// <reference path="../samplewebformapplication/samples/colorcordinator/shirtsandpants.js" />

(function () {

    module('Second Test', {
        setup: function () {
            // setup code
        },
        teardown: function () {
            // teardown code
        }
    });

    test("Dan Two", function () {
        //arrange
        var objColorCordinator = new ColorCordinator();

        //act
        objColorCordinator.RunColorCordinatorForPants("red");
        var result = objColorCordinator.shirtcolor;

        //assert
        strictEqual(result, "pink");
    });   

})();

