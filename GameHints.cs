public class HowToExamineHeld : BaseTip // TypeDefIndex: 11589
{	// Fields
	public static Translate.Phrase Phrase; // 0x1F37D

	// Properties
	public int ExaminedTimes { get; }
	public float SecondsLastExamined { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x6FC170 Offset: 0x6FB570 VA: 0x1806FC170 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x6FC240 Offset: 0x6FB640 VA: 0x1806FC240
	public int get_ExaminedTimes() { }

	// RVA: 0x6FC250 Offset: 0x6FB650 VA: 0x1806FC250
	public float get_SecondsLastExamined() { }

	// RVA: 0x6FC2C0 Offset: 0x6FB6C0 VA: 0x1806FC2C0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6FC1D0 Offset: 0x6FB5D0 VA: 0x1806FC1D0
	private static void .cctor() { }

}

public class HowToHammerUpgrade : BaseTip // TypeDefIndex: 11590
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static float lastBuildChangeTime; // 0x8

	// Properties
	public float TimeSinceBuildChanged { get; }
	public static bool HasHammerEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x6FC460 Offset: 0x6FB860 VA: 0x1806FC460 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x6FC4C0 Offset: 0x6FB8C0 VA: 0x1806FC4C0
	public static void UpgradeHappened() { }

	// RVA: 0x6FC890 Offset: 0x6FBC90 VA: 0x1806FC890
	public float get_TimeSinceBuildChanged() { }

	// RVA: 0x6FC5D0 Offset: 0x6FB9D0 VA: 0x1806FC5D0
	public static bool get_HasHammerEquipped() { }

	// RVA: 0x6FC7B0 Offset: 0x6FBBB0 VA: 0x1806FC7B0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6FC550 Offset: 0x6FB950 VA: 0x1806FC550
	private static void .cctor() { }

}

public class HowToOpenBuildOptions : BaseTip // TypeDefIndex: 11591
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static float lastBuildChangeTime; // 0x8

	// Properties
	public float TimeSinceBuildChanged { get; }
	public static bool HasBuildingPlanEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x6FC980 Offset: 0x6FBD80 VA: 0x1806FC980 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x6FC900 Offset: 0x6FBD00 VA: 0x1806FC900
	public static void BuildOptionChanged() { }

	// RVA: 0x6FCD40 Offset: 0x6FC140 VA: 0x1806FCD40
	public float get_TimeSinceBuildChanged() { }

	// RVA: 0x6FCA60 Offset: 0x6FBE60 VA: 0x1806FCA60
	public static bool get_HasBuildingPlanEquipped() { }

	// RVA: 0x6FCC50 Offset: 0x6FC050 VA: 0x1806FCC50 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6FC9E0 Offset: 0x6FBDE0 VA: 0x1806FC9E0
	private static void .cctor() { }

}

public class HowToOpenCrafting : BaseTip // TypeDefIndex: 11592
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B0AC40

	// Properties
	public int CraftingOpenedTimes { get; }
	public float CraftingOpenedSecondsAgo { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x6FCDB0 Offset: 0x6FC1B0 VA: 0x1806FCDB0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x6FCEC0 Offset: 0x6FC2C0 VA: 0x1806FCEC0
	public int get_CraftingOpenedTimes() { }

	// RVA: 0x6FCE80 Offset: 0x6FC280 VA: 0x1806FCE80
	public float get_CraftingOpenedSecondsAgo() { }

	// RVA: 0x6FCED0 Offset: 0x6FC2D0 VA: 0x1806FCED0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6FCE10 Offset: 0x6FC210 VA: 0x1806FCE10
	private static void .cctor() { }

}

public class HowToOpenInventory : BaseTip // TypeDefIndex: 11593
{	// Fields
	public static Translate.Phrase Phrase; // 0x1F380

	// Properties
	public int InventoryOpenedTimes { get; }
	public float IntentoryOpenedSecondsAgo { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x6FCF30 Offset: 0x6FC330 VA: 0x1806FCF30 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x6FD070 Offset: 0x6FC470 VA: 0x1806FD070
	public int get_InventoryOpenedTimes() { }

	// RVA: 0x6FD000 Offset: 0x6FC400 VA: 0x1806FD000
	public float get_IntentoryOpenedSecondsAgo() { }

	// RVA: 0x6FD080 Offset: 0x6FC480 VA: 0x1806FD080 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6FCF90 Offset: 0x6FC390 VA: 0x1806FCF90
	private static void .cctor() { }

}

public class HowToOpenMap : BaseTip // TypeDefIndex: 11594
{	// Fields
	public static Translate.Phrase Phrase; // 0x1F3D2

