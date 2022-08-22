public class PatternFireworkShell : FireworkShell // TypeDefIndex: 8277
{	public GameObjectRef StarPrefab; // 0x58
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


	public override void Init(MortarFirework firework) { }

	public override void Cleanup() { }

	public override float CalculateFuseLength() { }

	public override void Update() { }

	public override void Explode() { }

	public void .ctor() { }

}

