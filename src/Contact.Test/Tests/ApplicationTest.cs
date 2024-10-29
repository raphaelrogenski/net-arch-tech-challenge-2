namespace Contacts.Test.Tests
{
    public class ApplicationTest
    {
        [Fact]
        public void Run_ShouldRunFine()
        {
            // Arrange
            var application = new Api.Application();

            // Act
            application.Run([]);

            // Assert
            Assert.True(true);
        }
    }
}
