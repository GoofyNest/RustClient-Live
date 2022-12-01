public class PatternFireworkShell : FireworkShell // TypeDefIndex: 9993
{
	public GameObjectRef StarPrefab;
	public AnimationCurve StarCurve;
	public float Duration;
	public float Scale;
	[HeaderAttribute]
	[MinMaxAttribute]
	public MinMax RandomSaturation;
	[MinMaxAttribute]
	public MinMax RandomValue;
	public float FuseLength;
	private List<PatternFireworkStar> _stars;
	private TimeSince _timeSinceExploded;
	private Quaternion _direction;
	private bool _completed;
	private PatternFirework.Design _design;


	public override void Init(MortarFirework firework) { }

	public override void Cleanup() { }

	public override float CalculateFuseLength() { }

	public override void Update() { }

	public override void Explode() { }

	public void .ctor() { }

}

