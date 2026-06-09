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
* 📂 **Folder-Based UI Generation:** Create tabs, panels, dropdowns, true split-buttons, and stacked columns just by naming Windows folders. Zero C# UI coding required.
* 🧬 **Multi-Version Concurrency:** Run Revit 2024 (.NET 4.8) and Revit 2025 (.NET 8.0) simultaneously without file lock crashes.
* 🛡️ **The Hybrid SDK:** Seamlessly link standard pushbuttons to persistent background services and native Dockable Panes.
* 🧩 **Multi-Tool Isolation (`class.txt`):** Compile dozens of commands into a single DLL, and let our engine automatically isolate and deploy them to specific buttons across your ribbon[cite: 1].
* 🔍 **Spotlight Search:** A built-in command palette[cite: 1]. Users can type to search, run, favorite, or assign custom keyboard shortcuts to any tool[cite: 1].
* 📊 **Admin Analytics:** Secure, centralized telemetry tracking tool usage, success rates, and ROI across your entire firm[cite: 1].

---

## 💻 How It Works (Zero-Code UI)

Creating a highly complex, enterprise-grade Revit Ribbon is as simple as creating Windows folders on your Master Network Drive[cite: 1]:

```text
csRevit_Core (Master Network Drive)
├── [All] General Tools.tab               
│   ├── 01_Modify.panel                   
│   │   ├── Export PDF.pushbutton         <-- 1. Standard Button
│   │   └── Company Standards.urlbutton   <-- 2. URL/Link Button
│   │
│   └── 02_Advanced.panel                 
│       ├── Model Check.pulldown          <-- 3. Pulldown Menu
│       ├── Quick Select.splitbutton      <-- 4. True Split Button 
│       └── 03_Alignment.stack            <-- 5. Vertical Stacked Buttons
The engine handles all the complex API registrations, natural sorting, and icon resizing automatically[cite: 1].

💼 Licensing & How to Buy
The csRevit Framework is a commercial, enterprise-grade product designed to save BIM teams hundreds of hours in deployment and UI management[cite: 1].

This repository serves as our public documentation and issue tracker[cite: 1]. The compiled framework .bundle, Sync Engine, and proprietary source code are securely distributed to licensed clients[cite: 1].

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

![csRevit Folder Structure](https://raw.githubusercontent.com/SVECS-5967/csRevit/main/docs/Folder%20Structure.png)

👨‍💻 Developer Guide & C# Boilerplates

🔌 Hybrid SDK & Dockable Panes

Found a bug or have a feature request?
We actively maintain and improve the csRevit Framework. Please use our public issue tracker:

🐛 Report a Bug

💡 Request a Feature

Built with precision by SVECS BIM & AUTOMATION
