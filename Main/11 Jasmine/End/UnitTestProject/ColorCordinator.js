
/// <reference path="../samplewebformapplication/samples/colorcordinator/shirtsandpants.js" />



    describe("color cordinator will expect", function () {
       
        var objColorCordinator;

        beforeEach(function () {
            objColorCordinator = new ColorCordinator();
        });

        afterEach(function () {
            objColorCordinator = null;
        });      

        it("red pants and will return a pink shirt", function () {
            //act
            objColorCordinator.RunColorCordinatorForPants("red");
            var result = objColorCordinator.shirtcolor;

            //assert (expect)
            expect(result).toBe('pink');
        });

        it("blue pants and will return a green shirt", function () {
            //act
            objColorCordinator.RunColorCordinatorForPants("blue");
            var result = objColorCordinator.shirtcolor;

            //assert (expect)
            expect(result).not.toBe('pink');
            expect(result).toBe('green');
        });

        it("green pants and will return a blue shirt", function () {
            //act
            objColorCordinator.RunColorCordinatorForPants("green");
            var result = objColorCordinator.shirtcolor;

            //assert (expect)
            expect(result).toBe('blue');
        });
        
        it("pink pants and will return a yellow shirt", function () {
            //act
            objColorCordinator.RunColorCordinatorForPants("pink");
            var result = objColorCordinator.shirtcolor;

            //assert (expect)
            expect(result).toBe('yellow');
        });

        it("black pants and will return a white shirt", function () {
            //act
            objColorCordinator.RunColorCordinatorForPants("black");
            var result = objColorCordinator.shirtcolor;

            //assert (expect)
            expect(result).toBe('white');
        });

        it("any other pants and will return a black shirt", function () {
            //act
            objColorCordinator.RunColorCordinatorForPants("other");
            var result = objColorCordinator.shirtcolor;

            //assert (expect)
            expect(result).toBe('black');
        });

        it("null and will return an error value", function () {
            //act
            objColorCordinator.RunColorCordinatorForPants(null);
            var result = objColorCordinator.shirtcolor;

            //assert (expect)
            expect(result).toBe('error');
        });

        it("empty string and will return an error value", function () {
            //act
            objColorCordinator.RunColorCordinatorForPants('');
            var result = objColorCordinator.shirtcolor;

            //assert (expect)
            expect(result).toBe('error');
        });

        it("white pants and will return an error value", function () {
            //act
            objColorCordinator.RunColorCordinatorForPants('white');
            var result = objColorCordinator.shirtcolor;

            //assert (expect)
            expect(result).toBe('error');
        });

    });

