internal sealed class AllElementsContentValidator : ContentValidator // TypeDefIndex: 2173
{
	private Hashtable elements; 
	private object[] particles; 
	private BitSet isRequired; 
	private int countRequired; 

public override bool IsEmptiable { get; }


public void .ctor(XmlSchemaContentType contentType, int size, bool isEmptiable) { }

public bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable) { }

public override bool get_IsEmptiable() { }

public override void InitValidation(ValidationState context) { }

public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

public override bool CompleteValidation(ValidationState context) { }

public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

