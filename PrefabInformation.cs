public class PrefabInformation : PrefabAttribute // TypeDefIndex: 11712
{
	public ItemDefinition associatedItemDefinition; 
	public Translate.Phrase title; 
	public Translate.Phrase description; 
	public Sprite sprite; 
	public bool shownOnDeathScreen; 
	public static List<BaseEntity> DeathScreenEntities; 


	protected override Type GetIndexedType() { }

	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

	private static void .cctor() { }

}

