public class DiscoFloorMesh : MonoBehaviour, IClientComponent // TypeDefIndex: 11181
{
	public int GridRows;
	public int GridColumns;
	public float GridSize;
	[RangeAttribute]
	public float TestOffset;
	public Color OffColor;
	public MeshRenderer Renderer;
	public bool DrawInEditor;
	public MeshFilter Filter;
	public AnimationCurve customCurveX;
	public AnimationCurve customCurveY;
	private static int powerId;
	private Mesh builtMesh;
	private Color[] colourArray;

	public int NumTiles { get; }


	public void BuildMesh() { }

	public int get_NumTiles() { }

	private void SetupRuntimeMesh() { }

	public void ApplyColourGradient(Gradient gradient, float offset, DiscoFloorMesh.PatternType pattern, DiscoFloorColourLookups lookups) { }

	private void ApplyColourGradient(Gradient gradient, float offset, float[] colourLookup) { }

	public void SetColour(Color c) { }

	public Color SampleColor(DiscoFloorMesh.Corner corner) { }

	private Color SampleColor(int index1, int index2, int index3) { }

	private void GetCornerTileIndexes(DiscoFloorMesh.Corner corner, out int index1, out int index2, out int index3) { }

	public void ToggleEmission(bool state) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum DiscoFloorMesh.PatternType // TypeDefIndex: 11182
{
	public int value__;
	public const DiscoFloorMesh.PatternType InOut = 0;
	public const DiscoFloorMesh.PatternType Radial = 1;
	public const DiscoFloorMesh.PatternType Ripple = 2;
	public const DiscoFloorMesh.PatternType Checker = 3;
	public const DiscoFloorMesh.PatternType Block = 4;

}

public enum DiscoFloorMesh.Corner // TypeDefIndex: 11183
{
	public int value__;
	public const DiscoFloorMesh.Corner TopLeft = 0;
	public const DiscoFloorMesh.Corner TopRight = 1;
	public const DiscoFloorMesh.Corner BottomLeft = 2;
	public const DiscoFloorMesh.Corner BottomRight = 3;

}

