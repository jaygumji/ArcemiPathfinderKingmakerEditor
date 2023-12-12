﻿namespace Arcemi.Models
{
    public interface IBlueprintMetadataEntry
    {
        string Id { get; }
        BlueprintName Name { get; }
        BlueprintType Type { get; }
        string DisplayName { get; }
        string Path { get; }
    }
}
