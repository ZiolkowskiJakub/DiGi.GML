#### [DiGi\.GML\.CityGML](index.md 'index')

## DiGi\.GML\.CityGML\.Classes Namespace
### Classes

<a name='DiGi.GML.CityGML.Classes.Building'></a>

## Building Class

Represents a building object within the CityGML model, implementing city object member and abstract GML interfaces\.

```csharp
public class Building : DiGi.GML.CityGML.Interfaces.IcityObjectMember, DiGi.GML.Interfaces.IAbstractGML, DiGi.GML.Interfaces.IFeatureMember, DiGi.GML.CityGML.Interfaces.ICityGML
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Building

Implements [IcityObjectMember](DiGi.GML.CityGML.Interfaces.md#DiGi.GML.CityGML.Interfaces.IcityObjectMember 'DiGi\.GML\.CityGML\.Interfaces\.IcityObjectMember'), [DiGi\.GML\.Interfaces\.IAbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.iabstractgml 'DiGi\.GML\.Interfaces\.IAbstractGML'), [DiGi\.GML\.Interfaces\.IFeatureMember](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.ifeaturemember 'DiGi\.GML\.Interfaces\.IFeatureMember'), [ICityGML](DiGi.GML.CityGML.Interfaces.md#DiGi.GML.CityGML.Interfaces.ICityGML 'DiGi\.GML\.CityGML\.Interfaces\.ICityGML')
### Properties

<a name='DiGi.GML.CityGML.Classes.Building.id'></a>

## Building\.id Property

Gets or sets the unique identifier for the building\.

```csharp
public string id { get; set; }
```

Implements [id](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.iabstractgml.id 'DiGi\.GML\.Interfaces\.IAbstractGML\.id')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GML.CityGML.Classes.Building.roofType'></a>

## Building\.roofType Property

Gets or sets the numeric representation of the roof type for the building\.

```csharp
public int roofType { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.GML.CityGML.Classes.CityModel'></a>

## CityModel Class

Represents a CityGML city model containing a collection of city object members\.

```csharp
public class CityModel : DiGi.GML.CityGML.Interfaces.ICityGML
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → CityModel

Implements [ICityGML](DiGi.GML.CityGML.Interfaces.md#DiGi.GML.CityGML.Interfaces.ICityGML 'DiGi\.GML\.CityGML\.Interfaces\.ICityGML')
### Properties

<a name='DiGi.GML.CityGML.Classes.CityModel.cityObjectMembers'></a>

## CityModel\.cityObjectMembers Property

Gets or sets the list of city object members associated with this city model\.

```csharp
public System.Collections.Generic.List<DiGi.GML.CityGML.Interfaces.IcityObjectMember> cityObjectMembers { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[IcityObjectMember](DiGi.GML.CityGML.Interfaces.md#DiGi.GML.CityGML.Interfaces.IcityObjectMember 'DiGi\.GML\.CityGML\.Interfaces\.IcityObjectMember')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')