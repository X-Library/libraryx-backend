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
        var verificationCode = new VerificationCode();
        Email email = new("mail@mail.com"){VerificationCode = new VerificationCode
        {
            Code = verificationCode.Code,
            ExpirationDate = verificationCode.ExpirationDate,
            HasValue = verificationCode.HasValue
        }};
        email.VerificationCode.ConfirmVerificationCodeValidValueExpirationDate(verificationCode);
        email.ConfirmEmail(email.VerificationCode);

        Assert.IsTrue(email.Confirmed);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidVerificationCodeException))]
    public void GivenAnInvalidVerificationCodeShouldThrowInvalidArgumentException()
    {
        Email email = new("mail@mail.com");
        email.VerificationCode.Code = "2A1C5F89";
        VerificationCode verificationCode = new();
        email.VerificationCode.ConfirmVerificationCodeValidValueExpirationDate(verificationCode);
        email.ConfirmEmail(email.VerificationCode);
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GivenAValidVerificationCodeShouldThrowArgumentNullException()
    {
        Email email = new("");
        email.ConfirmEmail(email.VerificationCode);
    }

    [TestMethod]
    [ExpectedException(typeof(ExceededDateTimeVerificationCodeException))]
    public void GivenAValidVerificationCodeShouldThrowExceededDateTimeVerificationCodeException()
    {
        var verificationCode = new VerificationCode();
        Email email = new("mail@mail.com"){VerificationCode = new VerificationCode
        {
            Code = verificationCode.Code,
            ExpirationDate = DateTime.UtcNow.Date.AddMinutes(0) - TimeSpan.FromMinutes(2)
        }};
        email.VerificationCode.ConfirmVerificationCodeValidValueExpirationDate(verificationCode);
        email.ConfirmEmail(email.VerificationCode);
    }
}