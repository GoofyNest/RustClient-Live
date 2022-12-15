public class HalloweenDungeon : BasePortal // TypeDefIndex: 10571
{
	public GameObjectRef dungeonPrefab;
	public EntityRef<ProceduralDynamicDungeon> dungeonInstance;
	[ServerVar]
	public static float population;
	[ServerVar]
	public static float lifetime;
	private float secondsUsed;
	private float timeAlive;
	public AnimationCurve radiationCurve;
	public Translate.Phrase collapsePhrase;
	public Translate.Phrase mountPhrase;


	public virtual float GetLifetime() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

	private static void .cctor() { }

}

