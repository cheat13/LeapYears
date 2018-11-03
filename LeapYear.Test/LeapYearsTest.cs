using System;
using LeapYear.lib;
using Xunit;

namespace LeapYear.Test
{
    public class LeapYearsTest
    {
        [Theory]
        [InlineData(2000, "leap year")]
        [InlineData(1700, "not leap year")]
        [InlineData(1800, "not leap year")]
        [InlineData(1900, "not leap year")]
        [InlineData(2100, "not leap year")]
        [InlineData(2008, "leap year")]
        [InlineData(2012, "leap year")]
        [InlineData(2016, "leap year")]
        [InlineData(2017, "not leap year")]
        [InlineData(2018, "not leap year")]
        [InlineData(2019, "not leap year")]
        public void TestLeapYears(int year, string expected)
        {
            var sut = new LeapYears();
            var result = sut.CheckLeapYears(year);
            Assert.Equal(expected, result);
        }

    }
}
