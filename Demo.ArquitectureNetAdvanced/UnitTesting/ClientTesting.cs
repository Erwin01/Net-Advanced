using Demo.Arquitecture.Api.Controllers;
using Demo.Arquitecture.Aplication.DTO;
using Demo.Arquitecture.Aplication.Interface;
using Demo.Arquitecture.Domain.Entity;
using Demo.Arquitecture.Infraestructure.Interface;
using Demo.Arquitecture.Transversal.Common;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace UnitTesting
{
    public class ClientTesting
    {

        #region FIELDS

        private readonly Mock<IClientApplication> _repositoryStub = new();
        private readonly Mock<ILogger<ClientController>> _loggerStub = new();
        private readonly Random _random = new();
        //private readonly Mock<IRepository<Client>> genericMockStub = new Mock<IRepository<Client>>();
        //private readonly Mock<ILogger<ClientController>> loggerStub = new Mock<ILogger<ClientController>>();
        //private readonly ClientController _clientController;

        //IClientApplication : IGenericApplication<ClientDTO>

        #endregion


        #region BUILDERS

        #endregion


        #region METHODS

        [Fact]
        public async Task GetItemAsync_WithUnexistingItem_ReturnNotFound()
        {
            // Arrange
            _repositoryStub.Setup(repo => repo.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((Response<ClientDTO>)null);

            var controller = new ClientController(_repositoryStub.Object, _loggerStub.Object);

            // Act
            var result = await controller.GetByIdAsync(It.IsAny<int>());

            // Assert
            result.Should().BeOfType<NotFoundResult>();

        }



        //[Fact]
        //public async Task GetItemsAsync_WithExistingItems_ReturnsAllItems()
        //{
        //    //var expectedItems = new Client[] { };

        //    //genericMockStub.Setup(repository => repository.GetAllAsync());
        //    //var controller = new ClientController((IClientApplication)genericMockStub.Object, loggerStub.Object);

        //    //var result = await controller.GetAllAsync();

        //    //result.Should().BeEquivalentTo(options => options.ComparingByMembers<Client>());
        //}


        //[Fact]
        //public void Get_OK()
        //{
        //    var result =  _clientController.GetAllAsync();

        //    Assert.IsType<OkObjectResult>(result);
        //}


        //private Client CreateClient() 
        //{
        //    return new Client() 
        //    {
        //        ClientId = 1,
        //        Birthdate = System.DateTime.Now,
        //        FirstName = "Erwin",
        //        LastName = "Parales"
        //    };
        //}

        #endregion

    }
}
