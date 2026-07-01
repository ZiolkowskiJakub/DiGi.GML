#### [DiGi\.GML](index.md 'index')

## DiGi\.GML\.Interfaces Namespace
### Interfaces

<a name='DiGi.GML.Interfaces.IAbstractGML'></a>

## IAbstractGML Interface

Defines the basic structure for an abstract Geography Markup Language \(GML\) element, extending the feature member functionality\.

```csharp
public interface IAbstractGML : DiGi.GML.Interfaces.IFeatureMember
```

Derived  
↳ [AbstractGML](DiGi.GML.Classes.md#DiGi.GML.Classes.AbstractGML 'DiGi\.GML\.Classes\.AbstractGML')

Implements [IFeatureMember](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IFeatureMember 'DiGi\.GML\.Interfaces\.IFeatureMember')
### Properties

<a name='DiGi.GML.Interfaces.IAbstractGML.id'></a>

## IAbstractGML\.id Property

Gets or sets the unique identifier of the GML element\.

```csharp
string? id { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GML.Interfaces.IFeatureMember'></a>

## IFeatureMember Interface

Defines the contract for an object that represents a member of a GML \(Geography Markup Language\) feature\.

```csharp
public interface IFeatureMember
```

Derived  
↳ [AbstractGML](DiGi.GML.Classes.md#DiGi.GML.Classes.AbstractGML 'DiGi\.GML\.Classes\.AbstractGML')  
↳ [IAbstractGML](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML 'DiGi\.GML\.Interfaces\.IAbstractGML')

<a name='DiGi.GML.Interfaces.ISRSInformation'></a>

## ISRSInformation Interface

Defines the structure for Spatial Reference System \(SRS\) information, 
providing labels for axes and units of measure\.

```csharp
public interface ISRSInformation
```

Derived  
↳ [Geometry](DiGi.GML.Classes.md#DiGi.GML.Classes.Geometry 'DiGi\.GML\.Classes\.Geometry')  
↳ [ISRSReference](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.ISRSReference 'DiGi\.GML\.Interfaces\.ISRSReference')
### Properties

<a name='DiGi.GML.Interfaces.ISRSInformation.axisLabels'></a>

## ISRSInformation\.axisLabels Property

Gets or sets the list of labels identifying the axes of the coordinate reference system\.

```csharp
System.Collections.Generic.List<string>? axisLabels { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.GML.Interfaces.ISRSInformation.uomLabels'></a>

## ISRSInformation\.uomLabels Property

Gets or sets the list of labels identifying the units of measure \(UOM\) for the coordinate reference system\.

```csharp
System.Collections.Generic.List<string>? uomLabels { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.GML.Interfaces.ISRSReference'></a>

## ISRSReference Interface

Defines the properties for a spatial reference system reference\.

```csharp
public interface ISRSReference : DiGi.GML.Interfaces.ISRSInformation
```

Derived  
↳ [Geometry](DiGi.GML.Classes.md#DiGi.GML.Classes.Geometry 'DiGi\.GML\.Classes\.Geometry')

Implements [ISRSInformation](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.ISRSInformation 'DiGi\.GML\.Interfaces\.ISRSInformation')
### Properties

<a name='DiGi.GML.Interfaces.ISRSReference.srsDimension'></a>

## ISRSReference\.srsDimension Property

Gets or sets the dimension of the spatial reference system\.

```csharp
System.Nullable<ushort> srsDimension { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt16](https://learn.microsoft.com/en-us/dotnet/api/system.uint16 'System\.UInt16')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.GML.Interfaces.ISRSReference.srsName'></a>

## ISRSReference\.srsName Property

Gets or sets the name of the spatial reference system\.

```csharp
string? srsName { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')