	// Properties
	public int MapOpenedTimes { get; }
	public float MapOpenedSecondsAgo { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x6FD110 Offset: 0x6FC510 VA: 0x1806FD110 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x6FD250 Offset: 0x6FC650 VA: 0x1806FD250
	public int get_MapOpenedTimes() { }

	// RVA: 0x6FD1E0 Offset: 0x6FC5E0 VA: 0x1806FD1E0
	public float get_MapOpenedSecondsAgo() { }

	// RVA: 0x6FD260 Offset: 0x6FC660 VA: 0x1806FD260 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6FD170 Offset: 0x6FC570 VA: 0x1806FD170
	private static void .cctor() { }

}

public class HowToOreMinigame : BaseTip // TypeDefIndex: 11595
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static float lastOreHitTime; // 0x8

	// Properties
	public int OreSpotsHit { get; }
	public float OreHitSecondsAgo { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x6FD2F0 Offset: 0x6FC6F0 VA: 0x1806FD2F0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x6FD4B0 Offset: 0x6FC8B0 VA: 0x1806FD4B0
	public int get_OreSpotsHit() { }

	// RVA: 0x6FD440 Offset: 0x6FC840 VA: 0x1806FD440
	public float get_OreHitSecondsAgo() { }

	// RVA: 0x6FD350 Offset: 0x6FC750 VA: 0x1806FD350
	public static void OreHit() { }

	// RVA: 0x6FD4C0 Offset: 0x6FC8C0 VA: 0x1806FD4C0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6FD3D0 Offset: 0x6FC7D0 VA: 0x1806FD3D0
	private static void .cctor() { }

}

public class HowToRegenWithComfort : BaseTip // TypeDefIndex: 11596
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B0AA90

	// Properties
	public static bool IsComfortable { get; }
	public static float TimeComfortableTotal { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x6FD550 Offset: 0x6FC950 VA: 0x1806FD550 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x6FD620 Offset: 0x6FCA20 VA: 0x1806FD620
	public static bool get_IsComfortable() { }

	// RVA: 0x6FD990 Offset: 0x6FCD90 VA: 0x1806FD990
	public static float get_TimeComfortableTotal() { }

	// RVA: 0x6FD7A0 Offset: 0x6FCBA0 VA: 0x1806FD7A0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6FD5B0 Offset: 0x6FC9B0 VA: 0x1806FD5B0
	private static void .cctor() { }

}

public class HowToRetrieveThrown : BaseTip // TypeDefIndex: 11597
{	// Fields
	public static Translate.Phrase Phrase; // 0x1F3E0

	// Properties
	public static bool HasThrowableItemEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x6FD9A0 Offset: 0x6FCDA0 VA: 0x1806FD9A0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x6FDA70 Offset: 0x6FCE70 VA: 0x1806FDA70
	public static bool get_HasThrowableItemEquipped() { }

	// RVA: 0x6FDC60 Offset: 0x6FD060 VA: 0x1806FDC60 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6FDA00 Offset: 0x6FCE00 VA: 0x1806FDA00
	private static void .cctor() { }

}

public class HowToThrow : BaseTip // TypeDefIndex: 11598
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static bool itemThrown; // 0x8
	public static float lastThrownTime; // 0xC

	// Properties
	public static bool HasThrowableItemEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x6FDDC0 Offset: 0x6FD1C0 VA: 0x1806FDDC0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x6FDE20 Offset: 0x6FD220 VA: 0x1806FDE20
	public static void ItemThrown() { }

	// RVA: 0x6FDEB0 Offset: 0x6FD2B0 VA: 0x1806FDEB0
	public static bool RecentlyThrown() { }

	// RVA: 0x6FE000 Offset: 0x6FD400 VA: 0x1806FE000
	public static bool get_HasThrowableItemEquipped() { }

	// RVA: 0x6FE1F0 Offset: 0x6FD5F0 VA: 0x1806FE1F0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6FDF70 Offset: 0x6FD370 VA: 0x1806FDF70
	private static void .cctor() { }

}

public class HowToTreeMinigame : BaseTip // TypeDefIndex: 11599
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static float lastTreeHitTime; // 0x8

