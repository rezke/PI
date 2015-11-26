function IngredientViewModel() {
    var self = this;
    self.ingredientsType = ko.observableArray([]);
    self.quantity = ko.observable();
    self.productIngredients = ko.observableArray([]);

    self.addProductIngredient = function () {
        var productToAdd = self.selectedIngredient();
        productToAdd.Quantity = self.quantity();
        self.productIngredients.push(productToAdd);
    }

    self.removeProductIngredient = function (ingredient) {
        self.productIngredients.remove(ingredient);
    }

    $.getJSON("/Ingredients/GetAllIngredients", function (data) {
        $.each(data, function (index, item) {
            self.ingredientsType.push(item);
        })
    })

    self.selectedIngredient = ko.observable();
   
}
ko.applyBindings(new IngredientViewModel());