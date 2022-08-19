public class ProductInfoHeaderValue : ICloneable // TypeDefIndex: 5802
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Comment>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ProductHeaderValue <Product>k__BackingField; // 0x18

	// Properties
	public string Comment { get; set; }
	public ProductHeaderValue Product { get; set; }

	// Methods

	// RVA: 0x108F920 Offset: 0x108ED20 VA: 0x18108F920
	public void .ctor(ProductHeaderValue product) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	private void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Comment() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	private void set_Comment(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public ProductHeaderValue get_Product() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	private void set_Product(ProductHeaderValue value) { }

	// RVA: 0xD6C080 Offset: 0xD6B480 VA: 0x180D6C080 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x108F3E0 Offset: 0x108E7E0 VA: 0x18108F3E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x108F4A0 Offset: 0x108E8A0 VA: 0x18108F4A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x108F7D0 Offset: 0x108EBD0 VA: 0x18108F7D0
	internal static bool TryParse(string input, int minimalCount, out List<ProductInfoHeaderValue> result) { }

	// RVA: 0x108F520 Offset: 0x108E920 VA: 0x18108F520
	private static bool TryParseElement(Lexer lexer, out ProductInfoHeaderValue parsedValue) { }

	// RVA: 0x108F4F0 Offset: 0x108E8F0 VA: 0x18108F4F0 Slot: 3
	public override string ToString() { }

}