	// Properties
	public int TreeSpotsHit { get; }
	public float TreeHitSecondsAgo { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x6FE2A0 Offset: 0x6FD6A0 VA: 0x1806FE2A0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x6FE4F0 Offset: 0x6FD8F0 VA: 0x1806FE4F0
	public int get_TreeSpotsHit() { }

	// RVA: 0x6FE480 Offset: 0x6FD880 VA: 0x1806FE480
	public float get_TreeHitSecondsAgo() { }

	// RVA: 0x6FE300 Offset: 0x6FD700 VA: 0x1806FE300
	public static void TreeHit() { }

	// RVA: 0x6FE3F0 Offset: 0x6FD7F0 VA: 0x1806FE3F0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6FE380 Offset: 0x6FD780 VA: 0x1806FE380
	private static void .cctor() { }

}

public class HowToUseBow : BaseTip // TypeDefIndex: 11600
{	// Fields
	public static Translate.Phrase Phrase; // 0x1F470

	// Properties
	public static bool HasBowItemEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x6FE500 Offset: 0x6FD900 VA: 0x1806FE500 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x6FE5D0 Offset: 0x6FD9D0 VA: 0x1806FE5D0
	public static bool get_HasBowItemEquipped() { }

	// RVA: 0x6FE7B0 Offset: 0x6FDBB0 VA: 0x1806FE7B0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6FE560 Offset: 0x6FD960 VA: 0x1806FE560
	private static void .cctor() { }

}

public class HowToUseGrenade : BaseTip // TypeDefIndex: 11601
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B0AC0C

	// Properties
	private static bool HasGrenadeItemEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x6FE820 Offset: 0x6FDC20 VA: 0x1806FE820 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x6FE8F0 Offset: 0x6FDCF0 VA: 0x1806FE8F0
	private static bool get_HasGrenadeItemEquipped() { }

	// RVA: 0x6FEAD0 Offset: 0x6FDED0 VA: 0x1806FEAD0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6FE880 Offset: 0x6FDC80 VA: 0x1806FE880
	private static void .cctor() { }

}

public class HowToUseWave : BaseTip // TypeDefIndex: 11602
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static float lastWavedAtTime; // 0x8
	public static float lastLocalWaveTime; // 0xC

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x6FEBC0 Offset: 0x6FDFC0 VA: 0x1806FEBC0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x6FECA0 Offset: 0x6FE0A0 VA: 0x1806FECA0
	public static void MarkWavedAt(BasePlayer Entity) { }

	// RVA: 0x6FEC20 Offset: 0x6FE020 VA: 0x1806FEC20
	public static void MarkLocalWave() { }

	// RVA: 0x6FEB40 Offset: 0x6FDF40 VA: 0x1806FEB40
	public bool DidRecentlyWaveLocally() { }

	// RVA: 0x6FEFE0 Offset: 0x6FE3E0 VA: 0x1806FEFE0
	public bool WasRecentlyWavedAt() { }

	// RVA: 0x6FF0F0 Offset: 0x6FE4F0 VA: 0x1806FF0F0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6FF060 Offset: 0x6FE460 VA: 0x1806FF060
	private static void .cctor() { }

}

public class HowToVoiceChat : BaseTip // TypeDefIndex: 11603
{	// Fields
	public static Translate.Phrase Phrase; // 0x1F470

	// Properties
	public float SecondsSpeaking { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x6FF1F0 Offset: 0x6FE5F0 VA: 0x1806FF1F0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x6FF2C0 Offset: 0x6FE6C0 VA: 0x1806FF2C0
	public float get_SecondsSpeaking() { }

	// RVA: 0x6FF2D0 Offset: 0x6FE6D0 VA: 0x1806FF2D0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x6FF250 Offset: 0x6FE650 VA: 0x1806FF250
	private static void .cctor() { }

}

public class HowToWorldDrink : BaseTip // TypeDefIndex: 11604
{	// Fields
	public static Translate.Phrase Phrase; // 0x1F49C

