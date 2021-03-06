﻿using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Stripe.Client.Sdk.Models;
using System.IO;

namespace Stripe.Client.Sdk.Tests.Models
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class EventTests
    {
        [TestMethod]
        public void Event_Parsing()
        {
            // Arrange
            var json = File.ReadAllText("JSON/event.json");

            // Act
            var obj = JsonConvert.DeserializeObject<Event>(json);

            // Assert
            obj.Should().BeAssignableTo<Event>();
            obj.Data.Object.Should().BeAssignableTo<Invoice>();
        }
    }
}
