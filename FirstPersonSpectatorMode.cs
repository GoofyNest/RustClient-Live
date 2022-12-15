public static class FirstPersonSpectatorMode // TypeDefIndex: 10930
{
	private static ViewModel createdViewmodel;
	private static BaseViewModel createdViewmodelInstance;
	private static BasePlayer lastPlayer;
	private static Vector3 smoothLookDir;
	private static bool wasParented;
	private static Item lastHeldItem;
	private static TimeUntil reloadEnds;
	private static float duckTarget;
	private static TimeSince timeOnCurrentPlayer;


	public static void Apply(Camera cam, BaseEntity target) { }

	public static void OnFirstPersonSpectateEnds() { }

	public static void OnPlayerSignal(BaseEntity.Signal signal, string arg, BasePlayer fromPlayer) { }

	public static void OnHeldNetworkUpdate(HeldEntity entity) { }

	private static void .cctor() { }

}

