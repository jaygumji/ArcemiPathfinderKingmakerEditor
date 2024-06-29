﻿using System.Collections.Generic;

namespace Arcemi.Models.PathfinderWotr
{
    internal static class WotrSpellSchools
    {
        public static IReadOnlyList<DataOption> Options { get; } = new[] {
            new DataOption("Abjuration"),
            new DataOption("Conjuration"),
            new DataOption("Divination"),
            new DataOption("Enchantment"),
            new DataOption("Evocation"),
            new DataOption("Illusion"),
            new DataOption("Necromancy"),
            new DataOption("Transmutation")
        };

        public static IReadOnlyList<DataOption> Get(string id)
        {
            return DataOption.Get(Options, id, out _);
        }
    }
    public enum SpellSchool
    {
        None,
        Abjuration,
        Conjuration,
        Divination,
        Enchantment,
        Evocation,
        Illusion,
        Necromancy,
        Transmutation,
        Universalist
    }
}