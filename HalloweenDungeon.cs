public class HalloweenDungeon : BasePortal // TypeDefIndex: 10552
{
	public GameObjectRef dungeonPrefab; 
	public EntityRef<ProceduralDynamicDungeon> dungeonInstance; 
	[ServerVar] 
	public static float population; 
	public float lifetime; 
	private float secondsUsed; 
	public AnimationCurve radiationCurve; 
	public Translate.Phrase collapsePhrase; 
	public Translate.Phrase mountPhrase; 


	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

	private static void .cctor() { }

}

