using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using NUnit.Framework;
using ThermoComfort.Data.Models;

[TestFixture]
public class ProductTests
{
    [Test]
    public void Product_Should_Set_And_Get_Properties_Correctly()
    {
        // Arrange
        var product = new Product
        {
            ProductId = 1,
            ProductName = "Test Product",
            Description = "This is a test product",
            ImageUrl = "https://example.com/image.jpg",
            Price = 99.99m,
            Availability = 10,
            Characteristics = "Test Characteristics",
            Brand = "Test Brand",
            CreatedOn = DateTime.Now,
            CategoryId = 2
        };

        // Act & Assert
        Assert.AreEqual(1, product.ProductId);
        Assert.AreEqual("Test Product", product.ProductName);
        Assert.AreEqual("This is a test product", product.Description);
        Assert.AreEqual("https://example.com/image.jpg", product.ImageUrl);
        Assert.AreEqual(99.99m, product.Price);
        Assert.AreEqual(10, product.Availability);
        Assert.AreEqual("Test Characteristics", product.Characteristics);
        Assert.AreEqual("Test Brand", product.Brand);
        Assert.AreEqual(2, product.CategoryId);
    }

    [Test]
    public void Product_Should_Fail_Validation_When_Name_Is_Too_Long()
    {
        // Arrange
        var product = new Product
        {
            ProductName = new string('A', 61) // Exceeding the 60-char limit
        };

        var context = new ValidationContext(product);
        var results = new List<ValidationResult>();

        // Act
        var isValid = Validator.TryValidateObject(product, context, results, true);

        // Assert
        Assert.False(isValid);
        Assert.IsTrue(results.Exists(r => r.ErrorMessage.Contains("The field Име на продукта must be a string with a maximum length of 60")));
    }
}
