public static class FirstPersonSpectatorMode // TypeDefIndex: 9188
{	// Fields
	private static ViewModel createdViewmodel; // 0x0
	private static BaseViewModel createdViewmodelInstance; // 0x8
	private static BasePlayer lastPlayer; // 0x10
	private static Vector3 smoothLookDir; // 0x18
	private static bool wasParented; // 0x24
	private static Item lastHeldItem; // 0x28
	private static TimeUntil reloadEnds; // 0x30

	// Methods

	// RVA: 0x7894B0 Offset: 0x7888B0 VA: 0x1807894B0
	public static void Apply(Camera cam, BaseEntity target) { }

	// RVA: 0x78A720 Offset: 0x789B20 VA: 0x18078A720
	public static void OnFirstPersonSpectateEnds() { }

	// RVA: 0x78AA70 Offset: 0x789E70 VA: 0x18078AA70
	public static void OnPlayerSignal(BaseEntity.Signal signal, string arg, BasePlayer fromPlayer) { }

	// RVA: 0x78A900 Offset: 0x789D00 VA: 0x18078A900
	public static void OnHeldNetworkUpdate(HeldEntity entity) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

