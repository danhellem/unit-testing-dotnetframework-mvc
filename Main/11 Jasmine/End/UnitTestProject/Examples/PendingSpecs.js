
describe("Pending specs", function() {

    xit("can be declared 'xit'", function() {
        expect(true).toBe(false);
    });

    it("can be declared with 'it' but without a function");
    
    it("can be declared by calling 'pending' in the spec body", function () {
        pending();
        expect(true).toBe(false);        
    });

});