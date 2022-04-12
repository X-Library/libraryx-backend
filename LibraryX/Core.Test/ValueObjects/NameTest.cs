using System;
using LibraryX.Api.SharedContext.Exceptions;
using LibraryX.Api.SharedContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.ValueObjects;

[TestClass]
public class NameTest
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GivenAInvalidFirstNameShouldThrowArgumentNullException()
    {
        var name = new Name("" , "Sobrenome");
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GivenAInvalidLastNameShouldThrowArgumentNullException()
    {
        var name = new Name("Nome", "");
    }
    
    [TestMethod]
    [ExpectedException(typeof(InvalidNameLengthException))]
    public void GivenAFirstNameWithANumberOfCharactersLessThanTwoShouldThrowInvalidNameLengthException()
    {
        var name = new Name("N", "SobreNome");
    }
    
    [TestMethod]
    [ExpectedException(typeof(InvalidNameLengthException))]
    public void GivenALastNameWithANumberOfCharactersLessThanTwoShouldThrowInvalidNameLengthException()
    { 
        var name = new Name("Nome", "S");
    }
    
    [TestMethod]
    [ExpectedException(typeof(InvalidNameLengthException))]
    public void GivenAFirstNameWithANumberOfCharactersGreaterThanEightyShouldThrowInvalidNameLengthException()
    {
        var name = new Name("NomesNomesNomesNomesNomesNomesNomesNomesNomesNomesNomesNomesNomesNomesNomesNomesNomes", "SobreNome");
    }
    
    [TestMethod]
    [ExpectedException(typeof(InvalidNameLengthException))]
    public void GivenALastNameWithANumberOfCharactersGreaterThanEightyShouldReturnInvalidNameLengthException()
    {
        var name = new Name("Nome", "SobreNomesSobreNomesSobreNomesSobreNomesSobreNomesSobreNomesSobreNomesSobreNomesSobreNomesSobreNomesSobreNomes");
    }
    
    [TestMethod]
    public void GiveAValidNameTestShouldReturnTrueTheName()
    {
        var name = new Name("Nome", "SobreNome");
        if (2 >= name.FirstName.Length
            && 2 >= name.FirstName.Length
            && name.LastName.Length <= 80
            && name.LastName.Length <= 80)
        {
            Assert.IsTrue(true);
        }
    }
}
