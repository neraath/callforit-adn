﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using callforit_adn.Controllers;
using callforit_adn.Models;

namespace callforit_adn.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        private Mock<IEventRepository> eventRepositoryMock;
        private HomeController controller;

        [TestInitialize]
        public void Initialize()
        {
            eventRepositoryMock = new Mock<IEventRepository>();
            controller = new HomeController(eventRepositoryMock.Object);
        }

        [TestMethod]
        public void HomeControllerLoadsEmptyCollectionOfEventsWhenNoneAvailable()
        {
            var events = new List<Event>();
            eventRepositoryMock.SetupGet(x => x.Events).Returns(events);

            var result = (ViewResult)controller.Index();
            Assert.IsNotNull(result.ViewBag.UpcomingConferences, "UpcomingConferences is null.");
            Assert.AreEqual(0, result.ViewBag.UpcomingConferences.Count, "Expected no upcoming conferences.");
        }
    }
}