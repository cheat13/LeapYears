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

        [Theory]
        [InlineData(1804, "leap year")]
        [InlineData(1808, "leap year")]
        [InlineData(1812, "leap year")]
        [InlineData(1816, "leap year")]
        [InlineData(1820, "leap year")]
        [InlineData(1824, "leap year")]
        [InlineData(1828, "leap year")]
        [InlineData(1832, "leap year")]
        [InlineData(1836, "leap year")]
        [InlineData(1840, "leap year")]
        [InlineData(1844, "leap year")]
        [InlineData(1848, "leap year")]
        [InlineData(1852, "leap year")]
        [InlineData(1856, "leap year")]
        [InlineData(1860, "leap year")]
        [InlineData(1864, "leap year")]
        [InlineData(1868, "leap year")]
        [InlineData(1872, "leap year")]
        [InlineData(1876, "leap year")]
        [InlineData(1880, "leap year")]
        [InlineData(1884, "leap year")]
        [InlineData(1888, "leap year")]
        [InlineData(1892, "leap year")]
        [InlineData(1896, "leap year")]
        [InlineData(1904, "leap year")]
        [InlineData(1908, "leap year")]
        [InlineData(1912, "leap year")]
        [InlineData(1916, "leap year")]
        [InlineData(1920, "leap year")]
        [InlineData(1924, "leap year")]
        [InlineData(1928, "leap year")]
        [InlineData(1932, "leap year")]
        [InlineData(1936, "leap year")]
        [InlineData(1940, "leap year")]
        [InlineData(1944, "leap year")]
        [InlineData(1948, "leap year")]
        [InlineData(1952, "leap year")]
        [InlineData(1956, "leap year")]
        [InlineData(1960, "leap year")]
        [InlineData(1964, "leap year")]
        [InlineData(1968, "leap year")]
        [InlineData(1972, "leap year")]
        [InlineData(1976, "leap year")]
        [InlineData(1980, "leap year")]
        [InlineData(1984, "leap year")]
        [InlineData(1988, "leap year")]
        [InlineData(1992, "leap year")]
        [InlineData(1996, "leap year")]
        [InlineData(2000, "leap year")]
        [InlineData(2004, "leap year")]
        [InlineData(2008, "leap year")]
        [InlineData(2012, "leap year")]
        [InlineData(2016, "leap year")]
        [InlineData(2020, "leap year")]
        [InlineData(2024, "leap year")]
        [InlineData(2028, "leap year")]
        [InlineData(2032, "leap year")]
        [InlineData(2036, "leap year")]
        [InlineData(2040, "leap year")]
        [InlineData(2044, "leap year")]
        [InlineData(2048, "leap year")]
        [InlineData(2052, "leap year")]
        [InlineData(2056, "leap year")]
        [InlineData(2060, "leap year")]
        [InlineData(2064, "leap year")]
        [InlineData(2068, "leap year")]
        [InlineData(2072, "leap year")]
        [InlineData(2076, "leap year")]
        [InlineData(2080, "leap year")]
        [InlineData(2084, "leap year")]
        [InlineData(2088, "leap year")]
        [InlineData(2092, "leap year")]
        [InlineData(2096, "leap year")]
        [InlineData(2104, "leap year")]
        [InlineData(2108, "leap year")]
        [InlineData(2112, "leap year")]
        [InlineData(2116, "leap year")]
        [InlineData(2120, "leap year")]
        [InlineData(2124, "leap year")]
        [InlineData(2128, "leap year")]
        [InlineData(2132, "leap year")]
        [InlineData(2136, "leap year")]
        [InlineData(2140, "leap year")]
        [InlineData(2144, "leap year")]
        [InlineData(2148, "leap year")]
        [InlineData(2152, "leap year")]
        [InlineData(2156, "leap year")]
        [InlineData(2160, "leap year")]
        [InlineData(2164, "leap year")]
        [InlineData(2168, "leap year")]
        [InlineData(2172, "leap year")]
        [InlineData(2176, "leap year")]
        [InlineData(2180, "leap year")]
        [InlineData(2184, "leap year")]
        [InlineData(2188, "leap year")]
        [InlineData(2192, "leap year")]
        [InlineData(2196, "leap year")]
        [InlineData(2204, "leap year")]
        [InlineData(2208, "leap year")]
        [InlineData(2212, "leap year")]
        [InlineData(2216, "leap year")]
        [InlineData(2220, "leap year")]
        [InlineData(2224, "leap year")]
        [InlineData(2228, "leap year")]
        [InlineData(2232, "leap year")]
        [InlineData(2236, "leap year")]
        [InlineData(2240, "leap year")]
        [InlineData(2244, "leap year")]
        [InlineData(2248, "leap year")]
        [InlineData(2252, "leap year")]
        [InlineData(2256, "leap year")]
        [InlineData(2260, "leap year")]
        [InlineData(2264, "leap year")]
        [InlineData(2268, "leap year")]
        [InlineData(2272, "leap year")]
        [InlineData(2276, "leap year")]
        [InlineData(2280, "leap year")]
        [InlineData(2284, "leap year")]
        [InlineData(2288, "leap year")]
        [InlineData(2292, "leap year")]
        [InlineData(2296, "leap year")]
        [InlineData(2304, "leap year")]
        [InlineData(2308, "leap year")]
        [InlineData(2312, "leap year")]
        [InlineData(2316, "leap year")]
        [InlineData(2320, "leap year")]
        [InlineData(2324, "leap year")]
        [InlineData(2328, "leap year")]
        [InlineData(2332, "leap year")]
        [InlineData(2336, "leap year")]
        [InlineData(2340, "leap year")]
        [InlineData(2344, "leap year")]
        [InlineData(2348, "leap year")]
        [InlineData(2352, "leap year")]
        [InlineData(2356, "leap year")]
        [InlineData(2360, "leap year")]
        [InlineData(2364, "leap year")]
        [InlineData(2368, "leap year")]
        [InlineData(2372, "leap year")]
        [InlineData(2376, "leap year")]
        [InlineData(2380, "leap year")]
        [InlineData(2384, "leap year")]
        [InlineData(2388, "leap year")]
        [InlineData(2392, "leap year")]
        [InlineData(2396, "leap year")]
        [InlineData(2400, "leap year")]
        public void TestLeapYearsSince1800To2400(int year, string expected)
        {
            var sut = new LeapYears();
            var result = sut.CheckLeapYears(year);
            Assert.Equal(expected, result);
        }
    }
}
