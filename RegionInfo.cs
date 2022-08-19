public class RegionInfo // TypeDefIndex: 746
{	// Fields
	private static RegionInfo currentRegion; // 0x0
	private int regionId; // 0x10
	private string iso2Name; // 0x18
	private string iso3Name; // 0x20
	private string win3Name; // 0x28
	private string englishName; // 0x30
	private string nativeName; // 0x38
	private string currencySymbol; // 0x40
	private string isoCurrencySymbol; // 0x48
	private string currencyEnglishName; // 0x50
	private string currencyNativeName; // 0x58

	// Properties
	public static RegionInfo CurrentRegion { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public virtual string CurrencyEnglishName { get; }
	public virtual string CurrencySymbol { get; }
	[MonoTODOAttribute] // RVA: 0xB1DB0 Offset: 0xB11B0 VA: 0x1800B1DB0
	public virtual string DisplayName { get; }
	public virtual string EnglishName { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public virtual int GeoId { get; }
	public virtual bool IsMetric { get; }
	public virtual string ISOCurrencySymbol { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public virtual string NativeName { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public virtual string CurrencyNativeName { get; }
	public virtual string Name { get; }
	public virtual string ThreeLetterISORegionName { get; }
	public virtual string ThreeLetterWindowsRegionName { get; }
	public virtual string TwoLetterISORegionName { get; }

	// Methods

	// RVA: 0x13807D0 Offset: 0x137FBD0 VA: 0x1813807D0
	public static RegionInfo get_CurrentRegion() { }

	// RVA: 0x1380660 Offset: 0x137FA60 VA: 0x181380660
	public void .ctor(int culture) { }

	// RVA: 0x13804C0 Offset: 0x137F8C0 VA: 0x1813804C0
	public void .ctor(string name) { }

	// RVA: 0x1380350 Offset: 0x137F750 VA: 0x181380350
	private void .ctor(CultureInfo ci) { }

	// RVA: 0x1380240 Offset: 0x137F640 VA: 0x181380240
	private bool GetByTerritory(CultureInfo ci) { }

	// RVA: 0x13807C0 Offset: 0x137FBC0 VA: 0x1813807C0
	private bool construct_internal_region_from_name(string name) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 4
	public virtual string get_CurrencyEnglishName() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440 Slot: 5
	public virtual string get_CurrencySymbol() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 6
	public virtual string get_DisplayName() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 7
	public virtual string get_EnglishName() { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480 Slot: 8
	public virtual int get_GeoId() { }

	// RVA: 0x13809D0 Offset: 0x137FDD0 VA: 0x1813809D0 Slot: 9
	public virtual bool get_IsMetric() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0 Slot: 10
	public virtual string get_ISOCurrencySymbol() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00 Slot: 11
	public virtual string get_NativeName() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340 Slot: 12
	public virtual string get_CurrencyNativeName() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 13
	public virtual string get_Name() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 14
	public virtual string get_ThreeLetterISORegionName() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 15
	public virtual string get_ThreeLetterWindowsRegionName() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 16
	public virtual string get_TwoLetterISORegionName() { }

	// RVA: 0x1380170 Offset: 0x137F570 VA: 0x181380170 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x13802F0 Offset: 0x137F6F0 VA: 0x1813802F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1380330 Offset: 0x137F730 VA: 0x181380330 Slot: 3
	public override string ToString() { }

	// RVA: 0x1380130 Offset: 0x137F530 VA: 0x181380130
	internal static void ClearCachedData() { }

}

