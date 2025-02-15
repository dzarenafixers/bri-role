# BRI Role Plugin for EXILED 9.5.0

This plugin introduces a custom role called **BRI** for SCP: Secret Laboratory servers using **EXILED 9.5.0**.  
The **BRI** role is a special guard that spawns in the **Class-D area** instead of the usual MTF spawn location.  
Their main task is to **protect the scientists** from Class-D personnel and other threats.  

## 🔹 Features
- ✅ **Custom Role using EXILED's `CustomRoles API`**
- ✅ **Spawns in the Class-D area instead of MTF spawn points**
- ✅ **Starts with light weapons (`GunFSP9`), a `Guard Keycard`, and `SCP-500`**
- ✅ **Has slightly increased health (120 HP)**
- ✅ **Broadcast message on spawn to inform players of their objective**
- ✅ **Works flawlessly on EXILED 9.5.0**

## 📂 File Structure
### BRI_Role/ ├── Plugin.cs # Main plugin manager for EXILED API ├── BRIRole.cs # Defines the BRI role using CustomRole ├── Config.cs # Configurable settings in config.yml


## 📜 Installation Guide
### 1️⃣ Download & Compile the Plugin
- Compile the plugin into a `.dll` file using **Visual Studio** with EXILED 9.5.0 dependencies.

### 2️⃣ Place the Plugin in the Server Directory
- Move the compiled `.dll` file to:

