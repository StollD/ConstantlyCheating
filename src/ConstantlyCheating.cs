using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace ConstantlyCheating
{
    [KSPScenario(ScenarioCreationOptions.AddToAllGames, GameScenes.EDITOR, GameScenes.FLIGHT, GameScenes.SPACECENTER, GameScenes.TRACKSTATION)]
    public class ConstantlyCheating : ScenarioModule
    {
        /// <summary>
        /// Load the saved cheat options
        /// </summary>
        public override void OnLoad(ConfigNode node)
        {
            if (node.HasValue("AllowPartClipping"))
            {
                Boolean.TryParse(node.GetValue("AllowPartClipping"), out CheatOptions.AllowPartClipping);
            }
            if (node.HasValue("BiomesVisible"))
            {
                Boolean.TryParse(node.GetValue("BiomesVisible"), out CheatOptions.BiomesVisible);
            }
            if (node.HasValue("IgnoreAgencyMindsetOnContracts"))
            {
                Boolean.TryParse(node.GetValue("IgnoreAgencyMindsetOnContracts"), out CheatOptions.IgnoreAgencyMindsetOnContracts);
            }
            if (node.HasValue("IgnoreMaxTemperature"))
            {
                Boolean.TryParse(node.GetValue("IgnoreMaxTemperature"), out CheatOptions.IgnoreMaxTemperature);
            }
            if (node.HasValue("InfiniteElectricity"))
            {
                Boolean.TryParse(node.GetValue("InfiniteElectricity"), out CheatOptions.InfiniteElectricity);
            }
            if (node.HasValue("InfinitePropellant"))
            {
                Boolean.TryParse(node.GetValue("InfinitePropellant"), out CheatOptions.InfinitePropellant);
            }
            if (node.HasValue("NoCrashDamage"))
            {
                Boolean.TryParse(node.GetValue("NoCrashDamage"), out CheatOptions.NoCrashDamage);
            }
            if (node.HasValue("NonStrictAttachmentOrientation"))
            {
                Boolean.TryParse(node.GetValue("NonStrictAttachmentOrientation"), out CheatOptions.NonStrictAttachmentOrientation);
            }
            if (node.HasValue("PauseOnVesselUnpack"))
            {
                Boolean.TryParse(node.GetValue("PauseOnVesselUnpack"), out CheatOptions.PauseOnVesselUnpack);
            }
            if (node.HasValue("UnbreakableJoints"))
            {
                Boolean.TryParse(node.GetValue("UnbreakableJoints"), out CheatOptions.UnbreakableJoints);
            }
        }

        /// <summary>
        /// Save the cheat options
        /// </summary>
        public override void OnSave(ConfigNode node)
        {
            node.SetValue("AllowPartClipping", CheatOptions.AllowPartClipping, true);
            node.SetValue("BiomesVisible", CheatOptions.BiomesVisible, true);
            node.SetValue("IgnoreAgencyMindsetOnContracts", CheatOptions.IgnoreAgencyMindsetOnContracts, true);
            node.SetValue("IgnoreMaxTemperature", CheatOptions.IgnoreMaxTemperature, true);
            node.SetValue("InfiniteElectricity", CheatOptions.InfiniteElectricity, true);
            node.SetValue("InfinitePropellant", CheatOptions.InfinitePropellant, true);
            node.SetValue("NoCrashDamage", CheatOptions.NoCrashDamage, true);
            node.SetValue("NonStrictAttachmentOrientation", CheatOptions.NonStrictAttachmentOrientation, true);
            node.SetValue("PauseOnVesselUnpack", CheatOptions.PauseOnVesselUnpack, true);
            node.SetValue("UnbreakableJoints", CheatOptions.UnbreakableJoints, true);
        }
    }
}
