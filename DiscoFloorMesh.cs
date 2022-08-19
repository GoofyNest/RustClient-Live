public class DiscoFloorMesh : MonoBehaviour, IClientComponent // TypeDefIndex: 9440
{	// Fields
	public int GridRows; // 0x18
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

	// Properties
	public int NumTiles { get; }

	// Methods

	// RVA: 0x9C6280 Offset: 0x9C5680 VA: 0x1809C6280
	public void BuildMesh() { }

	// RVA: 0x9C6B00 Offset: 0x9C5F00 VA: 0x1809C6B00
	public int get_NumTiles() { }

	// RVA: 0x9C6280 Offset: 0x9C5680 VA: 0x1809C6280
	private void SetupRuntimeMesh() { }

	// RVA: 0x9C61C0 Offset: 0x9C55C0 VA: 0x1809C61C0
	public void ApplyColourGradient(Gradient gradient, float offset, DiscoFloorMesh.PatternType pattern, DiscoFloorColourLookups lookups) { }

	// RVA: 0x9C5FB0 Offset: 0x9C53B0 VA: 0x1809C5FB0
	private void ApplyColourGradient(Gradient gradient, float offset, float[] colourLookup) { }

	// RVA: 0x9C6830 Offset: 0x9C5C30 VA: 0x1809C6830
	public void SetColour(Color c) { }

	// RVA: 0x9C65B0 Offset: 0x9C59B0 VA: 0x1809C65B0
	public Color SampleColor(DiscoFloorMesh.Corner corner) { }

	// RVA: 0x9C6470 Offset: 0x9C5870 VA: 0x1809C6470
	private Color SampleColor(int index1, int index2, int index3) { }

	// RVA: 0x9C6350 Offset: 0x9C5750 VA: 0x1809C6350
	private void GetCornerTileIndexes(DiscoFloorMesh.Corner corner, out int index1, out int index2, out int index3) { }

	// RVA: 0x9C6920 Offset: 0x9C5D20 VA: 0x1809C6920
	public void ToggleEmission(bool state) { }

	// RVA: 0x9C6A50 Offset: 0x9C5E50 VA: 0x1809C6A50
	public void .ctor() { }

	// RVA: 0x9C6A00 Offset: 0x9C5E00 VA: 0x1809C6A00
	private static void .cctor() { }

}

public enum DiscoFloorMesh.PatternType // TypeDefIndex: 9441
{	// Fields
	public int value__; // 0x0
	public const DiscoFloorMesh.PatternType InOut = 0;
	public const DiscoFloorMesh.PatternType Radial = 1;
	public const DiscoFloorMesh.PatternType Ripple = 2;
	public const DiscoFloorMesh.PatternType Checker = 3;
	public const DiscoFloorMesh.PatternType Block = 4;

}

public enum DiscoFloorMesh.Corner // TypeDefIndex: 9442
{	// Fields
	public int value__; // 0x0
	public const DiscoFloorMesh.Corner TopLeft = 0;
	public const DiscoFloorMesh.Corner TopRight = 1;
	public const DiscoFloorMesh.Corner BottomLeft = 2;
	public const DiscoFloorMesh.Corner BottomRight = 3;

}

