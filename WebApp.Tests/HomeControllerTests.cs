using Microsoft.AspNetCore.Mvc;
using System;
using WebApp.Controllers;
using Xunit;

namespace WebApp.Tests
{
    public class HomeControllerTests
    {
        private HomeController _controller;

        HomeController controller
        {
            get
            {
                return _controller ?? (_controller = new HomeController());
            }
            set
            {
                _controller = value;
            }
        }

        [Fact]
        public void IndexViewDataMessage()
        {
            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.Equal("Hello world!", result?.ViewData["Message"]);
        }

        [Fact]
        public void IndexViewResultNotNull()
        {
            // Act
            var result = controller.Index() as ViewResult;
            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void IndexViewNameEqualIndex()
        {
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.Equal("Index", result?.ViewName);
        }
    }
}
