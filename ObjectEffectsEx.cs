public static class ObjectEffectsEx // TypeDefIndex: 11700
{

	[ExtensionAttribute] 
	public static void SingleGib(GameObject obj, GameObject model, GameObject physics) { }

	[ExtensionAttribute] 
	public static void CustomGib(GameObject obj, uint id, Gibbable.ParentingType parentingType = 1) { }

	[ExtensionAttribute] 
	public static void SpawnConditionalGibs(GameObject obj, uint id, Gibbable.ParentingType parentingType = 1) { }

}

