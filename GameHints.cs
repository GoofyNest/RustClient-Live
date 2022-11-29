public class HowToExamineHeld : BaseTip // TypeDefIndex: 13381
{
	public static Translate.Phrase Phrase; 

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

public class HowToHammerUpgrade : BaseTip // TypeDefIndex: 13382
{
	public static Translate.Phrase Phrase; 
	public static float lastBuildChangeTime; 

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

public class HowToOpenBuildOptions : BaseTip // TypeDefIndex: 13383
{
	public static Translate.Phrase Phrase; 
	public static float lastBuildChangeTime; 

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

public class HowToOpenCrafting : BaseTip // TypeDefIndex: 13384
{
	public static Translate.Phrase Phrase; 

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

public class HowToOpenInventory : BaseTip // TypeDefIndex: 13385
{
	public static Translate.Phrase Phrase; 

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

public class HowToOpenMap : BaseTip // TypeDefIndex: 13386
{
	public static Translate.Phrase Phrase; 

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

public class HowToOreMinigame : BaseTip // TypeDefIndex: 13387
{
	public static Translate.Phrase Phrase; 
	public static float lastOreHitTime; 

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

public class HowToRegenWithComfort : BaseTip // TypeDefIndex: 13388
{
	public static Translate.Phrase Phrase; 

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

public class HowToRetrieveThrown : BaseTip // TypeDefIndex: 13389
{
	public static Translate.Phrase Phrase; 

	public static bool HasThrowableItemEquipped { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public static bool get_HasThrowableItemEquipped() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class HowToThrow : BaseTip // TypeDefIndex: 13390
{
	public static Translate.Phrase Phrase; 
	public static bool itemThrown; 
	public static float lastThrownTime; 

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

public class HowToTreeMinigame : BaseTip // TypeDefIndex: 13391
{
	public static Translate.Phrase Phrase; 
	public static float lastTreeHitTime; 

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

public class HowToUseBow : BaseTip // TypeDefIndex: 13392
{
	public static Translate.Phrase Phrase; 

	public static bool HasBowItemEquipped { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public static bool get_HasBowItemEquipped() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class HowToUseGrenade : BaseTip // TypeDefIndex: 13393
{
	public static Translate.Phrase Phrase; 

	private static bool HasGrenadeItemEquipped { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	private static bool get_HasGrenadeItemEquipped() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class HowToUseWave : BaseTip // TypeDefIndex: 13394
{
	public static Translate.Phrase Phrase; 
	public static float lastWavedAtTime; 
	public static float lastLocalWaveTime; 

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

public class HowToVoiceChat : BaseTip // TypeDefIndex: 13395
{
	public static Translate.Phrase Phrase; 

	public float SecondsSpeaking { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public float get_SecondsSpeaking() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class HowToWorldDrink : BaseTip // TypeDefIndex: 13396
{
	public static Translate.Phrase Phrase; 

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

public class TipInstrumentFullKeyboard : InstrumentTip // TypeDefIndex: 13398
{
	public static Translate.Phrase Phrase; 

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipInstrumentNumlock : InstrumentTip // TypeDefIndex: 13399
{
	public static Translate.Phrase Phrase; 

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipInstrumentPlay : InstrumentTip // TypeDefIndex: 13400
{
	public static Translate.Phrase Phrase; 

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipBreakCarLock : BaseTip // TypeDefIndex: 13402
{
	public static Translate.Phrase Phrase; 
	public static bool wasShowing; 
	public static float nextTipTime; 
	public const float MIN_TIME_BETWEEN_TIPS = 300;

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public static bool AimingInNoBuild() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipCannotHarvest : BaseTip // TypeDefIndex: 13403
{
	public static Translate.Phrase Phrase; 
	public static float nonEntityHitTime; 

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

public class TipConsumeFood : BaseTip // TypeDefIndex: 13404
{
	public static Translate.Phrase Phrase; 
	public float lastFoodPickupTime; 
	public int lastFoodPickupCount; 

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

public class TipControllingMagnetCrane : BaseTip // TypeDefIndex: 13405
{
	public static Translate.Phrase Phrase; 
	private bool wasMounted; 
	private TimeSince timeSinceShown; 

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipDrivingSubmarine : BaseTip // TypeDefIndex: 13406
{
	public static Translate.Phrase Phrase; 
	private bool wasMounted; 
	private bool haveShown; 

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipEquipTorch : BaseTip // TypeDefIndex: 13407
{
	public static Translate.Phrase Phrase; 
	public static float nextTorchTipTime; 

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

public class TipFillToolCupboard : BaseTip // TypeDefIndex: 13408
{
	public static Translate.Phrase Phrase; 

	public int CupboardOpenedTimes { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public int get_CupboardOpenedTimes() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipFishingControls : BaseTip // TypeDefIndex: 13409
{
	public static Translate.Phrase Phrase; 

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipFishingFail : BaseTip // TypeDefIndex: 13410
{
	public static Translate.Phrase StrainPhrase; 
	public static Translate.Phrase AnglePhrase; 
	public static Translate.Phrase ObstructedPhrase; 

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipHealAtCampfire : BaseTip // TypeDefIndex: 13411
{
	public static Translate.Phrase Phrase; 
	public float oldHealth; 
	public float lastHurtTime; 

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

public class TipKayakPaddle : BaseTip // TypeDefIndex: 13412
{
	public static Translate.Phrase Phrase; 
	[CompilerGeneratedAttribute] 
	private static bool <hasPaddledWithoutOar>k__BackingField; 

	public override bool ShouldShow { get; }
	public static bool hasPaddledWithoutOar { get; set; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	[CompilerGeneratedAttribute] 
	public static bool get_hasPaddledWithoutOar() { }

	[CompilerGeneratedAttribute] 
	public static void set_hasPaddledWithoutOar(bool value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipMLRSAimingModule : BaseTip // TypeDefIndex: 13413
{
	public static Translate.Phrase Phrase; 
	public static bool wasMounted; 
	public static float nextTipTime; 

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipMLRSBrokenDown : BaseTip // TypeDefIndex: 13414
{
	public static Translate.Phrase Phrase; 
	public static bool wasMounted; 
	public static float nextTipTime; 

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipMLRSNoRockets : BaseTip // TypeDefIndex: 13415
{
	public static Translate.Phrase Phrase; 
	public static bool wasMounted; 
	public static float nextTipTime; 

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipMissingLure : BaseTip // TypeDefIndex: 13416
{
	public static Translate.Phrase Phrase; 

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipNoBuild : BaseTip // TypeDefIndex: 13417
{
	public static Translate.Phrase Phrase; 

	public static bool HasBuildingPlanEquipped { get; }
	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public static bool get_HasBuildingPlanEquipped() { }

	public static bool AimingInNoBuild() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipPetControlWheel : BaseTip // TypeDefIndex: 13418
{
	public static Translate.Phrase Phrase; 
	public static bool haveShown; 

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipPlaceSleepingBag : BaseTip // TypeDefIndex: 13419
{
	public static Translate.Phrase Phrase; 

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipPlaceToolCupboard : BaseTip // TypeDefIndex: 13420
{
	public static Translate.Phrase Phrase; 

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

public class TipPokerWinnings : BaseTip // TypeDefIndex: 13421
{
	public static Translate.Phrase Phrase; 

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipRads : BaseTip // TypeDefIndex: 13422
{
	public static Translate.Phrase Phrase; 

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

public class TipRemoveRads : BaseTip // TypeDefIndex: 13423
{
	public static Translate.Phrase Phrase; 

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

public class TipReskinObject : BaseTip // TypeDefIndex: 13424
{
	public static Translate.Phrase Phrase; 

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipSledPlacement : BaseTip // TypeDefIndex: 13425
{
	public static Translate.Phrase Phrase; 

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipSleepingBagPlacement : BaseTip // TypeDefIndex: 13426
{
	public static Translate.Phrase Phrase; 

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipSnapAttractionPoint : BaseTip // TypeDefIndex: 13427
{
	public static Translate.Phrase Phrase; 
	[CompilerGeneratedAttribute] 
	private static bool <HasDismissedSnap>k__BackingField; 

	public override bool ShouldShow { get; }
	public static bool HasDismissedSnap { get; set; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	[CompilerGeneratedAttribute] 
	public static bool get_HasDismissedSnap() { }

	[CompilerGeneratedAttribute] 
	public static void set_HasDismissedSnap(bool value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipSnowmobileSurface : BaseTip // TypeDefIndex: 13428
{
	public static Translate.Phrase Phrase; 
	public static bool showedMessage; 
	public static float nextTipTime; 

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipSprayControls : BaseTip // TypeDefIndex: 13429
{
	public static Translate.Phrase Phrase; 

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TipTooCold : BaseTip // TypeDefIndex: 13430
{
	public static Translate.Phrase Phrase; 

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

public class TipTooHot : BaseTip // TypeDefIndex: 13431
{
	public static Translate.Phrase Phrase; 

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

public class TipZipline : BaseTip // TypeDefIndex: 13432
{
	public static Translate.Phrase Phrase; 

	public override bool ShouldShow { get; }


	public override Translate.Phrase GetPhrase() { }

	public override bool get_ShouldShow() { }

	public void .ctor() { }

	private static void .cctor() { }

}