	// Properties
	public bool NearFreshWater { get; }
	public float ConsumedWater { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC99980 Offset: 0xC98D80 VA: 0x180C99980 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC99A60 Offset: 0xC98E60 VA: 0x180C99A60
	public bool get_NearFreshWater() { }

	// RVA: 0xC99A50 Offset: 0xC98E50 VA: 0x180C99A50
	public float get_ConsumedWater() { }

	// RVA: 0xC99BF0 Offset: 0xC98FF0 VA: 0x180C99BF0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC999E0 Offset: 0xC98DE0 VA: 0x180C999E0
	private static void .cctor() { }

}

public class TipInstrumentFullKeyboard : InstrumentTip // TypeDefIndex: 11606
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B0AAC4

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9CDE0 Offset: 0xC9C1E0 VA: 0x180C9CDE0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9CEB0 Offset: 0xC9C2B0 VA: 0x180C9CEB0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9CE40 Offset: 0xC9C240 VA: 0x180C9CE40
	private static void .cctor() { }

}

public class TipInstrumentNumlock : InstrumentTip // TypeDefIndex: 11607
{	// Fields
	public static Translate.Phrase Phrase; // 0x1F4A0

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9CF50 Offset: 0xC9C350 VA: 0x180C9CF50 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9D020 Offset: 0xC9C420 VA: 0x180C9D020 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9CFB0 Offset: 0xC9C3B0 VA: 0x180C9CFB0
	private static void .cctor() { }

}

public class TipInstrumentPlay : InstrumentTip // TypeDefIndex: 11608
{	// Fields
	public static Translate.Phrase Phrase; // 0x1F4D4

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9D0A0 Offset: 0xC9C4A0 VA: 0x180C9D0A0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9D170 Offset: 0xC9C570 VA: 0x180C9D170 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9D100 Offset: 0xC9C500 VA: 0x180C9D100
	private static void .cctor() { }

}

public class TipBreakCarLock : BaseTip // TypeDefIndex: 11610
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static bool wasShowing; // 0x8
	public static float nextTipTime; // 0xC
	public const float MIN_TIME_BETWEEN_TIPS = 300;

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9A370 Offset: 0xC99770 VA: 0x180C9A370 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9A1F0 Offset: 0xC995F0 VA: 0x180C9A1F0
	public static bool AimingInNoBuild() { }

	// RVA: 0xC9A440 Offset: 0xC99840 VA: 0x180C9A440 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9A3D0 Offset: 0xC997D0 VA: 0x180C9A3D0
	private static void .cctor() { }

}

public class TipCannotHarvest : BaseTip // TypeDefIndex: 11611
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static float nonEntityHitTime; // 0x8

	// Properties
	public float TimeSinceHitNonEntity { get; }
	public static bool HasToolItemEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9A700 Offset: 0xC99B00 VA: 0x180C9A700 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9A760 Offset: 0xC99B60 VA: 0x180C9A760
	public static void HitNonEntity() { }

	// RVA: 0xC9AB40 Offset: 0xC99F40 VA: 0x180C9AB40
	public float get_TimeSinceHitNonEntity() { }

	// RVA: 0xC9A860 Offset: 0xC99C60 VA: 0x180C9A860
	public static bool get_HasToolItemEquipped() { }

	// RVA: 0xC9AA60 Offset: 0xC99E60 VA: 0x180C9AA60 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9A7E0 Offset: 0xC99BE0 VA: 0x180C9A7E0
	private static void .cctor() { }

}

public class TipConsumeFood : BaseTip // TypeDefIndex: 11612
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public float lastFoodPickupTime; // 0x10
	public int lastFoodPickupCount; // 0x14

	// Properties
	public float ConsumedFood { get; }
	public float ConsumedWater { get; }
	public int PickedUpFood { get; }
	public bool HasConsumedEnough { get; }
	public bool RecentlyPickedUpFood { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9ABB0 Offset: 0xC99FB0 VA: 0x180C9ABB0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9AC80 Offset: 0xC9A080 VA: 0x180C9AC80
	public float get_ConsumedFood() { }

	// RVA: 0xC99A50 Offset: 0xC98E50 VA: 0x180C99A50
	public float get_ConsumedWater() { }

	// RVA: 0xC9ACD0 Offset: 0xC9A0D0 VA: 0x180C9ACD0
	public int get_PickedUpFood() { }

	// RVA: 0xC9AC90 Offset: 0xC9A090 VA: 0x180C9AC90
	public bool get_HasConsumedEnough() { }

	// RVA: 0xC9ADC0 Offset: 0xC9A1C0 VA: 0x180C9ADC0
	public bool get_RecentlyPickedUpFood() { }

	// RVA: 0xC9AF00 Offset: 0xC9A300 VA: 0x180C9AF00 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9AC10 Offset: 0xC9A010 VA: 0x180C9AC10
	private static void .cctor() { }

}

