using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;
using Newtonsoft.Json;
using SharpDX;

namespace Radar;

[Submenu]
public class DebugSettings
{
    public ToggleNode DrawHeightMap { get; set; } = new ToggleNode(false);
    public ToggleNode DisableHeightAdjust { get; set; } = new ToggleNode(false);
    public ToggleNode SkipNeighborFill { get; set; } = new ToggleNode(false);
    public ToggleNode SkipEdgeDetector { get; set; } = new ToggleNode(false);
    public ToggleNode SkipRecoloring { get; set; } = new ToggleNode(false);
    public ToggleNode DisableDrawRegionLimiting { get; set; } = new ToggleNode(false);
    public ToggleNode IgnoreFullscreenPanels { get; set; } = new ToggleNode(false);
}

[Submenu]
public class WorldPathSettings
{
    public ToggleNode ShowPathsToTargets { get; set; } = new ToggleNode(true);
    public ToggleNode ShowPathsToTargetsOnlyWithClosedMap { get; set; } = new ToggleNode(true);
    public ToggleNode UseRainbowColorsForPaths { get; set; } = new ToggleNode(true);
    public ColorNode DefaultPathColor { get; set; } = new ColorNode(Color.Red);
    public ToggleNode OffsetPaths { get; set; } = new ToggleNode(true);
    public RangeNode<float> PathThickness { get; set; } = new RangeNode<float>(1, 1, 20);
    public RangeNode<int> DrawEveryNthSegment { get; set; } = new RangeNode<int>(1, 1, 10);
}

[Submenu]
public class PathfindingSettings
{
    public ToggleNode ShowPathsToTargetsOnMap { get; set; } = new ToggleNode(true);
    public ColorNode DefaultMapPathColor { get; set; } = new ColorNode(Color.Green);
    public ToggleNode UseRainbowColorsForMapPaths { get; set; } = new ToggleNode(true);
    public ToggleNode ShowAllTargets { get; set; } = new ToggleNode(true);
    public ToggleNode ShowSelectedTargets { get; set; } = new ToggleNode(true);
    public ToggleNode EnableTargetNameBackground { get; set; } = new ToggleNode(true);
    public ColorNode TargetNameColor { get; set; } = new ColorNode(Color.Violet);
    public WorldPathSettings WorldPathSettings { get; set; } = new WorldPathSettings();
}

public class RadarSettings : ISettings
{
    [JsonIgnore]
    public ButtonNode Reload { get; set; } = new ButtonNode();

    public ToggleNode Enable { get; set; } = new ToggleNode(true);
    public RangeNode<float> CustomScale { get; set; } = new RangeNode<float>(1, 0.1f, 10);
    public ToggleNode DrawWalkableMap { get; set; } = new ToggleNode(true);
    public ColorNode TerrainColor { get; set; } = new ColorNode(new Color(new Vector3(150f) / byte.MaxValue));
    public RangeNode<int> MaximumPathCount { get; set; } = new RangeNode<int>(1000, 0, 1000);
    public PathfindingSettings PathfindingSettings { get; set; } = new PathfindingSettings();
    public DebugSettings Debug { get; set; } = new DebugSettings();
}
