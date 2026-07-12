using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BepInEx.NET.Common;
using BepInExResoniteShim;
using BepisResoniteWrapper;
using Elements.Core;
using FrooxEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using FrooxEngine.UIX;
using HarmonyLib;
using System.Reflection;
using System.Reflection.Emit;

namespace BepisArrayEditor;

[ResonitePlugin(PluginMetadata.GUID, PluginMetadata.NAME, PluginMetadata.VERSION, PluginMetadata.AUTHORS, PluginMetadata.REPOSITORY_URL)]
[BepInDependency(BepInExResoniteShim.PluginMetadata.GUID)]
public class BepisArrayEditor : BasePlugin
{
    internal new static ManualLogSource Log = null!;
    public override void Load()
    {
        Log = base.Log;
        try
        {
            HarmonyInstance.PatchAll();
            Log.LogInfo("BepisArrayEditor Loaded!");
        } 
        catch (System.Exception ex)
        {
            Log.LogError($"BepisArrayEditor failed to patch: {ex}");
        }
    }
}