public class TipControllingMagnetCrane : BaseTip // TypeDefIndex: 11613
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	private bool wasMounted; // 0x10
	private TimeSince timeSinceShown; // 0x14

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9B070 Offset: 0xC9A470 VA: 0x180C9B070 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9B140 Offset: 0xC9A540 VA: 0x180C9B140 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9B0D0 Offset: 0xC9A4D0 VA: 0x180C9B0D0
	private static void .cctor() { }

}

public class TipDrivingSubmarine : BaseTip // TypeDefIndex: 11614
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	private bool wasMounted; // 0x10
	private bool haveShown; // 0x11

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9B300 Offset: 0xC9A700 VA: 0x180C9B300 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9B3D0 Offset: 0xC9A7D0 VA: 0x180C9B3D0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9B360 Offset: 0xC9A760 VA: 0x180C9B360
	private static void .cctor() { }

}

public class TipEquipTorch : BaseTip // TypeDefIndex: 11615
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static float nextTorchTipTime; // 0x8

	// Properties
	public static bool IsDark { get; }
	public static float TimeComfortableTotal { get; }
	public static bool HasTorchThatNeedsLighting { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9B570 Offset: 0xC9A970 VA: 0x180C9B570 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9B900 Offset: 0xC9AD00 VA: 0x180C9B900
	public static bool get_IsDark() { }

	// RVA: 0x6FD990 Offset: 0x6FCD90 VA: 0x1806FD990
	public static float get_TimeComfortableTotal() { }

	// RVA: 0xC9B5D0 Offset: 0xC9A9D0 VA: 0x180C9B5D0
	public static void TorchLit() { }

	// RVA: 0xC9B6C0 Offset: 0xC9AAC0 VA: 0x180C9B6C0
	public static bool get_HasTorchThatNeedsLighting() { }

	// RVA: 0xC9B9C0 Offset: 0xC9ADC0 VA: 0x180C9B9C0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9B650 Offset: 0xC9AA50 VA: 0x180C9B650
	private static void .cctor() { }

}

public class TipFillToolCupboard : BaseTip // TypeDefIndex: 11616
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B0AAB0

	// Properties
	public int CupboardOpenedTimes { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9BB40 Offset: 0xC9AF40 VA: 0x180C9BB40 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9BC10 Offset: 0xC9B010 VA: 0x180C9BC10
	public int get_CupboardOpenedTimes() { }

	// RVA: 0xC9BC20 Offset: 0xC9B020 VA: 0x180C9BC20 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9BBA0 Offset: 0xC9AFA0 VA: 0x180C9BBA0
	private static void .cctor() { }

}

public class TipFishingControls : BaseTip // TypeDefIndex: 11617
{	// Fields
	public static Translate.Phrase Phrase; // 0x1F4E0

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9BDF0 Offset: 0xC9B1F0 VA: 0x180C9BDF0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9BEC0 Offset: 0xC9B2C0 VA: 0x180C9BEC0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9BE50 Offset: 0xC9B250 VA: 0x180C9BE50
	private static void .cctor() { }

}

public class TipFishingFail : BaseTip // TypeDefIndex: 11618
{	// Fields
	public static Translate.Phrase StrainPhrase; // 0x0
	public static Translate.Phrase AnglePhrase; // 0x8
	public static Translate.Phrase ObstructedPhrase; // 0x10

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9C050 Offset: 0xC9B450 VA: 0x180C9C050 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9C260 Offset: 0xC9B660 VA: 0x180C9C260 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9C160 Offset: 0xC9B560 VA: 0x180C9C160
	private static void .cctor() { }

}

