using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RocketLeagueReplayParser.Tests
{
    public static class ReplayFileSource
    {
        public static IEnumerable<string> ReplayFiles
        {
            get
            {
                
                var dir = Path.Combine(Environment.CurrentDirectory, "TestReplays");
                return Directory.EnumerateFiles(dir, "*.replay")
                    .OrderByDescending(x => File.GetCreationTime(x))
                    // Ignore this replay. It crashes RL too
                    .Where(f => !f.Contains("B82DDB624C393A4A425E68AB40DC2450"));
            }
        }
    }
}
