public class HowToExamineHeld : BaseTip // TypeDefIndex: 11589
{	public static Translate.Phrase Phrase; // 0x1F37D

	public int ExaminedTimes { get; }
	public float SecondsLastExamined { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public int get_ExaminedTimes() { }

	public float get_SecondsLastExamined() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class HowToHammerUpgrade : BaseTip // TypeDefIndex: 11590
{	public static Translate.Phrase Phrase; // 0x0
	public static float lastBuildChangeTime; // 0x8

	public float TimeSinceBuildChanged { get; }
	public static bool HasHammerEquipped { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public static void UpgradeHappened() { }

	public float get_TimeSinceBuildChanged() { }

	public static bool get_HasHammerEquipped() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class HowToOpenBuildOptions : BaseTip // TypeDefIndex: 11591
{	public static Translate.Phrase Phrase; // 0x0
	public static float lastBuildChangeTime; // 0x8

	public float TimeSinceBuildChanged { get; }
	public static bool HasBuildingPlanEquipped { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public static void BuildOptionChanged() { }

	public float get_TimeSinceBuildChanged() { }

	public static bool get_HasBuildingPlanEquipped() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class HowToOpenCrafting : BaseTip // TypeDefIndex: 11592
{	public static Translate.Phrase Phrase; // 0x2B0AC40

	public int CraftingOpenedTimes { get; }
	public float CraftingOpenedSecondsAgo { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public int get_CraftingOpenedTimes() { }

	public float get_CraftingOpenedSecondsAgo() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class HowToOpenInventory : BaseTip // TypeDefIndex: 11593
{	public static Translate.Phrase Phrase; // 0x1F380

	public int InventoryOpenedTimes { get; }
	public float IntentoryOpenedSecondsAgo { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public int get_InventoryOpenedTimes() { }

	public float get_IntentoryOpenedSecondsAgo() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class HowToOpenMap : BaseTip // TypeDefIndex: 11594
{	public static Translate.Phrase Phrase; // 0x1F3D2

	public int MapOpenedTimes { get; }
	public float MapOpenedSecondsAgo { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public int get_MapOpenedTimes() { }

	public float get_MapOpenedSecondsAgo() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class HowToOreMinigame : BaseTip // TypeDefIndex: 11595
{	public static Translate.Phrase Phrase; // 0x0
	public static float lastOreHitTime; // 0x8

	public int OreSpotsHit { get; }
	public float OreHitSecondsAgo { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public int get_OreSpotsHit() { }

	public float get_OreHitSecondsAgo() { }

	public static void OreHit() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class HowToRegenWithComfort : BaseTip // TypeDefIndex: 11596
{	public static Translate.Phrase Phrase; // 0x2B0AA90

	public static bool IsComfortable { get; }
	public static float TimeComfortableTotal { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public static bool get_IsComfortable() { }

	public static float get_TimeComfortableTotal() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class HowToRetrieveThrown : BaseTip // TypeDefIndex: 11597
{	public static Translate.Phrase Phrase; // 0x1F3E0

	public static bool HasThrowableItemEquipped { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public static bool get_HasThrowableItemEquipped() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class HowToThrow : BaseTip // TypeDefIndex: 11598
{	public static Translate.Phrase Phrase; // 0x0
	public static bool itemThrown; // 0x8
	public static float lastThrownTime; // 0xC

	public static bool HasThrowableItemEquipped { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public static void ItemThrown() { }

	public static bool RecentlyThrown() { }

	public static bool get_HasThrowableItemEquipped() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class HowToTreeMinigame : BaseTip // TypeDefIndex: 11599
{	public static Translate.Phrase Phrase; // 0x0
	public static float lastTreeHitTime; // 0x8

	public int TreeSpotsHit { get; }
	public float TreeHitSecondsAgo { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public int get_TreeSpotsHit() { }

	public float get_TreeHitSecondsAgo() { }

	public static void TreeHit() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class HowToUseBow : BaseTip // TypeDefIndex: 11600
{	public static Translate.Phrase Phrase; // 0x1F470

	public static bool HasBowItemEquipped { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public static bool get_HasBowItemEquipped() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class HowToUseGrenade : BaseTip // TypeDefIndex: 11601
{	public static Translate.Phrase Phrase; // 0x2B0AC0C

	private static bool HasGrenadeItemEquipped { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	private static bool get_HasGrenadeItemEquipped() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class HowToUseWave : BaseTip // TypeDefIndex: 11602
{	public static Translate.Phrase Phrase; // 0x0
	public static float lastWavedAtTime; // 0x8
	public static float lastLocalWaveTime; // 0xC

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public static void MarkWavedAt(BasePlayer Entity) { }

	public static void MarkLocalWave() { }

	public bool DidRecentlyWaveLocally() { }

	public bool WasRecentlyWavedAt() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class HowToVoiceChat : BaseTip // TypeDefIndex: 11603
{	public static Translate.Phrase Phrase; // 0x1F470

	public float SecondsSpeaking { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public float get_SecondsSpeaking() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class HowToWorldDrink : BaseTip // TypeDefIndex: 11604
{	public static Translate.Phrase Phrase; // 0x1F49C

	public bool NearFreshWater { get; }
	public float ConsumedWater { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public bool get_NearFreshWater() { }

	public float get_ConsumedWater() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipInstrumentFullKeyboard : InstrumentTip // TypeDefIndex: 11606
{	public static Translate.Phrase Phrase; // 0x2B0AAC4

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipInstrumentNumlock : InstrumentTip // TypeDefIndex: 11607
{	public static Translate.Phrase Phrase; // 0x1F4A0

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipInstrumentPlay : InstrumentTip // TypeDefIndex: 11608
{	public static Translate.Phrase Phrase; // 0x1F4D4

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipBreakCarLock : BaseTip // TypeDefIndex: 11610
{	public static Translate.Phrase Phrase; // 0x0
	public static bool wasShowing; // 0x8
	public static float nextTipTime; // 0xC
	public const float MIN_TIME_BETWEEN_TIPS = 300;

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public static bool AimingInNoBuild() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipCannotHarvest : BaseTip // TypeDefIndex: 11611
{	public static Translate.Phrase Phrase; // 0x0
	public static float nonEntityHitTime; // 0x8

	public float TimeSinceHitNonEntity { get; }
	public static bool HasToolItemEquipped { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public static void HitNonEntity() { }

	public float get_TimeSinceHitNonEntity() { }

	public static bool get_HasToolItemEquipped() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipConsumeFood : BaseTip // TypeDefIndex: 11612
{	public static Translate.Phrase Phrase; // 0x0
	public float lastFoodPickupTime; // 0x10
	public int lastFoodPickupCount; // 0x14

	public float ConsumedFood { get; }
	public float ConsumedWater { get; }
	public int PickedUpFood { get; }
	public bool HasConsumedEnough { get; }
	public bool RecentlyPickedUpFood { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public float get_ConsumedFood() { }

	public float get_ConsumedWater() { }

	public int get_PickedUpFood() { }

	public bool get_HasConsumedEnough() { }

	public bool get_RecentlyPickedUpFood() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipControllingMagnetCrane : BaseTip // TypeDefIndex: 11613
{	public static Translate.Phrase Phrase; // 0x0
	private bool wasMounted; // 0x10
	private TimeSince timeSinceShown; // 0x14

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipDrivingSubmarine : BaseTip // TypeDefIndex: 11614
{	public static Translate.Phrase Phrase; // 0x0
	private bool wasMounted; // 0x10
	private bool haveShown; // 0x11

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipEquipTorch : BaseTip // TypeDefIndex: 11615
{	public static Translate.Phrase Phrase; // 0x0
	public static float nextTorchTipTime; // 0x8

	public static bool IsDark { get; }
	public static float TimeComfortableTotal { get; }
	public static bool HasTorchThatNeedsLighting { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public static bool get_IsDark() { }

	public static float get_TimeComfortableTotal() { }

	public static void TorchLit() { }

	public static bool get_HasTorchThatNeedsLighting() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipFillToolCupboard : BaseTip // TypeDefIndex: 11616
{	public static Translate.Phrase Phrase; // 0x2B0AAB0

	public int CupboardOpenedTimes { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public int get_CupboardOpenedTimes() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipFishingControls : BaseTip // TypeDefIndex: 11617
{	public static Translate.Phrase Phrase; // 0x1F4E0

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipFishingFail : BaseTip // TypeDefIndex: 11618
{	public static Translate.Phrase StrainPhrase; // 0x0
	public static Translate.Phrase AnglePhrase; // 0x8
	public static Translate.Phrase ObstructedPhrase; // 0x10

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipHealAtCampfire : BaseTip // TypeDefIndex: 11619
{	public static Translate.Phrase Phrase; // 0x0
	public float oldHealth; // 0x10
	public float lastHurtTime; // 0x14

	public bool IsHurt { get; }
	public float TimeComfortableTotal { get; }
	public bool HealEligable { get; }
	public bool RecentlyHurt { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public bool get_IsHurt() { }

	public float get_TimeComfortableTotal() { }

	public bool get_HealEligable() { }

	public bool get_RecentlyHurt() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipKayakPaddle : BaseTip // TypeDefIndex: 11620
{	public static Translate.Phrase Phrase; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static bool <hasPaddledWithoutOar>k__BackingField; // 0x8

	public override bool ShouldShow { get; }
	public static bool hasPaddledWithoutOar { get; set; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static bool get_hasPaddledWithoutOar() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void set_hasPaddledWithoutOar(bool value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipMLRSAimingModule : BaseTip // TypeDefIndex: 11621
{	public static Translate.Phrase Phrase; // 0x0
	public static bool wasMounted; // 0x8
	public static float nextTipTime; // 0xC

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipMLRSBrokenDown : BaseTip // TypeDefIndex: 11622
{	public static Translate.Phrase Phrase; // 0x0
	public static bool wasMounted; // 0x8
	public static float nextTipTime; // 0xC

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipMLRSNoRockets : BaseTip // TypeDefIndex: 11623
{	public static Translate.Phrase Phrase; // 0x0
	public static bool wasMounted; // 0x8
	public static float nextTipTime; // 0xC

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipMissingLure : BaseTip // TypeDefIndex: 11624
{	public static Translate.Phrase Phrase; // 0x1F513

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipNoBuild : BaseTip // TypeDefIndex: 11625
{	public static Translate.Phrase Phrase; // 0x2B0AAC4

	public static bool HasBuildingPlanEquipped { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public static bool get_HasBuildingPlanEquipped() { }

	public static bool AimingInNoBuild() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipPetControlWheel : BaseTip // TypeDefIndex: 11626
{	public static Translate.Phrase Phrase; // 0x0
	public static bool haveShown; // 0x8

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipPlaceSleepingBag : BaseTip // TypeDefIndex: 11627
{	public static Translate.Phrase Phrase; // 0x1F520

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipPlaceToolCupboard : BaseTip // TypeDefIndex: 11628
{	public static Translate.Phrase Phrase; // 0x1F566

	public int CupboardOpenedTimes { get; }
	public int NumBlocksPlaced { get; }
	public int NumBlocksUpgraded { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public int get_CupboardOpenedTimes() { }

	public int get_NumBlocksPlaced() { }

	public int get_NumBlocksUpgraded() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipPokerWinnings : BaseTip // TypeDefIndex: 11629
{	public static Translate.Phrase Phrase; // 0x2B0AC04

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipRads : BaseTip // TypeDefIndex: 11630
{	public static Translate.Phrase Phrase; // 0x1F570

	public float RadDuration { get; }
	public bool HasRads { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public float get_RadDuration() { }

	public bool get_HasRads() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipRemoveRads : BaseTip // TypeDefIndex: 11631
{	public static Translate.Phrase Phrase; // 0x1F5CB

	public float RadDuration { get; }
	public bool HasRads { get; }
	public bool HasRadExposure { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public float get_RadDuration() { }

	public bool get_HasRads() { }

	public bool get_HasRadExposure() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipReskinObject : BaseTip // TypeDefIndex: 11632
{	public static Translate.Phrase Phrase; // 0x2B0AB70

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipSledPlacement : BaseTip // TypeDefIndex: 11633
{	public static Translate.Phrase Phrase; // 0x1F5D0

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipSleepingBagPlacement : BaseTip // TypeDefIndex: 11634
{	public static Translate.Phrase Phrase; // 0x1F6D4

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipSnapAttractionPoint : BaseTip // TypeDefIndex: 11635
{	public static Translate.Phrase Phrase; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static bool <HasDismissedSnap>k__BackingField; // 0x8

	public override bool ShouldShow { get; }
	public static bool HasDismissedSnap { get; set; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static bool get_HasDismissedSnap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void set_HasDismissedSnap(bool value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipSnowmobileSurface : BaseTip // TypeDefIndex: 11636
{	public static Translate.Phrase Phrase; // 0x0
	public static bool showedMessage; // 0x8
	public static float nextTipTime; // 0xC

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipSprayControls : BaseTip // TypeDefIndex: 11637
{	public static Translate.Phrase Phrase; // 0x2B0AE58

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipTooCold : BaseTip // TypeDefIndex: 11638
{	public static Translate.Phrase Phrase; // 0x1F6E0

	public float ColdDuration { get; }
	public bool IsCold { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public float get_ColdDuration() { }

	public bool get_IsCold() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipTooHot : BaseTip // TypeDefIndex: 11639
{	public static Translate.Phrase Phrase; // 0x1F757

	public float HotDuration { get; }
	public bool IsHot { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public float get_HotDuration() { }

	public bool get_IsHot() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipZipline : BaseTip // TypeDefIndex: 11640
{	public static Translate.Phrase Phrase; // 0x2B0AAA0

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

