using Cards.Commands.API.Commands;
using Cards.Commands.API.Controllers;
using Cards.Mappers;
using Cards.Mappers.Concretes;
using Cards.Repository.Concretes;
using Cards.Repository.Contracts;
using Cards.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace Cards.Tests
{
    public class CardTest
    {
        private Mock<IMediator> Mediator;
        public CardTest()
        {
            Mediator = new Mock<IMediator>();
        }
         

        [Fact]
        public void AddProductToCard_Success_Result()
        {
            var requestModel = new CreateProductToCardCommand()
            {
                CustomerID = new Guid("88549f74-6cef-4a40-86a7-dc34086bdfe1"),
                ProductID = new Guid("88549f74-6cef-4a40-86a7-dc34086bdfe2"),
                Quantity = 3
            };
            var responseModel = new ProductToCardResponse(new Guid("88549f74-6cef-4a40-86a7-dc34086bdfe2"),
                new List<CardItemResponse>() {
                    new CardItemResponse(new Guid("88549f74-6cef-4a40-86a7-dc34086bdfe5"),3)
                },
                true
            );
            Mediator.Setup(x => x.Send(It.IsAny<CreateProductToCardCommand>(), new System.Threading.CancellationToken())).
                ReturnsAsync(responseModel);
            var cardsController = new CardsController(Mediator.Object);

            //Action 
            var response = cardsController.AddProductToCard(requestModel);

            //Assert 
            var result = Assert.IsType<OkObjectResult>(response.Result); 
            Assert.Equal(200, result.StatusCode);
        }
         
    }
}
