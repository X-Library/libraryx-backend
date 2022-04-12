using System;
using LibraryX.Api.SharedContext.Exceptions;
using LibraryX.Api.SharedContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.ValueObjects;

[TestClass]
public class NameTest
{
    //Dado um nome vazio ou nullo o teste deve retornar ArgumentNullException
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GivenAnInvalidFirstNameShouldThrowArgumentNullException()
    {
        Name name = new Name("" , "Sobrenome");
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GivenAnInvalidLastNameShouldThrowArgumentNullException()
    {
        Name name = new Name("Nome", "");
    }
    
    //Dado um nome contendo um número de caracteres menor do que 2 O teste deve retornar InvalidNameLengthException
    [TestMethod]
    [ExpectedException(typeof(InvalidNameLengthException))]
    public void GivenAnFirstNameContainingANumberOfCharactersLessThan2TheTestShouldReturnInvalidNameLengthException()
    {
        Name name = new Name("N", "SobreNome");
    }
    
    [TestMethod]
    [ExpectedException(typeof(InvalidNameLengthException))]
    public void GivenAnLastNameContainingANumberOfCharactersLessThan2TheTestShouldReturnInvalidNameLengthException()
    {
        Name name = new Name("Nome", "S");
    }
    
    //Dado um nome contendo um número de caracteres maior do que 80 O teste deve retornar InvalidNameLengthException
    [TestMethod]
    [ExpectedException(typeof(InvalidNameLengthException))]
    public void GivenAnFirstNameContainingANumberOfCharactersGreaterThan80TestShouldReturnInvalidNameLengthException()
    {
        Name name = new Name("NomesNomesNomesNomesNomesNomesNomesNomesNomesNomesNomesNomesNomesNomesNomesNomesNomes", "SobreNome");
    }
    
    [TestMethod]
    [ExpectedException(typeof(InvalidNameLengthException))]
    public void GivenAnLastNameContainingANumberOfCharactersGreaterThan80TestShouldReturnInvalidNameLengthException()
    {
        Name name = new Name("Nome", "SobreNomesSobreNomesSobreNomesSobreNomesSobreNomesSobreNomesSobreNomesSobreNomesSobreNomesSobreNomesSobreNomes");
    }
    
    //Dado um nome válido o teste deve retornar o nome
    [TestMethod]
    public void GivenAValidNameTheTestShouldReturnTheName()
    {
        Name name = new Name("Nome", "SobreNome");
        Assert.IsTrue(name == new Name("Nome", "Sobrenome"));
    }
}