public class TipHealAtCampfire : BaseTip // TypeDefIndex: 11619
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public float oldHealth; // 0x10
	public float lastHurtTime; // 0x14

	// Properties
	public bool IsHurt { get; }
	public float TimeComfortableTotal { get; }
	public bool HealEligable { get; }
	public bool RecentlyHurt { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9C470 Offset: 0xC9B870 VA: 0x180C9C470 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9C710 Offset: 0xC9BB10 VA: 0x180C9C710
	public bool get_IsHurt() { }

	// RVA: 0x6FD990 Offset: 0x6FCD90 VA: 0x1806FD990
	public float get_TimeComfortableTotal() { }

	// RVA: 0xC9C550 Offset: 0xC9B950 VA: 0x180C9C550
	public bool get_HealEligable() { }

	// RVA: 0xC9C880 Offset: 0xC9BC80 VA: 0x180C9C880
	public bool get_RecentlyHurt() { }

	// RVA: 0xC9CA90 Offset: 0xC9BE90 VA: 0x180C9CA90 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0xC9C540 Offset: 0xC9B940 VA: 0x180C9C540
	public void .ctor() { }

	// RVA: 0xC9C4D0 Offset: 0xC9B8D0 VA: 0x180C9C4D0
	private static void .cctor() { }

}

public class TipKayakPaddle : BaseTip // TypeDefIndex: 11620
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static bool <hasPaddledWithoutOar>k__BackingField; // 0x8

	// Properties
	public override bool ShouldShow { get; }
	public static bool hasPaddledWithoutOar { get; set; }

	// Methods

	// RVA: 0xC9D210 Offset: 0xC9C610 VA: 0x180C9D210 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9D2F0 Offset: 0xC9C6F0 VA: 0x180C9D2F0 Slot: 5
	public override bool get_ShouldShow() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC9D610 Offset: 0xC9CA10 VA: 0x180C9D610
	public static bool get_hasPaddledWithoutOar() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC9D670 Offset: 0xC9CA70 VA: 0x180C9D670
	public static void set_hasPaddledWithoutOar(bool value) { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9D270 Offset: 0xC9C670 VA: 0x180C9D270
	private static void .cctor() { }

}

public class TipMLRSAimingModule : BaseTip // TypeDefIndex: 11621
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static bool wasMounted; // 0x8
	public static float nextTipTime; // 0xC

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9D6D0 Offset: 0xC9CAD0 VA: 0x180C9D6D0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9D7A0 Offset: 0xC9CBA0 VA: 0x180C9D7A0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9D730 Offset: 0xC9CB30 VA: 0x180C9D730
	private static void .cctor() { }

}

public class TipMLRSBrokenDown : BaseTip // TypeDefIndex: 11622
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static bool wasMounted; // 0x8
	public static float nextTipTime; // 0xC

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9D9C0 Offset: 0xC9CDC0 VA: 0x180C9D9C0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9DA90 Offset: 0xC9CE90 VA: 0x180C9DA90 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9DA20 Offset: 0xC9CE20 VA: 0x180C9DA20
	private static void .cctor() { }

}

public class TipMLRSNoRockets : BaseTip // TypeDefIndex: 11623
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static bool wasMounted; // 0x8
	public static float nextTipTime; // 0xC

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9DC90 Offset: 0xC9D090 VA: 0x180C9DC90 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9DD60 Offset: 0xC9D160 VA: 0x180C9DD60 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9DCF0 Offset: 0xC9D0F0 VA: 0x180C9DCF0
	private static void .cctor() { }

}

public class TipMissingLure : BaseTip // TypeDefIndex: 11624
{	// Fields
	public static Translate.Phrase Phrase; // 0x1F513

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9DF90 Offset: 0xC9D390 VA: 0x180C9DF90 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9E060 Offset: 0xC9D460 VA: 0x180C9E060 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9DFF0 Offset: 0xC9D3F0 VA: 0x180C9DFF0
	private static void .cctor() { }

}

public class TipNoBuild : BaseTip // TypeDefIndex: 11625
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B0AAC4

	// Properties
	public static bool HasBuildingPlanEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9E390 Offset: 0xC9D790 VA: 0x180C9E390 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9E460 Offset: 0xC9D860 VA: 0x180C9E460
	public static bool get_HasBuildingPlanEquipped() { }

	// RVA: 0xC9E210 Offset: 0xC9D610 VA: 0x180C9E210
	public static bool AimingInNoBuild() { }

	// RVA: 0xC9E640 Offset: 0xC9DA40 VA: 0x180C9E640 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9E3F0 Offset: 0xC9D7F0 VA: 0x180C9E3F0
	private static void .cctor() { }

}

public class TipPetControlWheel : BaseTip // TypeDefIndex: 11626
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static bool haveShown; // 0x8

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9E780 Offset: 0xC9DB80 VA: 0x180C9E780 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9E850 Offset: 0xC9DC50 VA: 0x180C9E850 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9E7E0 Offset: 0xC9DBE0 VA: 0x180C9E7E0
	private static void .cctor() { }

}

