using HttpUtillity.Util;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using System.Net;
using System.Threading.Tasks;

namespace HttpUtilityTest
{
    [TestClass]
    public class HttpUtilTest
    {
        #region > GetAsync

        [TestMethod, TestCategory("Normal")]
        public async Task GetAsyncTest()
        {
            // arrange
            var uri = new Uri("https://www.google.com/");
            var expected = (int)HttpStatusCode.OK;

            // act
            var task = HttpUtil.GetAsync(uri);
            var result = await task;

            // assert
            Assert.AreEqual(expected, result.StatusCode);
        }

        #endregion

        #region > PostAsync

        [TestMethod, TestCategory("Normal")]
        public async Task PostAsyncTest()
        {
            // arrange
            var uri = new Uri("http://www.youtube.com/results");
            var content = "search_query=visualstudio";
            var expected = (int)HttpStatusCode.OK;

            // act
            var task = HttpUtil.PostAsync(uri, content);
            var result = await task;

            // assert
            Assert.AreEqual(expected, result.StatusCode);
        }

        #endregion
    }
}
