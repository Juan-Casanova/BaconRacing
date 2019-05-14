using NSubstitute;
using NUnit.Framework;

namespace Tests
{
	public class MostrarItemTest1
    {
        [Test]
        public void MostrarItemEngine_ShowItems_ShowsItem0_WithNumItemEquals1_AndP1()
        {
			// Arrange
	        var mostrarItem = Substitute.For<IMostrarItem>();
			var engine = new MostrarItemEngine(mostrarItem);

			// Act
			engine.ShowItems(1, numPlayer.p1);

			// Assert
			mostrarItem.Received(1).ShowIconItem(0);
        }

        [Test]

        public void MostrarItemEngine_ShowItems_ShowsItem3_WithNumItemEquals1_AndP2()
        {
            // Arrange
            var mostrarItem = Substitute.For<IMostrarItem>();
            var engine = new MostrarItemEngine(mostrarItem);

            // Act
            engine.ShowItems(1, numPlayer.p2);

            // Assert
            mostrarItem.Received(1).ShowIconItem(3);
        }

        [Test]

        public void MostrarItemEngine_ShowItems_ShowsItem2_WithNumItemEquals2_AndP1()
        {
            // Arrange
            var mostrarItem = Substitute.For<IMostrarItem>();
            var engine = new MostrarItemEngine(mostrarItem);

            // Act
            engine.ShowItems(2, numPlayer.p1);

            // Assert
            mostrarItem.Received(1).ShowIconItem(2);
        }

        [Test]

        public void MostrarItemEngine_ShowItems_ShowsItem2_WithNumItemEquals5_AndP2()
        {
            // Arrange
            var mostrarItem = Substitute.For<IMostrarItem>();
            var engine = new MostrarItemEngine(mostrarItem);

            // Act
            engine.ShowItems(2, numPlayer.p2);

            // Assert
            mostrarItem.Received(1).ShowIconItem(5);
        }

        [Test]

        public void MostrarItemEngine_ShowItems_ShowsItem3_WithNumItemEquals1_AndP1()
        {
            // Arrange
            var mostrarItem = Substitute.For<IMostrarItem>();
            var engine = new MostrarItemEngine(mostrarItem);

            // Act
            engine.ShowItems(3, numPlayer.p1);

            // Assert
            mostrarItem.Received(1).ShowIconItem(1);
        }

        [Test]

        public void MostrarItemEngine_ShowItems_ShowsItem3_WithNumItemEquals4_AndP2()
        {
            // Arrange
            var mostrarItem = Substitute.For<IMostrarItem>();
            var engine = new MostrarItemEngine(mostrarItem);

            // Act
            engine.ShowItems(3, numPlayer.p2);

            // Assert
            mostrarItem.Received(1).ShowIconItem(4);
        }

        [Test]
        public void MostrarItemEngine_ShowItems_ShowsItemDefault_WithNumItemEquals4_AndP2()
        {
            // Arrange
            var mostrarItem = Substitute.For<IMostrarItem>();
            var engine = new MostrarItemEngine(mostrarItem);

            // Act
            engine.ShowItems(4, numPlayer.p1);

            // Assert
            mostrarItem.Received(1).HideAllItems();
        }
    }
}