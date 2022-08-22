public class ProductInfoHeaderValue : ICloneable // TypeDefIndex: 5802
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Comment>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ProductHeaderValue <Product>k__BackingField; // 0x18

	public string Comment { get; set; }
	public ProductHeaderValue Product { get; set; }


	public void .ctor(ProductHeaderValue product) { }

	private void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Comment() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Comment(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ProductHeaderValue get_Product() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Product(ProductHeaderValue value) { }

	private object System.ICloneable.Clone() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	internal static bool TryParse(string input, int minimalCount, out List<ProductInfoHeaderValue> result) { }

	private static bool TryParseElement(Lexer lexer, out ProductInfoHeaderValue parsedValue) { }

	public override string ToString() { }

}

