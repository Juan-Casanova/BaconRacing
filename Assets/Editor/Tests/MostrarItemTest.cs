using NSubstitute;
using NUnit.Framework;

namespace Tests
{
	public class MostrarItemTest1
    {
        [Test]
        public void MostrarItemEngine_ShowItems_ShowsItem0_WithNumItemEquals0_AndP1()
        {
			// Arrange
	        var mostrarItem = Substitute.For<IMostrarItem>();
			var engine = new MostrarItemEngine(mostrarItem);

			// Act
			engine.ShowItems(1, numPlayer.p1);

			// Assert
			mostrarItem.Received(1).ShowIconItem(0);
        }
    }
}