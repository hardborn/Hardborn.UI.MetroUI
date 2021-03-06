﻿using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Markup;

// 有关程序集的常规信息通过以下
// 特性集控制。更改这些特性值可修改
// 与程序集关联的信息。
[assembly: AssemblyTitle("MetroUI")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyProduct("MetroUI")]
[assembly: AssemblyCopyright("Copyright © Microsoft 2015")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// 将 ComVisible 设置为 false 使此程序集中的类型
// 对 COM 组件不可见。  如果需要从 COM 访问此程序集中的类型，
// 则将该类型上的 ComVisible 特性设置为 true。
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]

// 如果此项目向 COM 公开，则下列 GUID 用于类型库的 ID
[assembly: Guid("358a196c-43ac-492e-978f-a38fd91a461c")] 

// 程序集的版本信息由下面四个值组成: 
//
//      主版本
//      次版本
//      生成号
//      修订号
//
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.15191.8")]

[assembly: XmlnsDefinition("http://hardborn.com/UI/MetroUI", "Hardborn.UI.MetroUI.Presentation")]
[assembly: XmlnsDefinition("http://hardborn.com/UI/MetroUI", "Hardborn.UI.MetroUI.Windows")]
[assembly: XmlnsDefinition("http://hardborn.com/UI/MetroUI", "Hardborn.UI.MetroUI.Windows.Controls")]
[assembly: XmlnsDefinition("http://hardborn.com/UI/MetroUI", "Hardborn.UI.MetroUI.Windows.Converters")]
[assembly: XmlnsDefinition("http://hardborn.com/UI/MetroUI", "Hardborn.UI.MetroUI.Windows.Navigation")]
[assembly: XmlnsPrefix("http://hardborn.com/UI/MetroUI", "mui")]

[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
    //(used if a resource is not found in the page, 
    // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
    //(used if a resource is not found in the page, 
    // app, or any theme specific resource dictionaries)
)]
