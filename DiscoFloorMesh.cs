public class DiscoFloorMesh : MonoBehaviour, IClientComponent // TypeDefIndex: 9440
{	public int GridRows; // 0x18
	public int GridColumns; // 0x1C
	public float GridSize; // 0x20
	[RangeAttribute] // RVA: 0x980D0 Offset: 0x974D0 VA: 0x1800980D0
	public float TestOffset; // 0x24
	public Color OffColor; // 0x28
	public MeshRenderer Renderer; // 0x38
	public bool DrawInEditor; // 0x40
	public MeshFilter Filter; // 0x48
	public AnimationCurve customCurveX; // 0x50
	public AnimationCurve customCurveY; // 0x58
	private static int powerId; // 0x0
	private Mesh builtMesh; // 0x60
	private Color[] colourArray; // 0x68

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

public enum DiscoFloorMesh.PatternType // TypeDefIndex: 9441
{	public int value__; // 0x0
	public const DiscoFloorMesh.PatternType InOut = 0;
	public const DiscoFloorMesh.PatternType Radial = 1;
	public const DiscoFloorMesh.PatternType Ripple = 2;
	public const DiscoFloorMesh.PatternType Checker = 3;
	public const DiscoFloorMesh.PatternType Block = 4;

}

public enum DiscoFloorMesh.Corner // TypeDefIndex: 9442
{	public int value__; // 0x0
	public const DiscoFloorMesh.Corner TopLeft = 0;
	public const DiscoFloorMesh.Corner TopRight = 1;
	public const DiscoFloorMesh.Corner BottomLeft = 2;
	public const DiscoFloorMesh.Corner BottomRight = 3;

}

