using Moq;
using System;
using tra_core_1.Business;
using tra_core_1.Model;
using tra_core_1.Repository;
using Xunit;

namespace tra_core_1.Tests
{
    public class ServicesPersonTest
    {
        [Theory]
        [InlineData("","")]
        [InlineData(null, "")]
        [InlineData("", null)]
        [InlineData(null, null)]
        public void IsContactable_should_false_for_empty_and_null(String email, String phone)
        {
            // Arrange 
            var contactInfo = new ContactInfo();
            contactInfo.Email = email;
            contactInfo.Phone = phone;
            var person = new Person(contactInfo);

            Mock<IRepositoryPerson> repository = new Mock<IRepositoryPerson>();
            repository.Setup(x => x.GetPerson()).Returns(person);

            var servicesPerson = new ServicesPerson(repository.Object);
            

            // Act
            var isContactable = servicesPerson.IsContactable();

            // Assert 
            Assert.False(isContactable);

        }


        [Theory]
        [InlineData("mail@mail.co", null)]
        [InlineData(null, "123456")]
        [InlineData("mail@mail.co", "123456")]
        public void IsContactable_should_true_with_any(String email, String phone)
        {
            // Arrange 
            var contactInfo = new ContactInfo();
            contactInfo.Email = email;
            contactInfo.Phone = phone;
            var person = new Person(contactInfo);

            Mock<IRepositoryPerson> repository = new Mock<IRepositoryPerson>();
            repository.Setup(x => x.GetPerson()).Returns(person);

            var servicesPerson = new ServicesPerson(repository.Object);
            

            // Act
            var isContactable = servicesPerson.IsContactable();

            // Assert 
            Assert.True(isContactable);
        }

    }
}
