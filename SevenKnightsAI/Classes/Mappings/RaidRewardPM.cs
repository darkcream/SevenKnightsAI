﻿using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class RaidRewardPM
    {
        public static readonly PixelMapping MemberListBackground = new PixelMapping
        {
            X = 40,
            Y = 69,
            Color = 1708300,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RewardButton = new PixelMapping
        {
            X = 830,
            Y = 424,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RewardButtonBackground = new PixelMapping
        {
            X = 830,
            Y = 438,
            Color = 16771586,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RewardButtonRedIcon = new PixelMapping
        {
            X = 759,
            Y = 400,
            Color = 12986369,
            Type = MappingType.ANCHOR
        };
    }
}