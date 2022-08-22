public class RegionInfo // TypeDefIndex: 746
{	private static RegionInfo currentRegion; // 0x0
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


	public static RegionInfo get_CurrentRegion() { }

	public void .ctor(int culture) { }

	public void .ctor(string name) { }

	private void .ctor(CultureInfo ci) { }

	private bool GetByTerritory(CultureInfo ci) { }

	private bool construct_internal_region_from_name(string name) { }

	public virtual string get_CurrencyEnglishName() { }

	public virtual string get_CurrencySymbol() { }

	public virtual string get_DisplayName() { }

	public virtual string get_EnglishName() { }

	public virtual int get_GeoId() { }

	public virtual bool get_IsMetric() { }

	public virtual string get_ISOCurrencySymbol() { }

	public virtual string get_NativeName() { }

	public virtual string get_CurrencyNativeName() { }

	public virtual string get_Name() { }

	public virtual string get_ThreeLetterISORegionName() { }

	public virtual string get_ThreeLetterWindowsRegionName() { }

	public virtual string get_TwoLetterISORegionName() { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	internal static void ClearCachedData() { }

}

