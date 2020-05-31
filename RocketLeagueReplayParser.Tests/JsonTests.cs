using NUnit.Framework;
using System;

namespace RocketLeagueReplayParser.Tests
{
    [TestFixture]
    public class JsonTests
    {
        [TestCaseSource(typeof(ReplayFileSource), nameof(ReplayFileSource.ReplayFiles))]
        public void CreatePrettyJson(string filePath)
        {
            var replay = Replay.Deserialize(filePath);
            var jsonSerializer = new Serializers.JsonSerializer();
            jsonSerializer.Serialize(replay);
        }

        [TestCaseSource(typeof(ReplayFileSource), nameof(ReplayFileSource.ReplayFiles))]
        public void CreateRawJson(string filePath)
        {
            var replay = Replay.Deserialize(filePath);
            var jsonSerializer = new Serializers.JsonSerializer();
            jsonSerializer.SerializeRaw(replay);
        }
    }
}
