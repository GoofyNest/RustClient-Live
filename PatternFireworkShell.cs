public class PatternFireworkShell : FireworkShell // TypeDefIndex: 8277
{	// Fields
	public GameObjectRef StarPrefab; // 0x58
	public AnimationCurve StarCurve; // 0x60
	public float Duration; // 0x68
	public float Scale; // 0x6C
	[HeaderAttribute] // RVA: 0xA4AB0 Offset: 0xA3EB0 VA: 0x1800A4AB0
	[MinMaxAttribute] // RVA: 0xA4AB0 Offset: 0xA3EB0 VA: 0x1800A4AB0
	public MinMax RandomSaturation; // 0x70
	[MinMaxAttribute] // RVA: 0xA4E20 Offset: 0xA4220 VA: 0x1800A4E20
	public MinMax RandomValue; // 0x78
	public float FuseLength; // 0x80
	private List<PatternFireworkStar> _stars; // 0x88
	private TimeSince _timeSinceExploded; // 0x90
	private Quaternion _direction; // 0x94
	private bool _completed; // 0xA4
	private PatternFirework.Design _design; // 0xA8

	// Methods

	// RVA: 0x9473C0 Offset: 0x9467C0 VA: 0x1809473C0 Slot: 6
	public override void Init(MortarFirework firework) { }

	// RVA: 0x946EB0 Offset: 0x9462B0 VA: 0x180946EB0 Slot: 8
	public override void Cleanup() { }

	// RVA: 0x946E20 Offset: 0x946220 VA: 0x180946E20 Slot: 10
	public override float CalculateFuseLength() { }

	// RVA: 0x947AC0 Offset: 0x946EC0 VA: 0x180947AC0 Slot: 7
	public override void Update() { }

	// RVA: 0x946F10 Offset: 0x946310 VA: 0x180946F10 Slot: 9
	public override void Explode() { }

	// RVA: 0x947FC0 Offset: 0x9473C0 VA: 0x180947FC0
	public void .ctor() { }

}