public class TipPlaceSleepingBag : BaseTip // TypeDefIndex: 11627
{	// Fields
	public static Translate.Phrase Phrase; // 0x1F520

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9E9B0 Offset: 0xC9DDB0 VA: 0x180C9E9B0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9EA80 Offset: 0xC9DE80 VA: 0x180C9EA80 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9EA10 Offset: 0xC9DE10 VA: 0x180C9EA10
	private static void .cctor() { }

}

public class TipPlaceToolCupboard : BaseTip // TypeDefIndex: 11628
{	// Fields
	public static Translate.Phrase Phrase; // 0x1F566

	// Properties
	public int CupboardOpenedTimes { get; }
	public int NumBlocksPlaced { get; }
	public int NumBlocksUpgraded { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9ED80 Offset: 0xC9E180 VA: 0x180C9ED80 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9BC10 Offset: 0xC9B010 VA: 0x180C9BC10
	public int get_CupboardOpenedTimes() { }

	// RVA: 0xC9EE50 Offset: 0xC9E250 VA: 0x180C9EE50
	public int get_NumBlocksPlaced() { }

	// RVA: 0xC9EE60 Offset: 0xC9E260 VA: 0x180C9EE60
	public int get_NumBlocksUpgraded() { }

	// RVA: 0xC9EE70 Offset: 0xC9E270 VA: 0x180C9EE70 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9EDE0 Offset: 0xC9E1E0 VA: 0x180C9EDE0
	private static void .cctor() { }

}

public class TipPokerWinnings : BaseTip // TypeDefIndex: 11629
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B0AC04

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9F0F0 Offset: 0xC9E4F0 VA: 0x180C9F0F0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9F1C0 Offset: 0xC9E5C0 VA: 0x180C9F1C0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9F150 Offset: 0xC9E550 VA: 0x180C9F150
	private static void .cctor() { }

}

public class TipRads : BaseTip // TypeDefIndex: 11630
{	// Fields
	public static Translate.Phrase Phrase; // 0x1F570

	// Properties
	public float RadDuration { get; }
	public bool HasRads { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9F3A0 Offset: 0xC9E7A0 VA: 0x180C9F3A0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9F5F0 Offset: 0xC9E9F0 VA: 0x180C9F5F0
	public float get_RadDuration() { }

	// RVA: 0xC9F470 Offset: 0xC9E870 VA: 0x180C9F470
	public bool get_HasRads() { }

	// RVA: 0xC9F600 Offset: 0xC9EA00 VA: 0x180C9F600 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9F400 Offset: 0xC9E800 VA: 0x180C9F400
	private static void .cctor() { }

}

public class TipRemoveRads : BaseTip // TypeDefIndex: 11631
{	// Fields
	public static Translate.Phrase Phrase; // 0x1F5CB

	// Properties
	public float RadDuration { get; }
	public bool HasRads { get; }
	public bool HasRadExposure { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9F790 Offset: 0xC9EB90 VA: 0x180C9F790 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9F5F0 Offset: 0xC9E9F0 VA: 0x180C9F5F0
	public float get_RadDuration() { }

	// RVA: 0xC9F9E0 Offset: 0xC9EDE0 VA: 0x180C9F9E0
	public bool get_HasRads() { }

	// RVA: 0xC9F860 Offset: 0xC9EC60 VA: 0x180C9F860
	public bool get_HasRadExposure() { }

	// RVA: 0xC9FB60 Offset: 0xC9EF60 VA: 0x180C9FB60 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9F7F0 Offset: 0xC9EBF0 VA: 0x180C9F7F0
	private static void .cctor() { }

}

public class TipReskinObject : BaseTip // TypeDefIndex: 11632
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B0AB70

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC9FE70 Offset: 0xC9F270 VA: 0x180C9FE70 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9FF40 Offset: 0xC9F340 VA: 0x180C9FF40 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xC9FED0 Offset: 0xC9F2D0 VA: 0x180C9FED0
	private static void .cctor() { }

}

public class TipSledPlacement : BaseTip // TypeDefIndex: 11633
{	// Fields
	public static Translate.Phrase Phrase; // 0x1F5D0

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xCA00D0 Offset: 0xC9F4D0 VA: 0x180CA00D0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xCA01A0 Offset: 0xC9F5A0 VA: 0x180CA01A0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xCA0130 Offset: 0xC9F530 VA: 0x180CA0130
	private static void .cctor() { }

}

public class TipSleepingBagPlacement : BaseTip // TypeDefIndex: 11634
{	// Fields
	public static Translate.Phrase Phrase; // 0x1F6D4

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xCA0340 Offset: 0xC9F740 VA: 0x180CA0340 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xCA0410 Offset: 0xC9F810 VA: 0x180CA0410 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xCA03A0 Offset: 0xC9F7A0 VA: 0x180CA03A0
	private static void .cctor() { }

}

public class TipSnapAttractionPoint : BaseTip // TypeDefIndex: 11635
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static bool <HasDismissedSnap>k__BackingField; // 0x8

