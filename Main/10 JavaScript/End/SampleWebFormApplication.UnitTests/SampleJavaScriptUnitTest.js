
/// <reference path="../samplewebformapplication/samples/colorcordinator/shirtsandpants.js" />

(function () {

    module('Run Color Cordinator For Pants', {
        setup: function () {
            // setup code
        },
        teardown: function () {
            // teardown code
        }
    });

    test("Pink Expected Red", function () {
        //arrange
        var objColorCordinator = new ColorCordinator();
        
        //act
        objColorCordinator.RunColorCordinatorForPants("red");
        var result = objColorCordinator.shirtcolor;

        //assert
        strictEqual(result, "pink");
    });


    test("Blue Expected Green", function () {
        //arrange
        var objColorCordinator = new ColorCordinator();

        //assert
        objColorCordinator.RunColorCordinatorForPants("blue");
        var result = objColorCordinator.shirtcolor;

        //act
        strictEqual(result, "green");
    });

    test("Green Expected Blue", function () {
        //arrange
        var objColorCordinator = new ColorCordinator();

        //assert
        objColorCordinator.RunColorCordinatorForPants("green");
        var result = objColorCordinator.shirtcolor;

        //act
        strictEqual(result, "blue");
    });

    test("Pink Expected Yellow", function () {
        //arrange
        var objColorCordinator = new ColorCordinator();

        //assert
        objColorCordinator.RunColorCordinatorForPants("pink");
        var result = objColorCordinator.shirtcolor;

        //act
        strictEqual(result, "yellow");
    });

    test("Black Expected White", function () {
        //arrange
        var objColorCordinator = new ColorCordinator();

        //assert
        objColorCordinator.RunColorCordinatorForPants("black");
        var result = objColorCordinator.shirtcolor;

        //act
        strictEqual(result, "white");
    });

    test("White Expected Error", function () {
        //arrange
        var objColorCordinator = new ColorCordinator();

        //assert
        objColorCordinator.RunColorCordinatorForPants("white");
        var result = objColorCordinator.shirtcolor;

        //act
        strictEqual(result, "error");
    });

    test("Empty Expected Error", function () {
        //arrange
        var objColorCordinator = new ColorCordinator();

        //assert
        objColorCordinator.RunColorCordinatorForPants("");
        var result = objColorCordinator.shirtcolor;

        //act
        strictEqual(result, "error");
    });

})();

