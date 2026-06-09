# ⚡ csRevit : Enterprise BIM Automation
[![Revit Supported](https://img.shields.io/badge/Revit-2019--2026-blue.svg)](https://appstore.svecs.in) [![License](https://img.shields.io/badge/License-Commercial-brightgreen.svg)](https://appstore.svecs.in/checkout/buy/38ffaf7c-d06c-4665-b309-8a50b18fae45) [![Status](https://img.shields.io/badge/Status-Free_Trial-orange.svg)](https://appstore.svecs.in/checkout/buy/bade39f5-94a2-45ca-94a0-5745a00d08bb)

> **The ultimate decoupled architecture for Autodesk Revit.** Build, deploy, and manage enterprise BIM tools across your firm instantly—without ever forcing users to restart Revit.

![csRevit Hero Banner](docs/assets/hero-banner.png)(https://appstore.svecs.in)

## 📖 Stop Wasting Time on Deployment. Focus on Automation.

The **csRevit Framework** is a dynamic Sync Engine and Microkernel for Autodesk Revit. It solves the biggest bottleneck in enterprise BIM development: deployment and UI management. 

Instead of writing rigid C# UI code and manually deploying `.addin` files to hundreds of machines, csRevit completely decouples the User Interface from the compiled code. Developers simply organize Windows folders, and the framework automatically generates the Ribbon on the fly. 

When you publish a new tool to your network, users simply click **"Sync Tools"** and the new feature appears instantly in their active Revit session.

---

## ✨ Why Enterprise BIM Teams Choose csRevit
* 🚀 **Zero-Restart Deployments:** Update tools, rebuild the UI, and deploy to the entire firm mid-session. No more asking 100 architects to close Revit just so you can update a DLL.
* 📂 **Folder-Based UI Generation:** Create tabs, panels, dropdowns, true split-buttons, and stacked columns just by naming Windows         folders. Zero C# UI coding required.
* 🧬 **Multi-Version Concurrency:** Run Revit 2024 (.NET 4.8) and Revit 2025 (.NET 8.0) simultaneously without file lock crashes.
* 🛡️ **The Hybrid SDK:** Seamlessly link standard pushbuttons to persistent background services and native Dockable Panes.
* 🧩 **Multi-Tool Isolation (`class.txt`):** Compile dozens of commands into a single DLL, and let our engine automatically isolate and deploy them to specific buttons across your ribbon.
* 🔍 **Spotlight Search:** A built-in command palette. Users can type to search, run, favorite, or assign custom keyboard shortcuts to any tool.
* 📊 **Admin Analytics:** Secure, centralized telemetry tracking tool usage, success rates, and ROI across your entire firm.


💼 Licensing & How to Buy
The csRevit Framework is a commercial, enterprise-grade product designed to save BIM teams hundreds of hours in deployment and UI management.

This repository serves as our public documentation and issue tracker. The compiled framework .bundle, Sync Engine, and proprietary source code are securely distributed to licensed clients.

Ready to transform your firm's Revit environment?

🚀 [Start your 15-Day Free Trial Here](https://appstore.svecs.in/checkout/buy/bade39f5-94a2-45ca-94a0-5745a00d08bb)

🛒 [Purchase a Commercial License Here](https://appstore.svecs.in/checkout/buy/38ffaf7c-d06c-4665-b309-8a50b18fae45)

📚 Documentation & Support

Whether you are a BIM Manager deploying the framework, or a C# Developer building tools on top of it, everything you need is in our official documentation:

🚀 Getting Started & Installation Guide

Welcome to the csRevit Framework! This guide will walk you through installing the framework, activating your license, configuring your network paths, and syncing your tools for the very first time.

Because csRevit uses a dynamically generated UI, you only need to install the core framework once. After that, all tool updates, new panels, and background services are delivered instantly over the network.

1. Prerequisites
Before installing, ensure your system meets the following requirements:

Autodesk Revit: Revit 2019 through Revit 2025 installed.

Operating System: Windows 10 or Windows 11.

Network Access: Read-access to your firm's Master Network Drive (e.g., Z:\BIM\csRevit_Master).

License: A valid csRevit Trial or Commercial License Key. (Don't have one? Get it from the (https://appstore.svecs.in).

2. Installing the Bootstrapper
The csRevit Bootstrapper is a lightweight engine that loads when Revit starts. It acts as the bridge between Revit and your dynamic tool folders.

Step-by-Step Installation:

Download the latest csRevit_Installer.exe from your firm's IT portal or the csRevit App Store (https://appstore.svecs.in).

Run the installer.

The installer will automatically place the csRevit.bundle into your local Autodesk Add-ins folder:

C:\Users\%USERNAME%\AppData\Roaming\Autodesk\ApplicationPlugins\csRevit.bundle

The installation is complete. Open Autodesk Revit.

3. First Launch & Activation
When you open Revit for the first time after installation, the framework will attempt to verify your license securely.

A License Activation window will appear on your screen.

Paste your 15-Day Free Trial or Commercial License Key into the text box.

Click Activate License.

The framework will verify the key. Once successful, it will automatically perform an initial Cloud Sync to download the core UI dependencies.

4. Configuring the Master Network Drive
To receive your firm's custom tools, you must tell the framework where to find them.

Look at your Revit Ribbon. You will see a new tab called csRevit Core.

Click the Global Settings button (the gear icon).

The Configuration Registry window will open. Look for the Master Network Path field.

Click Browse... and navigate to your firm's centralized csRevit Master folder (e.g., Z:\BIM\csRevit_Master).

Optional: If you only want to see tools specific to your role, type your discipline (e.g., Architecture or MEP) into the Discipline Filter box. Otherwise, leave it as All.

Click Save Configuration.

5. Syncing Your Tools (The Magic Step)
Now that your network path is configured, it is time to build your customized Revit Ribbon!

Go to the csRevit Core tab.

Click the large Sync Tools button.

The framework will quickly download the latest scripts and folder structures from your firm's Master Drive.

Instantly, your Revit Ribbon will rebuild itself, generating all of your firm's custom Tabs, Panels, Dropdowns, and Buttons.

🎉 You are now ready to work!

Note: You never need to restart Revit to get new tools. Whenever your BIM Manager announces a new tool, just click Sync Tools again to receive it instantly.

6. Developer Setup: The Local Sandbox

If you are a C# Developer or BIM Manager tasked with building new tools for the framework, you need to set up your local DEV Sandbox.

When you write new C# commands, you do not test them on the live Master Network Drive. Instead, you deploy them locally to test them safely.

Open your Windows File Explorer.

Navigate to your local csRevit Application Data folder:

C:\Users\%USERNAME%\AppData\Roaming\csRevit\DEV

This is your personal sandbox. Any folders (like .tab, .panel, or .pushbutton) you create in here will appear in Revit under a special 🛠️ DEV LAB tab.

Configure your Visual Studio .csproj to deploy your compiled .dll files directly into this DEV folder. (See the Developer Guide for the automated .csproj boilerplate).

Whenever you successfully build your code in Visual Studio, simply click Reload UI on the csRevit Core tab to test your new tool instantly!

Publishing from DEV to Master
Once you have tested a tool in your local DEV folder and confirmed it works perfectly:

Click the Publish Tool button on the csRevit Core tab.

Select your tool from the dropdown list.

Browse to the specific panel in the Master Network Drive where you want it to live.

Click Publish Live. The framework will automatically move the tool to the network and trigger a global sync for your machine.


🏗️ The Master Folder Tree (UI Configuration)


Anatomy of a Tool Folder

Once you create a tool folder (e.g., My Tool.pushbutton), it must contain specific assets to render and execute correctly in Revit.

R24L (Folder): Contains the .NET 4.8 compiled .dll for Revit 2024 and older.

R25H (Folder): Contains the .NET 8.0 compiled .dll for Revit 2025 and newer.

icon.png: The 32x32 image for the button. (Note: If this folder is placed inside a .stack container, the framework will automatically shrink this image to 16x16 for you!)

help.txt (Optional): A text file. The contents will automatically become the F1 extended tooltip in Revit.

demo.mp4 (Optional): A short video file that will automatically play when the user hovers over the button.

config.json (Required ONLY for Comboboxes): Contains the dropdown list array.

class.txt (Optional): Used for Multi-Tool DLLs. If your DLL contains multiple commands, this text file tells the framework exactly which C# Class Name to bind to this specific folder. (Note: This can be generated automatically by the Developer .csproj file!)

![csRevit Folder Structure](docs/assets/Folder_Structure.png)


👨‍💻 Developer Guide & C# Boilerplates


To write a tool that integrates perfectly into the csRevit Framework, you must follow the 6 Golden Rules:

Implement Autodesk.Revit.UI.IExternalCommand (for UI tools) or IExternalApplication (for Background Services/Dockable Panes).

Add the [Transaction(TransactionMode.Manual)] attribute (for Commands).

Use UI Attributes ([DisplayName] and [Description]) to control how the button appears in search/tooltips, overriding the class name.

Multi-target the project for both .NET 4.8 (R24L) and .NET 8.0 (R25H).

Reference the csRevit API: You must reference csRevit.API.dll. The csRevit Bootstrapper automatically loads this library into Revit's memory on startup.

Set "Copy Local = False": For all Revit API references AND your csRevit.API.dll reference, you MUST set Copy Local to False (or <Private>False</Private> in the XML). This prevents fatal reference collisions.

6.1 Advanced UI: Modal, Modeless, and Dockable Panes
When building a custom WPF or WinForms interface, you must decide how it interacts with Revit. The csRevit Framework natively supports all three paradigms:

Modal Dialogs (The Standard Way): A Modal window locks the Revit interface. The user cannot pan or select elements until they close the dialog. Because Revit is paused, your code retains full control of the API.

How to deploy: Build a standard IExternalCommand, place it in a .pushbutton folder, and launch your WPF window using myWindow.ShowDialog();.

Modeless Dialogs (Floating Palettes): A Modeless window floats on top of the screen but leaves Revit completely active. Because the user can interact with Revit, your window loses the "API Context". You must use Revit's IExternalEventHandler and ExternalEvent framework to modify the model safely.

How to deploy: Build a standard IExternalCommand, place it in a .pushbutton folder, and launch your WPF window using myWindow.Show();.

Dockable Panes (Native Integration): An advanced Modeless window that snaps directly into the side of the Revit interface (like the Properties Palette).

How to deploy: Because Dockable Panes must be registered when Revit first boots up, your standard .pushbutton folders cannot do this. You must build an IExternalApplication and deploy it to the DEV\Services folder! The csRevit Bootstrapper will automatically register it on startup.

1. Pushbutton Boilerplates (.pushbutton)

A. Basic Script (No Custom UI)

docs/assets/Pushbutton Boilerplates (.pushbutton).cs

```csharp
using System;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;

namespace csRevit_Tools
{
    [Transaction(TransactionMode.Manual)]
    [DisplayName("Quick Format")]
    [Description("Formats the active view.")]
    public class QuickFormatCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;

            try
            {
                // YOUR LOGIC HERE
                return Result.Succeeded;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Result.Failed; // Automatically launches the csRevit Debug Console
            }
        }
    }
}


B. Modal Dialog Boilerplate


C#
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;

namespace csRevit_Tools
{
    [Transaction(TransactionMode.Manual)]
    public class LaunchModalCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // 1. Create your WPF Window
            MyWpfWindow window = new MyWpfWindow(commandData.Application.ActiveUIDocument.Document);

            // 2. Set Revit as the parent window so it centers properly
            var helper = new System.Windows.Interop.WindowInteropHelper(window);
            helper.Owner = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;

            // 3. Launch it Modally (Locks Revit until closed)
            window.ShowDialog();

            return Result.Succeeded;
        }
    }
}


C. Modeless Dialog Boilerplate (Floating Palette)

To launch a Modeless window, you must pass an IExternalEventHandler into the window so it can "ping" Revit when it needs to make database changes.

C#
using System;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;

namespace csRevit_Tools
{
    // 1. CREATE THE HANDLER (This executes code safely on Revit's main thread)
    public class MyModelessHandler : IExternalEventHandler
    {
        public void Execute(UIApplication app)
        {
            Document doc = app.ActiveUIDocument.Document;
            using (Transaction t = new Transaction(doc, "Modeless Modification"))
            {
                t.Start();
                // YOUR REVIT DB MODIFICATIONS GO HERE
                t.Commit();
            }
        }
        public string GetName() => "csRevit Modeless Handler";
    }

    // 2. CREATE THE BUTTON COMMAND
    [Transaction(TransactionMode.Manual)]
    public class LaunchModelessCommand : IExternalCommand
    {
        // Keep window static so only one instance opens at a time
        private static MyWpfWindow _modelessWindow = null; 

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            if (_modelessWindow != null && _modelessWindow.IsLoaded)
            {
                _modelessWindow.Focus(); // Bring to front if already open
                return Result.Succeeded;
            }

            // Create Event and Handler
            MyModelessHandler handler = new MyModelessHandler();
            ExternalEvent exEvent = ExternalEvent.Create(handler);

            // Pass the Event into your WPF Window
            _modelessWindow = new MyWpfWindow(exEvent);

            var helper = new System.Windows.Interop.WindowInteropHelper(_modelessWindow);
            helper.Owner = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;

            // Launch Modelessly (Revit remains active)
            _modelessWindow.Show();

            return Result.Succeeded;
        }
    }
}


2. Data-Driven Button Boilerplates

A. Toggle / Switch Button Boilerplate (.toggle)
Toggle buttons automatically swap between an "On" and "Off" icon. The csRevit framework handles saving this state to the registry before it runs your command. Your script just needs to read the new state and act on it.



C#
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using csRevit.API; // Required for SettingsManager

namespace csRevit_Tools
{
    [Transaction(TransactionMode.Manual)]
    [DisplayName("Auto Dimension")]
    public class AutoDimToggleCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // Read the state that the user just toggled to
            string currentState = SettingsManager.ReadSetting("ToggleStates", "Auto Dimension", "Off");

            if (currentState == "On")
            {
                TaskDialog.Show("Toggle", "Auto Dimensioning is now ENABLED.");
            }
            else
            {
                TaskDialog.Show("Toggle", "Auto Dimensioning is now DISABLED.");
            }

            return Result.Succeeded;
        }
    }
}



B. Combo Box Boilerplate (.combobox)

When a user selects an item from your dropdown (defined in config.json), the framework saves their selection to the Registry and immediately triggers your command.



C#
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using csRevit.API; // Required for SettingsManager

namespace csRevit_Tools
{
    [Transaction(TransactionMode.Manual)]
    [DisplayName("Select Discipline")]
    public class DisciplineComboBoxCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // Read the value the user just selected from the Dropdown
            string selectedValue = SettingsManager.ReadSetting("Select Discipline", "ComboBoxValue", "");

            TaskDialog.Show("Combo Box", $"You selected: {selectedValue}");

            // Apply logic based on the selection...

            return Result.Succeeded;
        }
    }
}



3. Background Event Tracker Boilerplate.


To run tasks silently in the background (like auditing a file on Open, or syncing data on Save), you must hook into Revit's native application events using an IExternalApplication deployed to the Services folder.




C#
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Events;
using Autodesk.Revit.UI;

namespace csRevit_Tools
{
    public class AutoAuditService : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication app)
        {
            // Safely subscribe to Revit's native background events
            app.ControlledApplication.DocumentOpened += OnDocumentOpened;
            app.ControlledApplication.DocumentSaved += OnDocumentSaved;
            
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication app)
        {
            app.ControlledApplication.DocumentOpened -= OnDocumentOpened;
            app.ControlledApplication.DocumentSaved -= OnDocumentSaved;
            
            return Result.Succeeded;
        }

        private void OnDocumentOpened(object sender, DocumentOpenedEventArgs e)
        {
            Document doc = e.Document;
            if (doc.IsFamilyDocument) return;

            // YOUR SILENT BACKGROUND LOGIC HERE
            // Note: Background events cannot use standard UI TaskDialogs.
        }

        private void OnDocumentSaved(object sender, DocumentSavedEventArgs e)
        {
            Document doc = e.Document;
            // Execute save trackers or exports here...
        }
    }
}



4. The "Hybrid Connection" SDK (Service + Button)

The absolute best practice for complex enterprise tools (like Dockable Panes or dynamic UI Updaters) is the Hybrid Approach.
Build your background logic inside an IExternalApplication (placed in the Services folder). It must implement IcsRevitBackgroundService from csRevit.API.
Expose a public static instance of your Service.
Build your UI button inside a standard .pushbutton folder (using IExternalCommand).
The csRevit Linker: When a user clicks the button, it safely checks the running service's State, passes the ExternalCommandData to the background, and triggers execution!


Step 1: The Enterprise Background Service (In the Services Folder)



C#
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using csRevit.API;

namespace csRevit_MyHybridTool
{
    public class MyEnterpriseService : IExternalApplication, IcsRevitBackgroundService
    {
        // 1. Expose a static instance so the UI Button can find this service!
        public static MyEnterpriseService Instance { get; private set; }

        // 2. Implement the IcsRevitBackgroundService Contract
        public string ServiceName => "Enterprise Door Updater";
        public string Version => "1.0.0";
        public ServiceState CurrentState { get; private set; } = ServiceState.Offline;

        public Result OnStartup(UIControlledApplication app)
        {
            Instance = this;
            CurrentState = ServiceState.Idle; // Mark as ready
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication app)
        {
            CurrentState = ServiceState.Offline;
            return Result.Succeeded;
        }

        // 3. The Execution Payload triggered by the UI Button
        public Result ExecuteTriggerFromUI(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            CurrentState = ServiceState.Processing; // Lock the service so it isn't triggered twice
            
            try
            {
                Document doc = commandData.Application.ActiveUIDocument.Document;
                TaskDialog.Show(ServiceName, "The UI Button successfully triggered the Background Service!");
                
                return Result.Succeeded;
            }
            catch (System.Exception ex)
            {
                message = ex.Message;
                return Result.Failed;
            }
            finally
            {
                CurrentState = ServiceState.Idle; // Unlock the service
            }
        }
    }
}



Step 2: The Clickable Button (In the .pushbutton Folder)



C#
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using csRevit.API;

namespace csRevit_MyHybridTool
{
    [Transaction(TransactionMode.Manual)]
    public class TriggerServiceCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // The Button connects to the Interface via the exposed Instance
            IcsRevitBackgroundService myService = MyEnterpriseService.Instance;

            // 1. Ensure it exists and is running
            if (myService == null || myService.CurrentState == ServiceState.Offline)
            {
                message = "The background service is offline. Please restart Revit.";
                return Result.Failed;
            }

            // 2. Prevent Double-Clicking / Thread Crashes
            if (myService.CurrentState == ServiceState.Processing)
            {
                TaskDialog.Show(myService.ServiceName, "Please wait, the service is currently busy processing another task.");
                return Result.Cancelled;
            }

            // 3. Pass the Revit context directly to the Background Service!
            return myService.ExecuteTriggerFromUI(commandData, ref message, elements);
        }
    }
}



5. The Ultimate Automated Tool Project File (.csproj)


Use this template for every new tool project. This MSBuild configuration is designed to be the ultimate developer asset. It does three amazing things automatically when you press Build in Visual Studio:

Multi-targets both .NET 4.8 and .NET 8.0.

Evaluates the destination folders and auto-generates your class.txt files on the fly, saving you from manual folder configuration for multi-tool DLLs.

Automatically deploys to both the DEV\Services folder (for background logic) AND your DEV\...\.pushbutton folders (for UI interaction).



XML
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFrameworks>net48;net8.0-windows</TargetFrameworks>
    <Platforms>x64</Platforms>
    <UseWPF>true</UseWPF>
    <GenerateAssemblyInfo>false</GenerateAssemblyInfo>
    <AppendTargetFrameworkToOutputPath>true</AppendTargetFrameworkToOutputPath>
  </PropertyGroup>

  <!-- REFERENCES FOR REVIT 2024 AND OLDER (R24L) -->
  <ItemGroup Condition="'$(TargetFramework)' == 'net48'">
    <Reference Include="PresentationCore" />
    <Reference Include="PresentationFramework" />
    <Reference Include="WindowsBase" />
    <Reference Include="System.Xaml" />
    <Reference Include="RevitAPI">
      <HintPath>C:\Program Files\Autodesk\Revit 2024\RevitAPI.dll</HintPath>
      <Private>False</Private>
    </Reference>
    <Reference Include="RevitAPIUI">
      <HintPath>C:\Program Files\Autodesk\Revit 2024\RevitAPIUI.dll</HintPath>
      <Private>False</Private>
    </Reference>
    <Reference Include="csRevit.API">
      <HintPath>$(AppData)\Autodesk\ApplicationPlugins\csRevit.bundle\Contents\2024\csRevit.API.dll</HintPath>
      <Private>False</Private>
    </Reference>
  </ItemGroup>

  <!-- REFERENCES FOR REVIT 2025 AND NEWER (R25H) -->
  <ItemGroup Condition="'$(TargetFramework)' == 'net8.0-windows'">
    <Reference Include="RevitAPI">
      <HintPath>C:\Program Files\Autodesk\Revit 2025\RevitAPI.dll</HintPath>
      <Private>False</Private>
    </Reference>
    <Reference Include="RevitAPIUI">
      <HintPath>C:\Program Files\Autodesk\Revit 2025\RevitAPIUI.dll</HintPath>
      <Private>False</Private>
    </Reference>
    <Reference Include="csRevit.API">
      <HintPath>$(AppData)\Autodesk\ApplicationPlugins\csRevit.bundle\Contents\2025\csRevit.API.dll</HintPath>
      <Private>False</Private>
    </Reference>
  </ItemGroup>

  <!-- ========================================================== -->
  <!-- AUTOMATED HYBRID DEPLOYMENT & CLASS.TXT GENERATOR          -->
  <!-- ========================================================== -->
  <Target Name="DeployToSandbox" AfterTargets="Build" Condition="'$(TargetFramework)' != ''">

    <!-- 1. DEFINE YOUR DESTINATION PATHS HERE -->
    <PropertyGroup>
      <!-- Leave blank if your tool doesn't use Background Services -->
      <DevServicePath>$(AppData)\csRevit\DEV\Services\MyEnterpriseService</DevServicePath>
      
      <!-- For UI Buttons (Example: Deploying two tools into a Split Button) -->
      <Btn1>$(AppData)\csRevit\DEV\02_Advanced.panel\Quick Select.splitbutton\Select All.pushbutton</Btn1>
      <Btn2>$(AppData)\csRevit\DEV\02_Advanced.panel\Quick Select.splitbutton\Select None.pushbutton</Btn2>
    </PropertyGroup>

    <!-- ========================================== -->
    <!-- 2. AUTO-DEPLOY BACKGROUND SERVICE          -->
    <!-- ========================================== -->
    <Copy Condition="'$(TargetFramework)' == 'net48' And '$(DevServicePath)' != ''" SourceFiles="$(TargetPath)" DestinationFolder="$(DevServicePath)\R24L" />
    <Copy Condition="'$(TargetFramework)' == 'net8.0-windows' And '$(DevServicePath)' != ''" SourceFiles="$(TargetPath)" DestinationFolder="$(DevServicePath)\R25H" />

    <!-- ========================================== -->
    <!-- 3. AUTO-DEPLOY UI BUTTON 1                 -->
    <!-- ========================================== -->
    <Copy Condition="'$(TargetFramework)' == 'net48'" SourceFiles="$(TargetPath)" DestinationFolder="$(Btn1)\R24L" />
    <Copy Condition="'$(TargetFramework)' == 'net8.0-windows'" SourceFiles="$(TargetPath)" DestinationFolder="$(Btn1)\R25H" />
    <!-- Automatically generate the class.txt file to isolate the command! -->
    <WriteLinesToFile File="$(Btn1)\class.txt" Lines="SelectAllCommand" Overwrite="true" />

    <!-- ========================================== -->
    <!-- 4. AUTO-DEPLOY UI BUTTON 2                 -->
    <!-- ========================================== -->
    <Copy Condition="'$(TargetFramework)' == 'net48'" SourceFiles="$(TargetPath)" DestinationFolder="$(Btn2)\R24L" />
    <Copy Condition="'$(TargetFramework)' == 'net8.0-windows'" SourceFiles="$(TargetPath)" DestinationFolder="$(Btn2)\R25H" />
    <!-- Automatically generate the class.txt file to isolate the command! -->
    <WriteLinesToFile File="$(Btn2)\class.txt" Lines="SelectNoneCommand" Overwrite="true" />

  </Target>

</Project>



6. Background Services & Dockable Panes


Beyond standard buttons, csRevit functions as a complete microkernel that can manage background applications and silent event triggers.

If you need to deploy Dockable Panes, custom IUpdater instances, or complex idle events, you must write an IExternalApplication. Place the compiled DLL inside the Services folder at the root of the Master Drive (e.g., Services\MyUpdater\R25H\MyUpdater.dll).

The csRevit engine will automatically discover the service on boot, instantiate it, and execute its OnStartup() method safely.

It will also gracefully execute its OnShutdown() method when the user closes Revit.

Note on Syncing: While UI buttons (.pushbutton) update instantly mid-session when a user clicks "Sync", Background Services are tied directly to Revit's boot cycle. If a Service is updated mid-session, the user will receive a polite prompt advising them to restart Revit to apply the background update.

Found a bug or have a feature request?
We actively maintain and improve the csRevit Framework. Please use our public issue tracker:

🐛 Report a Bug

[svengineeringcs@svecs.in](mailto:svengineeringcs@svecs.in)

💡 Request a Feature

[svengineeringcs@svecs.in](mailto:svengineeringcs@svecs.in)

Built with precision by SVECS BIM & AUTOMATION

[SVECS BIM & AUTOMATION](https://svecs.in/)
