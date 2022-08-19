public class TickRenderer : MaskableGraphic // TypeDefIndex: 7073
{	// Fields
	public List<TickRenderer.Tick> Ticks; // 0xC8
	private static UIVertex[] quad; // 0x0

	// Methods

	// RVA: 0xFCF310 Offset: 0xFCE710 VA: 0x180FCF310 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0xFCF940 Offset: 0xFCED40 VA: 0x180FCF940
	public void .ctor() { }

	// RVA: 0xFCF8F0 Offset: 0xFCECF0 VA: 0x180FCF8F0
	private static void .cctor() { }

}

public struct TickRenderer.Tick // TypeDefIndex: 7074
{	// Fields
	public float Pos; // 0x0
	public Color Color; // 0x4
	public float Height; // 0x14

}

