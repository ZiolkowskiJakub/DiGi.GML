#### [DiGi\.GML](DiGi.GML.Overview.md 'DiGi\.GML\.Overview')

## DiGi\.GML Namespace
### Classes

<a name='DiGi.GML.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.GML.Convert.ToGML_T_(string)'></a>

## Convert\.ToGML\<T\>\(string\) Method

Converts an XML file at the specified path to a list of GML objects of type [T](DiGi.GML.md#DiGi.GML.Convert.ToGML_T_(string).T 'DiGi\.GML\.Convert\.ToGML\<T\>\(string\)\.T')\.

```csharp
public static System.Collections.Generic.List<T>? ToGML<T>(string? path)
    where T : DiGi.GML.Interfaces.IAbstractGML;
```
#### Type parameters

<a name='DiGi.GML.Convert.ToGML_T_(string).T'></a>

`T`

The type of GML object, which must implement [IAbstractGML](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML 'DiGi\.GML\.Interfaces\.IAbstractGML')\.
#### Parameters

<a name='DiGi.GML.Convert.ToGML_T_(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file path to the XML source\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.GML.md#DiGi.GML.Convert.ToGML_T_(string).T 'DiGi\.GML\.Convert\.ToGML\<T\>\(string\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of objects of type [T](DiGi.GML.md#DiGi.GML.Convert.ToGML_T_(string).T 'DiGi\.GML\.Convert\.ToGML\<T\>\(string\)\.T') if successful; otherwise, null\.

<a name='DiGi.GML.Convert.ToGML_T_(System.IO.Stream)'></a>

## Convert\.ToGML\<T\>\(Stream\) Method

Converts an XML stream to a list of GML objects of type [T](DiGi.GML.md#DiGi.GML.Convert.ToGML_T_(System.IO.Stream).T 'DiGi\.GML\.Convert\.ToGML\<T\>\(System\.IO\.Stream\)\.T')\.

```csharp
public static System.Collections.Generic.List<T>? ToGML<T>(System.IO.Stream? stream)
    where T : DiGi.GML.Interfaces.IAbstractGML;
```
#### Type parameters

<a name='DiGi.GML.Convert.ToGML_T_(System.IO.Stream).T'></a>

`T`

The type of GML object, which must implement [IAbstractGML](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML 'DiGi\.GML\.Interfaces\.IAbstractGML')\.
#### Parameters

<a name='DiGi.GML.Convert.ToGML_T_(System.IO.Stream).stream'></a>

`stream` [System\.IO\.Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream 'System\.IO\.Stream')

The input stream containing the XML data\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.GML.md#DiGi.GML.Convert.ToGML_T_(System.IO.Stream).T 'DiGi\.GML\.Convert\.ToGML\<T\>\(System\.IO\.Stream\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of objects of type [T](DiGi.GML.md#DiGi.GML.Convert.ToGML_T_(System.IO.Stream).T 'DiGi\.GML\.Convert\.ToGML\<T\>\(System\.IO\.Stream\)\.T') if successful; otherwise, null\.

<a name='DiGi.GML.Convert.ToGML_T_(System.Xml.XmlDocument)'></a>

## Convert\.ToGML\<T\>\(XmlDocument\) Method

Converts an [System\.Xml\.XmlDocument](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmldocument 'System\.Xml\.XmlDocument') to a list of GML objects of type [T](DiGi.GML.md#DiGi.GML.Convert.ToGML_T_(System.Xml.XmlDocument).T 'DiGi\.GML\.Convert\.ToGML\<T\>\(System\.Xml\.XmlDocument\)\.T')\.

```csharp
public static System.Collections.Generic.List<T>? ToGML<T>(System.Xml.XmlDocument? xmlDocument)
    where T : DiGi.GML.Interfaces.IAbstractGML;
```
#### Type parameters

<a name='DiGi.GML.Convert.ToGML_T_(System.Xml.XmlDocument).T'></a>

`T`

The type of GML object, which must implement [IAbstractGML](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML 'DiGi\.GML\.Interfaces\.IAbstractGML')\.
#### Parameters

<a name='DiGi.GML.Convert.ToGML_T_(System.Xml.XmlDocument).xmlDocument'></a>

`xmlDocument` [System\.Xml\.XmlDocument](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmldocument 'System\.Xml\.XmlDocument')

The XML document to be converted\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.GML.md#DiGi.GML.Convert.ToGML_T_(System.Xml.XmlDocument).T 'DiGi\.GML\.Convert\.ToGML\<T\>\(System\.Xml\.XmlDocument\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of objects of type [T](DiGi.GML.md#DiGi.GML.Convert.ToGML_T_(System.Xml.XmlDocument).T 'DiGi\.GML\.Convert\.ToGML\<T\>\(System\.Xml\.XmlDocument\)\.T') if successful; otherwise, null\.

<a name='DiGi.GML.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.GML.Create.AbstractGML(thisSystem.Xml.XmlNode)'></a>

## Create\.AbstractGML\(this XmlNode\) Method

Creates an instance of a class implementing [IAbstractGML](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML 'DiGi\.GML\.Interfaces\.IAbstractGML') based on the provided XML node\.

```csharp
public static DiGi.GML.Interfaces.IAbstractGML? AbstractGML(this System.Xml.XmlNode? xmlNode);
```
#### Parameters

<a name='DiGi.GML.Create.AbstractGML(thisSystem.Xml.XmlNode).xmlNode'></a>

`xmlNode` [System\.Xml\.XmlNode](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmlnode 'System\.Xml\.XmlNode')

The XML node to be converted into an [IAbstractGML](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML 'DiGi\.GML\.Interfaces\.IAbstractGML') object\.

#### Returns
[IAbstractGML](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML 'DiGi\.GML\.Interfaces\.IAbstractGML')  
An implementation of [IAbstractGML](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML 'DiGi\.GML\.Interfaces\.IAbstractGML') if successful; otherwise, null\.

<a name='DiGi.GML.Create.AbstractGML_T_(thisSystem.Xml.XmlNode)'></a>

## Create\.AbstractGML\<T\>\(this XmlNode\) Method

Creates an instance of a class implementing the specified generic type [T](DiGi.GML.md#DiGi.GML.Create.AbstractGML_T_(thisSystem.Xml.XmlNode).T 'DiGi\.GML\.Create\.AbstractGML\<T\>\(this System\.Xml\.XmlNode\)\.T') based on the provided XML node\.

```csharp
public static T? AbstractGML<T>(this System.Xml.XmlNode? xmlNode)
    where T : DiGi.GML.Interfaces.IAbstractGML;
```
#### Type parameters

<a name='DiGi.GML.Create.AbstractGML_T_(thisSystem.Xml.XmlNode).T'></a>

`T`

The specific type that implements [IAbstractGML](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML 'DiGi\.GML\.Interfaces\.IAbstractGML')\.
#### Parameters

<a name='DiGi.GML.Create.AbstractGML_T_(thisSystem.Xml.XmlNode).xmlNode'></a>

`xmlNode` [System\.Xml\.XmlNode](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmlnode 'System\.Xml\.XmlNode')

The XML node to be converted into an object of type [T](DiGi.GML.md#DiGi.GML.Create.AbstractGML_T_(thisSystem.Xml.XmlNode).T 'DiGi\.GML\.Create\.AbstractGML\<T\>\(this System\.Xml\.XmlNode\)\.T')\.

#### Returns
[T](DiGi.GML.md#DiGi.GML.Create.AbstractGML_T_(thisSystem.Xml.XmlNode).T 'DiGi\.GML\.Create\.AbstractGML\<T\>\(this System\.Xml\.XmlNode\)\.T')  
An instance of type [T](DiGi.GML.md#DiGi.GML.Create.AbstractGML_T_(thisSystem.Xml.XmlNode).T 'DiGi\.GML\.Create\.AbstractGML\<T\>\(this System\.Xml\.XmlNode\)\.T') if successful; otherwise, null\.

<a name='DiGi.GML.Create.TypeManager()'></a>

## Create\.TypeManager\(\) Method

Initializes and returns a new instance of the [TypeManager\(\)](DiGi.GML.md#DiGi.GML.Create.TypeManager() 'DiGi\.GML\.Create\.TypeManager\(\)'), 
ensuring that all assemblies in the current application domain, referenced assemblies, 
and DLLs located in the entry assembly's directory are loaded\.

```csharp
public static DiGi.GML.Classes.TypeManager TypeManager();
```

#### Returns
[TypeManager](DiGi.GML.Classes.md#DiGi.GML.Classes.TypeManager 'DiGi\.GML\.Classes\.TypeManager')  
A newly created instance of the [TypeManager\(\)](DiGi.GML.md#DiGi.GML.Create.TypeManager() 'DiGi\.GML\.Create\.TypeManager\(\)') class\.

<a name='DiGi.GML.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.GML.Modify.Update(thisDiGi.GML.Interfaces.IAbstractGML,System.Xml.XmlNode)'></a>

## Modify\.Update\(this IAbstractGML, XmlNode\) Method

Updates the properties of an [IAbstractGML](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML 'DiGi\.GML\.Interfaces\.IAbstractGML') instance based on the values provided in an [System\.Xml\.XmlNode](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmlnode 'System\.Xml\.XmlNode')\.

```csharp
public static bool Update(this DiGi.GML.Interfaces.IAbstractGML abstractGML, System.Xml.XmlNode xmlNode);
```
#### Parameters

<a name='DiGi.GML.Modify.Update(thisDiGi.GML.Interfaces.IAbstractGML,System.Xml.XmlNode).abstractGML'></a>

`abstractGML` [IAbstractGML](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML 'DiGi\.GML\.Interfaces\.IAbstractGML')

The GML object to be updated\.

<a name='DiGi.GML.Modify.Update(thisDiGi.GML.Interfaces.IAbstractGML,System.Xml.XmlNode).xmlNode'></a>

`xmlNode` [System\.Xml\.XmlNode](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmlnode 'System\.Xml\.XmlNode')

The XML node containing the source data for the update\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if at least one property was successfully updated; otherwise, false\.

<a name='DiGi.GML.Modify.Update_T_(thisT,T)'></a>

## Modify\.Update\<T\>\(this T, T\) Method

Updates the properties of a destination GML object using values from a source GML object of the same type\.

```csharp
public static bool Update<T>(this T abstractGML_Source, T abstractGML_Destination)
    where T : DiGi.GML.Interfaces.IAbstractGML;
```
#### Type parameters

<a name='DiGi.GML.Modify.Update_T_(thisT,T).T'></a>

`T`

A type that implements [IAbstractGML](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML 'DiGi\.GML\.Interfaces\.IAbstractGML')\.
#### Parameters

<a name='DiGi.GML.Modify.Update_T_(thisT,T).abstractGML_Source'></a>

`abstractGML_Source` [T](DiGi.GML.md#DiGi.GML.Modify.Update_T_(thisT,T).T 'DiGi\.GML\.Modify\.Update\<T\>\(this T, T\)\.T')

The source GML object containing the data to copy\.

<a name='DiGi.GML.Modify.Update_T_(thisT,T).abstractGML_Destination'></a>

`abstractGML_Destination` [T](DiGi.GML.md#DiGi.GML.Modify.Update_T_(thisT,T).T 'DiGi\.GML\.Modify\.Update\<T\>\(this T, T\)\.T')

The destination GML object to be updated\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the update process completed; otherwise, false\.

<a name='DiGi.GML.Modify.Update_T_(thisT,T,System.Reflection.PropertyInfo)'></a>

## Modify\.Update\<T\>\(this T, T, PropertyInfo\) Method

Updates a specific property of a destination GML object using the value from the corresponding property of a source GML object\.

```csharp
public static bool Update<T>(this T abstractGML_Source, T abstractGML_Destination, System.Reflection.PropertyInfo propertyInfo);
```
#### Type parameters

<a name='DiGi.GML.Modify.Update_T_(thisT,T,System.Reflection.PropertyInfo).T'></a>

`T`

A type that implements [IAbstractGML](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML 'DiGi\.GML\.Interfaces\.IAbstractGML')\.
#### Parameters

<a name='DiGi.GML.Modify.Update_T_(thisT,T,System.Reflection.PropertyInfo).abstractGML_Source'></a>

`abstractGML_Source` [T](DiGi.GML.md#DiGi.GML.Modify.Update_T_(thisT,T,System.Reflection.PropertyInfo).T 'DiGi\.GML\.Modify\.Update\<T\>\(this T, T, System\.Reflection\.PropertyInfo\)\.T')

The source GML object containing the data to copy\.

<a name='DiGi.GML.Modify.Update_T_(thisT,T,System.Reflection.PropertyInfo).abstractGML_Destination'></a>

`abstractGML_Destination` [T](DiGi.GML.md#DiGi.GML.Modify.Update_T_(thisT,T,System.Reflection.PropertyInfo).T 'DiGi\.GML\.Modify\.Update\<T\>\(this T, T, System\.Reflection\.PropertyInfo\)\.T')

The destination GML object to be updated\.

<a name='DiGi.GML.Modify.Update_T_(thisT,T,System.Reflection.PropertyInfo).propertyInfo'></a>

`propertyInfo` [System\.Reflection\.PropertyInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo 'System\.Reflection\.PropertyInfo')

The property information of the member to be updated\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the property was successfully updated; otherwise, false\.

<a name='DiGi.GML.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.GML.Query.Clone_T_(thisT)'></a>

## Query\.Clone\<T\>\(this T\) Method

Creates a clone of the specified GML object by instantiating a new instance of its type and copying its properties\.

```csharp
public static T? Clone<T>(this T? abstractGML)
    where T : DiGi.GML.Interfaces.IAbstractGML;
```
#### Type parameters

<a name='DiGi.GML.Query.Clone_T_(thisT).T'></a>

`T`

The type of the GML object, which must implement [IAbstractGML](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML 'DiGi\.GML\.Interfaces\.IAbstractGML')\.
#### Parameters

<a name='DiGi.GML.Query.Clone_T_(thisT).abstractGML'></a>

`abstractGML` [T](DiGi.GML.md#DiGi.GML.Query.Clone_T_(thisT).T 'DiGi\.GML\.Query\.Clone\<T\>\(this T\)\.T')

The source GML object to clone\.

#### Returns
[T](DiGi.GML.md#DiGi.GML.Query.Clone_T_(thisT).T 'DiGi\.GML\.Query\.Clone\<T\>\(this T\)\.T')  
A new instance of type [T](DiGi.GML.md#DiGi.GML.Query.Clone_T_(thisT).T 'DiGi\.GML\.Query\.Clone\<T\>\(this T\)\.T') containing the cloned data, or `null` if the input is null or the type cannot be instantiated as [T](DiGi.GML.md#DiGi.GML.Query.Clone_T_(thisT).T 'DiGi\.GML\.Query\.Clone\<T\>\(this T\)\.T')\.

<a name='DiGi.GML.Query.Description(thisSystem.Enum)'></a>

## Query\.Description\(this Enum\) Method

Retrieves the description of an enumeration value, prioritizing the value defined in the [System\.ComponentModel\.DescriptionAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.descriptionattribute 'System\.ComponentModel\.DescriptionAttribute')\.

```csharp
public static string Description(this System.Enum @enum);
```
#### Parameters

<a name='DiGi.GML.Query.Description(thisSystem.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value to extract the description from\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The string value of the [System\.ComponentModel\.DescriptionAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.descriptionattribute 'System\.ComponentModel\.DescriptionAttribute') if present; otherwise, the string representation of the enum member\.

<a name='DiGi.GML.Query.PropertyInfoDictionary(thisDiGi.GML.Interfaces.IAbstractGML)'></a>

## Query\.PropertyInfoDictionary\(this IAbstractGML\) Method

Creates a dictionary of property information where the key is the name of the property and the value is the [System\.Reflection\.PropertyInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo 'System\.Reflection\.PropertyInfo')\.

```csharp
public static System.Collections.Generic.Dictionary<string,System.Reflection.PropertyInfo>? PropertyInfoDictionary(this DiGi.GML.Interfaces.IAbstractGML? abstractGML);
```
#### Parameters

<a name='DiGi.GML.Query.PropertyInfoDictionary(thisDiGi.GML.Interfaces.IAbstractGML).abstractGML'></a>

`abstractGML` [IAbstractGML](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML 'DiGi\.GML\.Interfaces\.IAbstractGML')

The abstract GML instance to extract property information from\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Reflection\.PropertyInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo 'System\.Reflection\.PropertyInfo')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary containing the mapping of property names to their respective [System\.Reflection\.PropertyInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo 'System\.Reflection\.PropertyInfo'), or null if the provided [abstractGML](DiGi.GML.md#DiGi.GML.Query.PropertyInfoDictionary(thisDiGi.GML.Interfaces.IAbstractGML).abstractGML 'DiGi\.GML\.Query\.PropertyInfoDictionary\(this DiGi\.GML\.Interfaces\.IAbstractGML\)\.abstractGML') is null or contains no property information\.

<a name='DiGi.GML.Query.PropertyInfos(thisDiGi.GML.Interfaces.IAbstractGML)'></a>

## Query\.PropertyInfos\(this IAbstractGML\) Method

Retrieves a list of property information for the specified abstract GML object using reflection\.

```csharp
public static System.Collections.Generic.List<System.Reflection.PropertyInfo>? PropertyInfos(this DiGi.GML.Interfaces.IAbstractGML? abstractGML);
```
#### Parameters

<a name='DiGi.GML.Query.PropertyInfos(thisDiGi.GML.Interfaces.IAbstractGML).abstractGML'></a>

`abstractGML` [IAbstractGML](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML 'DiGi\.GML\.Interfaces\.IAbstractGML')

The abstract GML instance to extract properties from\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Reflection\.PropertyInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo 'System\.Reflection\.PropertyInfo')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [System\.Reflection\.PropertyInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo 'System\.Reflection\.PropertyInfo') objects if the input is not null; otherwise, null\.

<a name='DiGi.GML.Query.TryConvert(string,System.Reflection.PropertyInfo,object)'></a>

## Query\.TryConvert\(string, PropertyInfo, object\) Method

Attempts to convert a string representation of a value to an object based on the provided property information\.

```csharp
public static bool TryConvert(string? text, System.Reflection.PropertyInfo? propertyInfo, out object? value);
```
#### Parameters

<a name='DiGi.GML.Query.TryConvert(string,System.Reflection.PropertyInfo,object).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string input to be converted\.

<a name='DiGi.GML.Query.TryConvert(string,System.Reflection.PropertyInfo,object).propertyInfo'></a>

`propertyInfo` [System\.Reflection\.PropertyInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo 'System\.Reflection\.PropertyInfo')

The property whose type determines the target conversion type\.

<a name='DiGi.GML.Query.TryConvert(string,System.Reflection.PropertyInfo,object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains the converted value if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.GML.Query.TryConvert(string,System.Type,object)'></a>

## Query\.TryConvert\(string, Type, object\) Method

Attempts to convert a string representation of a value to an object of the specified type\.

```csharp
public static bool TryConvert(string? text, System.Type? type, out object? value);
```
#### Parameters

<a name='DiGi.GML.Query.TryConvert(string,System.Type,object).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string input to be converted\.

<a name='DiGi.GML.Query.TryConvert(string,System.Type,object).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The target type for conversion\.

<a name='DiGi.GML.Query.TryConvert(string,System.Type,object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains the converted value if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.GML.Query.TryGetEnum(thisstring,System.Type,System.Enum)'></a>

## Query\.TryGetEnum\(this string, Type, Enum\) Method

Attempts to convert a string representation to an enumeration value of the specified type based on the member's description\.

```csharp
public static bool TryGetEnum(this string? text, System.Type? type, out System.Enum? @enum);
```
#### Parameters

<a name='DiGi.GML.Query.TryGetEnum(thisstring,System.Type,System.Enum).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string text to be converted\.

<a name='DiGi.GML.Query.TryGetEnum(thisstring,System.Type,System.Enum).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The Type object that represents the enumeration type\.

<a name='DiGi.GML.Query.TryGetEnum(thisstring,System.Type,System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

When this method returns, contains the enumeration value if conversion succeeded, or the default value otherwise\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.GML.Query.TryGetEnum_T_(thisstring,T)'></a>

## Query\.TryGetEnum\<T\>\(this string, T\) Method

Attempts to convert a string representation to an enumeration value of type T based on the member's description\.

```csharp
public static bool TryGetEnum<T>(this string? text, out T? @enum)
    where T : System.Enum;
```
#### Type parameters

<a name='DiGi.GML.Query.TryGetEnum_T_(thisstring,T).T'></a>

`T`

The enumeration type\.
#### Parameters

<a name='DiGi.GML.Query.TryGetEnum_T_(thisstring,T).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string text to be converted\.

<a name='DiGi.GML.Query.TryGetEnum_T_(thisstring,T).enum'></a>

`enum` [T](DiGi.GML.md#DiGi.GML.Query.TryGetEnum_T_(thisstring,T).T 'DiGi\.GML\.Query\.TryGetEnum\<T\>\(this string, T\)\.T')

When this method returns, contains the enumeration value if conversion succeeded, or the default value otherwise\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.GML.Settings'></a>

## Settings Class

```csharp
public static class Settings
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Settings
### Properties

<a name='DiGi.GML.Settings.TypeManager'></a>

## Settings\.TypeManager Property

Gets the type manager instance used for handling GML types\.

```csharp
public static DiGi.GML.Classes.TypeManager TypeManager { get; }
```

#### Property Value
[TypeManager](DiGi.GML.Classes.md#DiGi.GML.Classes.TypeManager 'DiGi\.GML\.Classes\.TypeManager')