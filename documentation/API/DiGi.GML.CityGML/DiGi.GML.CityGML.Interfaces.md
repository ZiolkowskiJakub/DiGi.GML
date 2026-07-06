#### [DiGi\.GML\.CityGML](index.md 'index')

## DiGi\.GML\.CityGML\.Interfaces Namespace
### Interfaces

<a name='DiGi.GML.CityGML.Interfaces.ICityGML'></a>

## ICityGML Interface

Defines the base interface for CityGML related objects and structures\.

```csharp
public interface ICityGML
```

Derived  
↳ [Building](DiGi.GML.CityGML.Classes.md#DiGi.GML.CityGML.Classes.Building 'DiGi\.GML\.CityGML\.Classes\.Building')  
↳ [CityModel](DiGi.GML.CityGML.Classes.md#DiGi.GML.CityGML.Classes.CityModel 'DiGi\.GML\.CityGML\.Classes\.CityModel')  
↳ [IcityObjectMember](DiGi.GML.CityGML.Interfaces.md#DiGi.GML.CityGML.Interfaces.IcityObjectMember 'DiGi\.GML\.CityGML\.Interfaces\.IcityObjectMember')

<a name='DiGi.GML.CityGML.Interfaces.IcityObjectMember'></a>

## IcityObjectMember Interface

Defines the interface for a city object member, inheriting from basic GML and CityGML abstractions\.

```csharp
public interface IcityObjectMember : DiGi.GML.Interfaces.IAbstractGML, DiGi.GML.Interfaces.IFeatureMember, DiGi.GML.CityGML.Interfaces.ICityGML
```

Derived  
↳ [Building](DiGi.GML.CityGML.Classes.md#DiGi.GML.CityGML.Classes.Building 'DiGi\.GML\.CityGML\.Classes\.Building')

Implements [DiGi\.GML\.Interfaces\.IAbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.iabstractgml 'DiGi\.GML\.Interfaces\.IAbstractGML'), [DiGi\.GML\.Interfaces\.IFeatureMember](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.ifeaturemember 'DiGi\.GML\.Interfaces\.IFeatureMember'), [ICityGML](DiGi.GML.CityGML.Interfaces.md#DiGi.GML.CityGML.Interfaces.ICityGML 'DiGi\.GML\.CityGML\.Interfaces\.ICityGML')