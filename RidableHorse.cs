public class RidableHorse : BaseRidableAnimal // TypeDefIndex: 8635
{	// Fields
	[ServerVar] // RVA: 0xB4180 Offset: 0xB3580 VA: 0x1800B4180
	public static float Population; // 0x0
	public string distanceStatName; // 0x6E8
	public HorseBreed[] breeds; // 0x6F0
	public SkinnedMeshRenderer[] bodyRenderers; // 0x6F8
	public SkinnedMeshRenderer[] hairRenderers; // 0x700
	private int currentBreed; // 0x708
	private ProtectionProperties riderProtection; // 0x710
	private ProtectionProperties baseHorseProtection; // 0x718
	public const BaseEntity.Flags Flag_HideHair = 1024;
	public const BaseEntity.Flags Flag_WoodArmor = 2048;
	public const BaseEntity.Flags Flag_RoadsignArmor = 16384;
	private float equipmentSpeedMod; // 0x720
	private int numStorageSlots; // 0x724
	private static Material[] breedAssignmentArray; // 0x8
	private float clientRecievedRunSpeed; // 0x728

	// Properties
	public override float RealisticMass { get; }

	// Methods

	// RVA: 0x4C3DF0 Offset: 0x4C31F0 VA: 0x1804C3DF0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4C3C80 Offset: 0x4C3080 VA: 0x1804C3C80
	public int GetStorageSlotCount() { }

	// RVA: 0x4C4410 Offset: 0x4C3810 VA: 0x1804C4410 Slot: 76
	public override float get_RealisticMass() { }

	// RVA: 0x4C36D0 Offset: 0x4C2AD0 VA: 0x1804C36D0
	public void ApplyBreed(int index) { }

	// RVA: 0x4C35A0 Offset: 0x4C29A0 VA: 0x1804C35A0
	protected void ApplyBreedInternal(HorseBreed breed) { }

	// RVA: 0x4C3AA0 Offset: 0x4C2EA0 VA: 0x1804C3AA0
	public HorseBreed GetBreed() { }

	// RVA: 0x4C3C90 Offset: 0x4C3090 VA: 0x1804C3C90 Slot: 198
	public override float GetTrotSpeed() { }

	// RVA: 0x4C3C00 Offset: 0x4C3000 VA: 0x1804C3C00 Slot: 199
	public override float GetRunSpeed() { }

	// RVA: 0x4C3D10 Offset: 0x4C3110 VA: 0x1804C3D10 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4C3AF0 Offset: 0x4C2EF0 VA: 0x1804C3AF0
	public void GetDistanceTravelled(BaseEntity.RPCMessage msg) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x4C4390 Offset: 0x4C3790 VA: 0x1804C4390
	public void .ctor() { }

	// RVA: 0x4C4320 Offset: 0x4C3720 VA: 0x1804C4320
	private static void .cctor() { }

}

