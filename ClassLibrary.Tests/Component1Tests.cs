using NUnit.Framework;
using RazorClassLibrary1.Components;
using TestContext = Bunit.TestContext;

namespace ClassLibrary.Tests
{
    public class Component1Tests
    {
        [Test]
        public void ShouldRenderComponent()
        {
            var ctx = new TestContext();

            var _ = ctx.RenderComponent<Component1>();
        }

        [Test]
        public void ShouldContainOsVersionAndUserName()
        {
            var ctx = new TestContext();

            var component = ctx.RenderComponent<Component1>();

            Assert.True(component.Markup.Contains("OS Version"));
            Assert.True(component.Markup.Contains("User name"));
        }
    }
}