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
        [Fact]
        public void IsContactable_should_false_for_empty()
        {
            // Arrange 
            var contactInfo = new ContactInfo();
            contactInfo.Email = "";
            contactInfo.Phone = "";
            var person = new Person(contactInfo);

            Mock<IRepositoryPerson> repository = new Mock<IRepositoryPerson>();
            repository.Setup(x => x.GetPerson()).Returns(person);

            var servicesPerson = new ServicesPerson(repository.Object);
            

            // Act
            var isContactable = servicesPerson.IsContactable();

            // Assert 
            Assert.False(isContactable);

        }

        [Fact]
        public void IsContactable_should_false_for_null()
        {
            // Arrange 
            var contactInfo = new ContactInfo();
            contactInfo.Email = null;
            contactInfo.Phone = null;
            var person = new Person(contactInfo);

            Mock<IRepositoryPerson> repository = new Mock<IRepositoryPerson>();
            repository.Setup(x => x.GetPerson()).Returns(person);

            var servicesPerson = new ServicesPerson(repository.Object);
            

            // Act
            var isContactable = servicesPerson.IsContactable();

            // Assert 
            Assert.False(isContactable);
        }

        [Fact]
        public void IsContactable_should_true_with_email()
        {
            // Arrange 
            var contactInfo = new ContactInfo();
            contactInfo.Email = "mail@mail.co";
            contactInfo.Phone = null;
            var person = new Person(contactInfo);

            Mock<IRepositoryPerson> repository = new Mock<IRepositoryPerson>();
            repository.Setup(x => x.GetPerson()).Returns(person);

            var servicesPerson = new ServicesPerson(repository.Object);
            

            // Act
            var isContactable = servicesPerson.IsContactable();

            // Assert 
            Assert.True(isContactable);
        }

        [Fact]
        public void IsContactable_should_true_with_phone()
        {
            // Arrange 
            var contactInfo = new ContactInfo();
            contactInfo.Email = null;
            contactInfo.Phone = "123456";
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
