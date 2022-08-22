internal static class CollectionParser // TypeDefIndex: 5762
{
	public static bool TryParse<T>(string input, int minimalCount, ElementTryParser<T> parser, out List<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE9DD0 Offset: 0xBE91D0 VA: 0x180BE9DD0
	|-CollectionParser.TryParse<AuthenticationHeaderValue>
	|-CollectionParser.TryParse<EntityTagHeaderValue>
	|-CollectionParser.TryParse<MediaTypeWithQualityHeaderValue>
	|-CollectionParser.TryParse<NameValueHeaderValue>
	|-CollectionParser.TryParse<NameValueWithParametersHeaderValue>
	|-CollectionParser.TryParse<ProductHeaderValue>
	|-CollectionParser.TryParse<StringWithQualityHeaderValue>
	|-CollectionParser.TryParse<TransferCodingHeaderValue>
	|-CollectionParser.TryParse<TransferCodingWithQualityHeaderValue>
	|-CollectionParser.TryParse<ViaHeaderValue>
	|-CollectionParser.TryParse<WarningHeaderValue>
	|-CollectionParser.TryParse<object>
	|-CollectionParser.TryParse<string>
	*/

	public static bool TryParse(string input, int minimalCount, out List<string> result) { }

	private static bool TryParseStringElement(Lexer lexer, out string parsedValue, out Token t) { }

}