	// Properties
	public override bool ShouldShow { get; }
	public static bool HasDismissedSnap { get; set; }

	// Methods

	// RVA: 0xCA0620 Offset: 0xC9FA20 VA: 0x180CA0620 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xCA0760 Offset: 0xC9FB60 VA: 0x180CA0760 Slot: 5
	public override bool get_ShouldShow() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xCA0700 Offset: 0xC9FB00 VA: 0x180CA0700
	public static bool get_HasDismissedSnap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xCA0990 Offset: 0xC9FD90 VA: 0x180CA0990
	public static void set_HasDismissedSnap(bool value) { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xCA0680 Offset: 0xC9FA80 VA: 0x180CA0680
	private static void .cctor() { }

}

public class TipSnowmobileSurface : BaseTip // TypeDefIndex: 11636
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static bool showedMessage; // 0x8
	public static float nextTipTime; // 0xC

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xCA09F0 Offset: 0xC9FDF0 VA: 0x180CA09F0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xCA0AC0 Offset: 0xC9FEC0 VA: 0x180CA0AC0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xCA0A50 Offset: 0xC9FE50 VA: 0x180CA0A50
	private static void .cctor() { }

}

public class TipSprayControls : BaseTip // TypeDefIndex: 11637
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B0AE58

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xCA0CD0 Offset: 0xCA00D0 VA: 0x180CA0CD0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xCA0DA0 Offset: 0xCA01A0 VA: 0x180CA0DA0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xCA0D30 Offset: 0xCA0130 VA: 0x180CA0D30
	private static void .cctor() { }

}

public class TipTooCold : BaseTip // TypeDefIndex: 11638
{	// Fields
	public static Translate.Phrase Phrase; // 0x1F6E0

	// Properties
	public float ColdDuration { get; }
	public bool IsCold { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xCA0F80 Offset: 0xCA0380 VA: 0x180CA0F80 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC9F5F0 Offset: 0xC9E9F0 VA: 0x180C9F5F0
	public float get_ColdDuration() { }

	// RVA: 0xCA1050 Offset: 0xCA0450 VA: 0x180CA1050
	public bool get_IsCold() { }

	// RVA: 0xCA11D0 Offset: 0xCA05D0 VA: 0x180CA11D0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xCA0FE0 Offset: 0xCA03E0 VA: 0x180CA0FE0
	private static void .cctor() { }

}

public class TipTooHot : BaseTip // TypeDefIndex: 11639
{	// Fields
	public static Translate.Phrase Phrase; // 0x1F757

	// Properties
	public float HotDuration { get; }
	public bool IsHot { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xCA1370 Offset: 0xCA0770 VA: 0x180CA1370 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xCA1440 Offset: 0xCA0840 VA: 0x180CA1440
	public float get_HotDuration() { }

	// RVA: 0xCA1450 Offset: 0xCA0850 VA: 0x180CA1450
	public bool get_IsHot() { }

	// RVA: 0xCA15D0 Offset: 0xCA09D0 VA: 0x180CA15D0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xCA13D0 Offset: 0xCA07D0 VA: 0x180CA13D0
	private static void .cctor() { }

}

public class TipZipline : BaseTip // TypeDefIndex: 11640
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B0AAA0

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xCA1770 Offset: 0xCA0B70 VA: 0x180CA1770 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xCA1840 Offset: 0xCA0C40 VA: 0x180CA1840 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xCA17D0 Offset: 0xCA0BD0 VA: 0x180CA17D0
	private static void .cctor() { }

}

