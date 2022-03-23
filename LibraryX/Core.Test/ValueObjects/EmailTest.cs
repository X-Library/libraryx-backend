using System;
using LibraryX.Api.SharedContext.Exceptions;
using LibraryX.Api.SharedContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.ValueObjects;

[TestClass]
public class EmailTest
{
    [TestMethod]
    public void GivenAValidVerificationCodeEmailShouldBeConfirmed()
    {
        Email email = new("mail@mail.com");
        var code = email.VerificationCode;
        email.ConfirmEmail(code);

        Assert.IsTrue(email.Confirmed);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidVerificationCodeException))]
    public void GivenAnInvalidVerificationCodeShouldThrowInvalidArgumentException()
    {
        Email email = new("mail@mail.com");
        email.ConfirmEmail("2A1C5F89");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GivenAValidVerificationCodeShouldThrowArgumentNullException()
    {
        Email email = new("mail@mail.com");
        email.ConfirmEmail();
    }
}