using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Questions.Test
{
    public class Alliance
    {
        [Fact]
        public void InstantBuild()
        {
            var alliance = new AllianceHelp();
            Assert.Equal(0, alliance.allianceHelp(1000,10));
        }

        [Fact]
        public void OneMemberAlliance()
        {
            var alliance = new AllianceHelp();
            Assert.Equal(40, alliance.allianceHelp(100, 1));
        }

        [Fact]
        public void ROunding()
        {
            var alliance = new AllianceHelp();
            Assert.Equal(9, alliance.allianceHelp(999, 11));
        }

        [Fact]
        public void WinAgainstMonster()
        {
            var alliance = new AllianceHelp();
            Assert.Equal(2, alliance.allianceVersusMonster(new [] {110,30,50}, new [] {12,11,20}));
        }

        [Fact]
        public void FailAgainstMonster()
        {
            var alliance = new AllianceHelp();
            Assert.Equal(0, alliance.allianceVersusMonster(new[] { 4,10,10,10 }, new[] { 10,1,1,1 }));
        }
    }
}
