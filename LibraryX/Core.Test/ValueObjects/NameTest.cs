using System;
using LibraryX.Api.SharedContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.ValueObjects;

[TestClass]
public class NameTest
{
    //Dado um nome vazio ou nullo o teste deve retornar ArgumentNullException
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GivenAnInvalidNameShouldThrowArgumentNullException()
    {
        var name = new Name
        {
            FirstName = "",
            LastName = "Name"
        };
    }


    //Dado um nome contendo um número de caracteres menor do que 2 
    //O teste deve retornar InvalidNameLengthException

    //Dado um nome contendo um número de caracteres maior do que 80 
    //O teste deve retornar InvalidNameLengthException
    
    //Dado um nome válido o teste deve retornar o nome
}