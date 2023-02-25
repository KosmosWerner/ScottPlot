﻿/* Sourced from Neal McKee's Penumbra color theme:
 * https://github.com/nealmckee/penumbra/blob/main/penumbra.tsv
 * https://github.com/nealmckee/penumbra#accent-colour-palettes-2
 */

namespace ScottPlot.Palettes;

public class Penumbra : ISharedPalette
{
    public string Name { get; } = "Penumbra";

    public string Description => "A perceptually uniform color palette " +
        "by Neal McKee: https://github.com/nealmckee/penumbra";

    public SharedColor[] Colors { get; } = SharedColor.FromHex(HexColors);

    private static readonly string[] HexColors =
    {
        "#CB7459", "#A38F2D", "#46A473", "#00A0BE", "#7E87D6", "#BD72A8"
    };
}
