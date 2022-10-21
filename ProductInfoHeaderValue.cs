public class ProductInfoHeaderValue : ICloneable // TypeDefIndex: 5807
{
	[CompilerGeneratedAttribute] 
	private string <Comment>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductHeaderValue <Product>k__BackingField; 

	public string Comment { get; set; }
	public ProductHeaderValue Product { get; set; }


	public void .ctor(ProductHeaderValue product) { }

	private void .ctor() { }

	[CompilerGeneratedAttribute] 
	public string get_Comment() { }

	[CompilerGeneratedAttribute] 
	private void set_Comment(string value) { }

	[CompilerGeneratedAttribute] 
	public ProductHeaderValue get_Product() { }

	[CompilerGeneratedAttribute] 
	private void set_Product(ProductHeaderValue value) { }

	private object System.ICloneable.Clone() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	internal static bool TryParse(string input, int minimalCount, out List<ProductInfoHeaderValue> result) { }

	private static bool TryParseElement(Lexer lexer, out ProductInfoHeaderValue parsedValue) { }

	public override string ToString() { }

}

