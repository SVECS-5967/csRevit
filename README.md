# ⚡ csRevit : Enterprise BIM Automation
[![Revit Supported](https://img.shields.io/badge/Revit-2019--2026-blue.svg)](https://appstore.svecs.in) [![License](https://img.shields.io/badge/License-Commercial-brightgreen.svg)](https://appstore.svecs.in/checkout/buy/38ffaf7c-d06c-4665-b309-8a50b18fae45) [![Status](https://img.shields.io/badge/Status-Free_Trial-orange.svg)](https://appstore.svecs.in/checkout/buy/bade39f5-94a2-45ca-94a0-5745a00d08bb)

> **The ultimate decoupled architecture for Autodesk Revit.** Build, deploy, and manage enterprise BIM tools across your firm instantly—without ever forcing users to restart Revit.

![csRevit Hero Banner](docs/assets/hero-banner.png)

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

🚀 Start your 15-Day Free Trial Here

[cite: 1]

🛒 Purchase a Commercial License Here

[cite: 1]

📚 Documentation & Support
Whether you are a BIM Manager deploying the framework, or a C# Developer building tools on top of it, everything you need is in our official documentation:

🚀 Getting Started & Installation Guide

🏗️ The Master Folder Tree Layout

Found a bug or have a feature request? We actively maintain and improve the csRevit Framework[cite: 1]. Please use our public issue tracker:

🐛 Report a Bug

💡 Request a Feature

Built with precision by SVECS BIM & AUTOMATION
