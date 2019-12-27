
function HelloWorld() {
    return "Hello World";
};

function ColorCordinator() {
    this.shirtcolor = '';
};

ColorCordinator.prototype.RunColorCordinatorForPants = function(pantscolor)  {
        this.shirtcolor = GetShirtColor(pantscolor);
    };

function GetShirtColor(pantsColor) {   

    if (pantsColor == null || pantsColor == "" || pantsColor == "white") {
        return "error";
    }

        switch (pantsColor) {
            case "red":
                return "pink";

            case "blue":
                return "green";

            case "green":
                return "blue";

            case "pink":
                return "yellow";

            case "black":
                return "white";

            default:
                return "black";
        } 
};
