﻿/* A 9-color palette by Arthurits created by lightening the colors in the visible spectrum
 */

namespace ScottPlot.Palettes;

public class LightSpectrum : ISharedPalette
{
    public string Name { get; } = "Light spectrum";

    public string Description { get; } = "A 9-color palette by Arthurits created by lightening the colors in the visible spectrum";

    public SharedColor[] Colors { get; } = SharedColor.FromHex(HexColors);

    private static readonly string[] HexColors =
    {
        "#fce5e6", "#fff8e7", "#fffce8",
        "#eff5e4", "#e7f2e6", "#ddf0f5",
        "#e6f2fc", "#e6eaf7", "#eee0f0"
    };
}
