public class AlignedLineDrawerDecal : AlignedLineDrawer, INotifyLOD // TypeDefIndex: 8879
{	// Fields
	public DeferredDecal decalComponent; // 0x60
	private static Dictionary<Color, Material> colouredVariants; // 0x0
	private Color cachedColour; // 0x68
	private bool isLodShowing; // 0x78

	// Methods

	// RVA: 0xA9E040 Offset: 0xA9D440 VA: 0x180A9E040 Slot: 5
	protected override void AssignMesh() { }

	// RVA: 0xA9E3A0 Offset: 0xA9D7A0 VA: 0x180A9E3A0 Slot: 6
	public override void SetColour(Color c) { }

	// RVA: 0xA9E160 Offset: 0xA9D560 VA: 0x180A9E160
	private Material GetColourMaterial(Color c) { }

	// RVA: 0xA9E490 Offset: 0xA9D890 VA: 0x180A9E490 Slot: 8
	public void Show() { }

	// RVA: 0xA9E310 Offset: 0xA9D710 VA: 0x180A9E310 Slot: 9
	public void Hide() { }

	// RVA: 0xA9E5B0 Offset: 0xA9D9B0 VA: 0x180A9E5B0
	public void .ctor() { }

	// RVA: 0xA9E550 Offset: 0xA9D950 VA: 0x180A9E550
	private static void .cctor() { }

}

