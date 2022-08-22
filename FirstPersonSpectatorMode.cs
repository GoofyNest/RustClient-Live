public static class FirstPersonSpectatorMode // TypeDefIndex: 9188
{	private static ViewModel createdViewmodel; // 0x0
	private static BaseViewModel createdViewmodelInstance; // 0x8
	private static BasePlayer lastPlayer; // 0x10
	private static Vector3 smoothLookDir; // 0x18
	private static bool wasParented; // 0x24
	private static Item lastHeldItem; // 0x28
	private static TimeUntil reloadEnds; // 0x30


	public static void Apply(Camera cam, BaseEntity target) { }

	public static void OnFirstPersonSpectateEnds() { }

	public static void OnPlayerSignal(BaseEntity.Signal signal, string arg, BasePlayer fromPlayer) { }

	public static void OnHeldNetworkUpdate(HeldEntity entity) { }

	private static void .cctor() { }

}

