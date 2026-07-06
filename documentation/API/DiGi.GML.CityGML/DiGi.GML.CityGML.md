#### [DiGi\.GML\.CityGML](index.md 'index')

## DiGi\.GML\.CityGML Namespace
### Classes

<a name='DiGi.GML.CityGML.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.GML.CityGML.Convert.ToGML(string)'></a>

## Convert\.ToGML\(string\) Method

Converts a CityGML file from the specified file path to a [CityModel](DiGi.GML.CityGML.Classes.md#DiGi.GML.CityGML.Classes.CityModel 'DiGi\.GML\.CityGML\.Classes\.CityModel') object\.

```csharp
public static DiGi.GML.CityGML.Classes.CityModel ToGML(string path);
```
#### Parameters

<a name='DiGi.GML.CityGML.Convert.ToGML(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file system path to the XML file\.

#### Returns
[CityModel](DiGi.GML.CityGML.Classes.md#DiGi.GML.CityGML.Classes.CityModel 'DiGi\.GML\.CityGML\.Classes\.CityModel')  
A [CityModel](DiGi.GML.CityGML.Classes.md#DiGi.GML.CityGML.Classes.CityModel 'DiGi\.GML\.CityGML\.Classes\.CityModel') instance if the conversion is successful; otherwise, null\.

<a name='DiGi.GML.CityGML.Convert.ToGML(System.IO.Stream)'></a>

## Convert\.ToGML\(Stream\) Method

Converts a CityGML stream to a [CityModel](DiGi.GML.CityGML.Classes.md#DiGi.GML.CityGML.Classes.CityModel 'DiGi\.GML\.CityGML\.Classes\.CityModel') object\.

```csharp
public static DiGi.GML.CityGML.Classes.CityModel ToGML(System.IO.Stream steam);
```
#### Parameters

<a name='DiGi.GML.CityGML.Convert.ToGML(System.IO.Stream).steam'></a>

`steam` [System\.IO\.Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream 'System\.IO\.Stream')

The input stream containing the XML data\.

#### Returns
[CityModel](DiGi.GML.CityGML.Classes.md#DiGi.GML.CityGML.Classes.CityModel 'DiGi\.GML\.CityGML\.Classes\.CityModel')  
A [CityModel](DiGi.GML.CityGML.Classes.md#DiGi.GML.CityGML.Classes.CityModel 'DiGi\.GML\.CityGML\.Classes\.CityModel') instance if the conversion is successful; otherwise, null\.

<a name='DiGi.GML.CityGML.Convert.ToGML(System.Xml.XmlDocument)'></a>

## Convert\.ToGML\(XmlDocument\) Method

Converts an [System\.Xml\.XmlDocument](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmldocument 'System\.Xml\.XmlDocument') to a [CityModel](DiGi.GML.CityGML.Classes.md#DiGi.GML.CityGML.Classes.CityModel 'DiGi\.GML\.CityGML\.Classes\.CityModel') object\.

```csharp
public static DiGi.GML.CityGML.Classes.CityModel ToGML(System.Xml.XmlDocument xmlDocument);
```
#### Parameters

<a name='DiGi.GML.CityGML.Convert.ToGML(System.Xml.XmlDocument).xmlDocument'></a>

`xmlDocument` [System\.Xml\.XmlDocument](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmldocument 'System\.Xml\.XmlDocument')

The XML document containing the GML data\.

#### Returns
[CityModel](DiGi.GML.CityGML.Classes.md#DiGi.GML.CityGML.Classes.CityModel 'DiGi\.GML\.CityGML\.Classes\.CityModel')  
A [CityModel](DiGi.GML.CityGML.Classes.md#DiGi.GML.CityGML.Classes.CityModel 'DiGi\.GML\.CityGML\.Classes\.CityModel') instance if the conversion is successful; otherwise, null\.

<a name='DiGi.GML.CityGML.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.GML.CityGML.Create.CityModel(thisSystem.Xml.XmlNode)'></a>

## Create\.CityModel\(this XmlNode\) Method

Creates a [CityModel\(this XmlNode\)](DiGi.GML.CityGML.md#DiGi.GML.CityGML.Create.CityModel(thisSystem.Xml.XmlNode) 'DiGi\.GML\.CityGML\.Create\.CityModel\(this System\.Xml\.XmlNode\)') instance from the provided [System\.Xml\.XmlNode](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmlnode 'System\.Xml\.XmlNode')\.

```csharp
public static DiGi.GML.CityGML.Classes.CityModel CityModel(this System.Xml.XmlNode xmlNode);
```
#### Parameters

<a name='DiGi.GML.CityGML.Create.CityModel(thisSystem.Xml.XmlNode).xmlNode'></a>

`xmlNode` [System\.Xml\.XmlNode](https://learn.microsoft.com/en-us/dotnet/api/system.xml.xmlnode 'System\.Xml\.XmlNode')

The XML node to be processed into a city model\.

#### Returns
[CityModel](DiGi.GML.CityGML.Classes.md#DiGi.GML.CityGML.Classes.CityModel 'DiGi\.GML\.CityGML\.Classes\.CityModel')  
A [CityModel\(this XmlNode\)](DiGi.GML.CityGML.md#DiGi.GML.CityGML.Create.CityModel(thisSystem.Xml.XmlNode) 'DiGi\.GML\.CityGML\.Create\.CityModel\(this System\.Xml\.XmlNode\)') object if the node is valid and a corresponding type is found; otherwise, the default value\.