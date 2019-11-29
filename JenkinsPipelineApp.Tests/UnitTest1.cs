using FluentAssertions;
using System;
using Xunit;

namespace JenkinsPipelineApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            true.Should().BeFalse();
        }
    }
}
