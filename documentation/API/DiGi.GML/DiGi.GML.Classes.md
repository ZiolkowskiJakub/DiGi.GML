#### [DiGi\.GML](index.md 'index')

## DiGi\.GML\.Classes Namespace
### Classes

<a name='DiGi.GML.Classes.AbstractFeature'></a>

## AbstractFeature Class

Represents an abstract base class for GML features, providing a foundation for all feature types within the GML schema\.

```csharp
public abstract class AbstractFeature : DiGi.GML.Classes.AbstractGML
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [AbstractGML](DiGi.GML.Classes.md#DiGi.GML.Classes.AbstractGML 'DiGi\.GML\.Classes\.AbstractGML') → AbstractFeature

Derived  
↳ [FeatureCollection](DiGi.GML.Classes.md#DiGi.GML.Classes.FeatureCollection 'DiGi\.GML\.Classes\.FeatureCollection')

<a name='DiGi.GML.Classes.AbstractGML'></a>

## AbstractGML Class

Represents the base abstract class for Geography Markup Language \(GML\) objects, providing common properties\.

```csharp
public abstract class AbstractGML : DiGi.GML.Interfaces.IAbstractGML, DiGi.GML.Interfaces.IFeatureMember
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → AbstractGML

Derived  
↳ [AbstractFeature](DiGi.GML.Classes.md#DiGi.GML.Classes.AbstractFeature 'DiGi\.GML\.Classes\.AbstractFeature')  
↳ [GML](DiGi.GML.Classes.md#DiGi.GML.Classes.GML 'DiGi\.GML\.Classes\.GML')

Implements [IAbstractGML](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML 'DiGi\.GML\.Interfaces\.IAbstractGML'), [IFeatureMember](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IFeatureMember 'DiGi\.GML\.Interfaces\.IFeatureMember')
### Properties

<a name='DiGi.GML.Classes.AbstractGML.id'></a>

## AbstractGML\.id Property

Gets or sets the unique identifier for the GML object\.

```csharp
public string? id { get; set; }
```

Implements [id](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML.id 'DiGi\.GML\.Interfaces\.IAbstractGML\.id')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GML.Classes.FeatureCollection'></a>

## FeatureCollection Class

Represents a collection of GML features, inheriting from the base abstract feature class\.

```csharp
public class FeatureCollection : DiGi.GML.Classes.AbstractFeature
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [AbstractGML](DiGi.GML.Classes.md#DiGi.GML.Classes.AbstractGML 'DiGi\.GML\.Classes\.AbstractGML') → [AbstractFeature](DiGi.GML.Classes.md#DiGi.GML.Classes.AbstractFeature 'DiGi\.GML\.Classes\.AbstractFeature') → FeatureCollection
### Properties

<a name='DiGi.GML.Classes.FeatureCollection.featureMember'></a>

## FeatureCollection\.featureMember Property

Gets or sets the list of feature members contained within this feature collection\.

```csharp
public System.Collections.Generic.List<DiGi.GML.Interfaces.IFeatureMember> featureMember { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[IFeatureMember](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IFeatureMember 'DiGi\.GML\.Interfaces\.IFeatureMember')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.GML.Classes.GeometricPrimitive'></a>

## GeometricPrimitive Class

Represents a base class for all geometric primitives within the GML \(Geography Markup Language\) coordinate system\.

```csharp
public abstract class GeometricPrimitive : DiGi.GML.Classes.Geometry
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [AbstractGML](DiGi.GML.Classes.md#DiGi.GML.Classes.AbstractGML 'DiGi\.GML\.Classes\.AbstractGML') → [GML](DiGi.GML.Classes.md#DiGi.GML.Classes.GML 'DiGi\.GML\.Classes\.GML') → [Geometry](DiGi.GML.Classes.md#DiGi.GML.Classes.Geometry 'DiGi\.GML\.Classes\.Geometry') → GeometricPrimitive

Derived  
↳ [Point](DiGi.GML.Classes.md#DiGi.GML.Classes.Point 'DiGi\.GML\.Classes\.Point')  
↳ [Surface](DiGi.GML.Classes.md#DiGi.GML.Classes.Surface 'DiGi\.GML\.Classes\.Surface')

<a name='DiGi.GML.Classes.Geometry'></a>

## Geometry Class

Represents a base abstract class for GML geometry objects, providing spatial reference system \(SRS\) information\.

```csharp
public abstract class Geometry : DiGi.GML.Classes.GML, DiGi.GML.Interfaces.ISRSReference, DiGi.GML.Interfaces.ISRSInformation
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [AbstractGML](DiGi.GML.Classes.md#DiGi.GML.Classes.AbstractGML 'DiGi\.GML\.Classes\.AbstractGML') → [GML](DiGi.GML.Classes.md#DiGi.GML.Classes.GML 'DiGi\.GML\.Classes\.GML') → Geometry

Derived  
↳ [GeometricPrimitive](DiGi.GML.Classes.md#DiGi.GML.Classes.GeometricPrimitive 'DiGi\.GML\.Classes\.GeometricPrimitive')  
↳ [Ring](DiGi.GML.Classes.md#DiGi.GML.Classes.Ring 'DiGi\.GML\.Classes\.Ring')

Implements [ISRSReference](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.ISRSReference 'DiGi\.GML\.Interfaces\.ISRSReference'), [ISRSInformation](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.ISRSInformation 'DiGi\.GML\.Interfaces\.ISRSInformation')
### Properties

<a name='DiGi.GML.Classes.Geometry.axisLabels'></a>

## Geometry\.axisLabels Property

Gets or sets a list of labels for the axes of the coordinate system\.

```csharp
public System.Collections.Generic.List<string>? axisLabels { get; set; }
```

Implements [axisLabels](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.ISRSInformation.axisLabels 'DiGi\.GML\.Interfaces\.ISRSInformation\.axisLabels')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.GML.Classes.Geometry.srsDimension'></a>

## Geometry\.srsDimension Property

Gets or sets the dimension of the Spatial Reference System\.

```csharp
public System.Nullable<ushort> srsDimension { get; set; }
```

Implements [srsDimension](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.ISRSReference.srsDimension 'DiGi\.GML\.Interfaces\.ISRSReference\.srsDimension')

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt16](https://learn.microsoft.com/en-us/dotnet/api/system.uint16 'System\.UInt16')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.GML.Classes.Geometry.srsName'></a>

## Geometry\.srsName Property

Gets or sets the name of the Spatial Reference System used by this geometry\.

```csharp
public string? srsName { get; set; }
```

Implements [srsName](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.ISRSReference.srsName 'DiGi\.GML\.Interfaces\.ISRSReference\.srsName')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GML.Classes.Geometry.uomLabels'></a>

## Geometry\.uomLabels Property

Gets or sets a list of units of measure labels for the axes\.

```csharp
public System.Collections.Generic.List<string>? uomLabels { get; set; }
```

Implements [uomLabels](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.ISRSInformation.uomLabels 'DiGi\.GML\.Interfaces\.ISRSInformation\.uomLabels')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.GML.Classes.GML'></a>

## GML Class

Represents the base GML \(Geography Markup Language\) implementation\.

```csharp
public abstract class GML : DiGi.GML.Classes.AbstractGML
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [AbstractGML](DiGi.GML.Classes.md#DiGi.GML.Classes.AbstractGML 'DiGi\.GML\.Classes\.AbstractGML') → GML

Derived  
↳ [Geometry](DiGi.GML.Classes.md#DiGi.GML.Classes.Geometry 'DiGi\.GML\.Classes\.Geometry')

<a name='DiGi.GML.Classes.LinearRing'></a>

## LinearRing Class

Represents a LinearRing, which is a closed boundary consisting of a linear sequence of points\.

```csharp
public class LinearRing : DiGi.GML.Classes.Ring
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [AbstractGML](DiGi.GML.Classes.md#DiGi.GML.Classes.AbstractGML 'DiGi\.GML\.Classes\.AbstractGML') → [GML](DiGi.GML.Classes.md#DiGi.GML.Classes.GML 'DiGi\.GML\.Classes\.GML') → [Geometry](DiGi.GML.Classes.md#DiGi.GML.Classes.Geometry 'DiGi\.GML\.Classes\.Geometry') → [Ring](DiGi.GML.Classes.md#DiGi.GML.Classes.Ring 'DiGi\.GML\.Classes\.Ring') → LinearRing
### Properties

<a name='DiGi.GML.Classes.LinearRing.posList'></a>

## LinearRing\.posList Property

Gets or sets the list of coordinate positions that define the linear ring\.

```csharp
public System.Collections.Generic.List<double> posList { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.GML.Classes.Point'></a>

## Point Class

Represents a geometric point consisting of a sequence of coordinate values\.

```csharp
public class Point : DiGi.GML.Classes.GeometricPrimitive
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [AbstractGML](DiGi.GML.Classes.md#DiGi.GML.Classes.AbstractGML 'DiGi\.GML\.Classes\.AbstractGML') → [GML](DiGi.GML.Classes.md#DiGi.GML.Classes.GML 'DiGi\.GML\.Classes\.GML') → [Geometry](DiGi.GML.Classes.md#DiGi.GML.Classes.Geometry 'DiGi\.GML\.Classes\.Geometry') → [GeometricPrimitive](DiGi.GML.Classes.md#DiGi.GML.Classes.GeometricPrimitive 'DiGi\.GML\.Classes\.GeometricPrimitive') → Point
### Properties

<a name='DiGi.GML.Classes.Point.pos'></a>

## Point\.pos Property

Gets or sets the list of coordinates representing the position of the point\.

```csharp
public System.Collections.Generic.List<double> pos { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.GML.Classes.Polygon'></a>

## Polygon Class

Represents a GML Polygon, which is a surface defined by one exterior boundary and optional interior boundaries\.

```csharp
public class Polygon : DiGi.GML.Classes.Surface
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [AbstractGML](DiGi.GML.Classes.md#DiGi.GML.Classes.AbstractGML 'DiGi\.GML\.Classes\.AbstractGML') → [GML](DiGi.GML.Classes.md#DiGi.GML.Classes.GML 'DiGi\.GML\.Classes\.GML') → [Geometry](DiGi.GML.Classes.md#DiGi.GML.Classes.Geometry 'DiGi\.GML\.Classes\.Geometry') → [GeometricPrimitive](DiGi.GML.Classes.md#DiGi.GML.Classes.GeometricPrimitive 'DiGi\.GML\.Classes\.GeometricPrimitive') → [Surface](DiGi.GML.Classes.md#DiGi.GML.Classes.Surface 'DiGi\.GML\.Classes\.Surface') → Polygon
### Properties

<a name='DiGi.GML.Classes.Polygon.exterior'></a>

## Polygon\.exterior Property

Gets or sets the exterior boundary of the polygon\.

```csharp
public DiGi.GML.Classes.LinearRing? exterior { get; set; }
```

#### Property Value
[LinearRing](DiGi.GML.Classes.md#DiGi.GML.Classes.LinearRing 'DiGi\.GML\.Classes\.LinearRing')

<a name='DiGi.GML.Classes.Polygon.interior'></a>

## Polygon\.interior Property

Gets or sets the list of interior boundaries \(holes\) of the polygon\.

```csharp
public System.Collections.Generic.List<DiGi.GML.Classes.LinearRing>? interior { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[LinearRing](DiGi.GML.Classes.md#DiGi.GML.Classes.LinearRing 'DiGi\.GML\.Classes\.LinearRing')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.GML.Classes.Ring'></a>

## Ring Class

Represents a ring geometry element, serving as a base for specific ring implementations within the GML specification\.

```csharp
public abstract class Ring : DiGi.GML.Classes.Geometry
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [AbstractGML](DiGi.GML.Classes.md#DiGi.GML.Classes.AbstractGML 'DiGi\.GML\.Classes\.AbstractGML') → [GML](DiGi.GML.Classes.md#DiGi.GML.Classes.GML 'DiGi\.GML\.Classes\.GML') → [Geometry](DiGi.GML.Classes.md#DiGi.GML.Classes.Geometry 'DiGi\.GML\.Classes\.Geometry') → Ring

Derived  
↳ [LinearRing](DiGi.GML.Classes.md#DiGi.GML.Classes.LinearRing 'DiGi\.GML\.Classes\.LinearRing')

<a name='DiGi.GML.Classes.Surface'></a>

## Surface Class

Represents an abstract base class for surface geometric primitives within the GML specification\.

```csharp
public abstract class Surface : DiGi.GML.Classes.GeometricPrimitive
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [AbstractGML](DiGi.GML.Classes.md#DiGi.GML.Classes.AbstractGML 'DiGi\.GML\.Classes\.AbstractGML') → [GML](DiGi.GML.Classes.md#DiGi.GML.Classes.GML 'DiGi\.GML\.Classes\.GML') → [Geometry](DiGi.GML.Classes.md#DiGi.GML.Classes.Geometry 'DiGi\.GML\.Classes\.Geometry') → [GeometricPrimitive](DiGi.GML.Classes.md#DiGi.GML.Classes.GeometricPrimitive 'DiGi\.GML\.Classes\.GeometricPrimitive') → Surface

Derived  
↳ [Polygon](DiGi.GML.Classes.md#DiGi.GML.Classes.Polygon 'DiGi\.GML\.Classes\.Polygon')

<a name='DiGi.GML.Classes.TypeManager'></a>

## TypeManager Class

Provides functionality to manage and retrieve types that implement the [IAbstractGML](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML 'DiGi\.GML\.Interfaces\.IAbstractGML') interface\.

```csharp
public class TypeManager
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → TypeManager
### Constructors

<a name='DiGi.GML.Classes.TypeManager.TypeManager()'></a>

## TypeManager\(\) Constructor

Initializes a new instance of the [TypeManager](DiGi.GML.Classes.md#DiGi.GML.Classes.TypeManager 'DiGi\.GML\.Classes\.TypeManager') class\.

```csharp
public TypeManager();
```
### Methods

<a name='DiGi.GML.Classes.TypeManager.GetType(string,bool)'></a>

## TypeManager\.GetType\(string, bool\) Method

Retrieves a type based on the provided name from all loaded assemblies, ensuring it implements [IAbstractGML](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML 'DiGi\.GML\.Interfaces\.IAbstractGML')\.

```csharp
public System.Type? GetType(string? name, bool update=true);
```
#### Parameters

<a name='DiGi.GML.Classes.TypeManager.GetType(string,bool).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the type to search for\.

<a name='DiGi.GML.Classes.TypeManager.GetType(string,bool).update'></a>

`update` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, the result \(including null\) will be cached in the internal dictionary to optimize future lookups\.

#### Returns
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')  
The [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type') if found and it implements [IAbstractGML](DiGi.GML.Interfaces.md#DiGi.GML.Interfaces.IAbstractGML 'DiGi\.GML\.Interfaces\.IAbstractGML'); otherwise, `null`\.