public class SlotMachinePayoutSettings : ScriptableObject // TypeDefIndex: 8750
{	public ItemAmount SpinCost; // 0x18
	public SlotMachinePayoutSettings.PayoutInfo[] Payouts; // 0x20
	public int[] VirtualFaces; // 0x28
	public SlotMachinePayoutSettings.IndividualPayouts[] FacePayouts; // 0x30
	public int TotalStops; // 0x38
	public GameObjectRef DefaultWinEffect; // 0x40


	public void .ctor() { }

}

public struct SlotMachinePayoutSettings.PayoutInfo // TypeDefIndex: 8751
{	public ItemAmount Item; // 0x0
	[RangeAttribute] // RVA: 0x9E6E0 Offset: 0x9DAE0 VA: 0x18009E6E0
	public int Result1; // 0x8
	[RangeAttribute] // RVA: 0x9E6E0 Offset: 0x9DAE0 VA: 0x18009E6E0
	public int Result2; // 0xC
	[RangeAttribute] // RVA: 0x9E6E0 Offset: 0x9DAE0 VA: 0x18009E6E0
	public int Result3; // 0x10
	public GameObjectRef OverrideWinEffect; // 0x18

}

public struct SlotMachinePayoutSettings.IndividualPayouts // TypeDefIndex: 8752
{	public ItemAmount Item; // 0x0
	[RangeAttribute] // RVA: 0x9E6E0 Offset: 0x9DAE0 VA: 0x18009E6E0
	public int Result; // 0x8

}

