# FSharpWinForms
FSharp Windows Forms - Basic Example
Using Visual Studio 2022

### Step 1:
Create new F# Console application

### Step 2:
Click the project name in your solution explorer.

Edit your settings:
- `<Project Sdk="Microsoft.NET.Sdk.WindowsDesktop">`
- `<OutputType>WinExe</OutputType>`
- `<UseWindowsForms>true</UseWindowsForms>`
	- These 3 options should have added a reference/framework to your project
		- Micosoft.WindowsDesktop.App.WindowsForms 
- `<PackageReference Include="Microsoft.Windows.Compatibility" Version="3.0.0" />`
```
<Project Sdk="Microsoft.NET.Sdk.WindowsDesktop">

  <PropertyGroup>
    <TargetFramework>net6.0-windows</TargetFramework>
	<OutputType>WinExe</OutputType>
	<UseWindowsForms>true</UseWindowsForms>
	<RootNamespace>fgui</RootNamespace>
	<AssemblyName>FSharpGui</AssemblyName>
	<GenerateAssemblyInfo>false</GenerateAssemblyInfo>
  </PropertyGroup>

  <ItemGroup>
	<PackageReference Include="Microsoft.Windows.Compatibility" Version="3.0.0" />
	<Compile Include="FormDesign.fs" />
    <Compile Include="Program.fs" />
  </ItemGroup>

</Project>
```

### Step 3:
Open Project properties [Application] -> [General] -> and set your Target OS to Windows.

#### If done correctly Application Settings should look like this:
- Output type: Windows Application
- Target framewrok: .NET 6.0 (for this example)
- Target OS: Windows
- Target OS Version: 7.0 (for this example)
- Supported OS Version: 7.0 (for this example)
- Windows Forms: Checked Enable
