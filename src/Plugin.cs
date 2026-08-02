using BepInEx;
using BepInEx.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PupBase
{
	/// Replace with your own info! V
    [BepInPlugin("MySlugpup.PupBaseMod", "ModNameHere", "1.2.10")]
    internal class Plugin : BaseUnityPlugin
    {
        public void OnEnable()
        {
            Plugin.ModLogger = base.Logger;
            On.RainWorld.OnModsInit += this.RainWorld_OnModsInit;
            Plugin.ModLogger.LogInfo("Initialized");
        }

        private void LoadResources(global::RainWorld rainWorld)
        {
        }
        private bool IsInit = false;

        private void RainWorld_OnModsInit(On.RainWorld.orig_OnModsInit orig, global::RainWorld self)
        {
            orig(self);
            try
            {
                bool isInit = this.IsInit;
                if (!isInit)
                {
                    KewlSlugpupNames.RegisterValues();
					/// Replace with your own info! V
                    bool flag = global::ModManager.ActiveMods.Any((global::ModManager.Mod mod) => mod.id == "MySlugpup.PupBaseMod");
                    if (flag)
                    {
                        Plugin.PupBaseInit();
                    }
                    ModOptions.RegisterOI();
					this.IsInit = true;
                }
            }
            catch (Exception ex)
            {
                base.Logger.LogError(ex);
                throw;
            }
        }
        public static void PupBaseInit()
        {
            /// ALL THE PUP STATS!
            KewlSlugpupNames.RegisterValuesPupBase();
            PupType Awesom = PupManager.Register(new PupType(Plugin.MOD_NAME, KewlSlugpupNames.Slot1Pup, 5));
            Awesom.foodToHibernate = 2;
            Awesom.maxFood = 3;
            Awesom.adultModule = new PupType.AdultModule(new SlugcatStats.Name("Slot1Adult", register: true), 50);
            Plugin.PupBase = true;
            ///
            PupType Awesom2 = PupManager.Register(new PupType(Plugin.MOD_NAME, KewlSlugpupNames.Slot2Pup, 5));
            Awesom2.foodToHibernate = 2;
            Awesom2.maxFood = 3;
            Awesom2.adultModule = new PupType.AdultModule(new SlugcatStats.Name("Slot2Adult", register: true), 50);
            Plugin.PupBase = true;
            ///
            PupType Awesom3 = PupManager.Register(new PupType(Plugin.MOD_NAME, KewlSlugpupNames.Slot3Pup, 5));
            Awesom3.foodToHibernate = 2;
            Awesom3.maxFood = 3;
            Awesom3.adultModule = new PupType.AdultModule(new SlugcatStats.Name("Slot3Adult", register: true), 50);
            Plugin.PupBase = true;
            ///
            PupType Awesom4 = PupManager.Register(new PupType(Plugin.MOD_NAME, KewlSlugpupNames.Slot4Pup, 5));
            Awesom4.foodToHibernate = 2;
            Awesom4.maxFood = 3;
            Awesom4.adultModule = new PupType.AdultModule(new SlugcatStats.Name("Slot4Adult", register: true), 50);
            Plugin.PupBase = true;
            ///
            PupType Awesom5 = PupManager.Register(new PupType(Plugin.MOD_NAME, KewlSlugpupNames.Slot5Pup, 5));
            Awesom5.foodToHibernate = 2;
            Awesom5.maxFood = 3;
            Awesom5.adultModule = new PupType.AdultModule(new SlugcatStats.Name("Slot5Adult", register: true), 50);
            Plugin.PupBase = true;
            ///
            PupType Awesom6 = PupManager.Register(new PupType(Plugin.MOD_NAME, KewlSlugpupNames.Slot6Pup, 5));
            Awesom6.foodToHibernate = 2;
            Awesom6.maxFood = 3;
            Awesom6.adultModule = new PupType.AdultModule(new SlugcatStats.Name("Slot6Adult", register: true), 50);
            Plugin.PupBase = true;
            ///
            PupType Awesom7 = PupManager.Register(new PupType(Plugin.MOD_NAME, KewlSlugpupNames.Slot7Pup, 5));
            Awesom7.foodToHibernate = 2;
            Awesom7.maxFood = 3;
            Awesom7.adultModule = new PupType.AdultModule(new SlugcatStats.Name("Slot7Adult", register: true), 50);
            Plugin.PupBase = true;
            ///
            PupType Awesom8 = PupManager.Register(new PupType(Plugin.MOD_NAME, KewlSlugpupNames.Slot8Pup, 5));
            Awesom8.foodToHibernate = 2;
            Awesom8.maxFood = 3;
            Awesom8.adultModule = new PupType.AdultModule(new SlugcatStats.Name("Slot8Adult", register: true), 50);
            Plugin.PupBase = true;
            ///
            PupType Awesom9 = PupManager.Register(new PupType(Plugin.MOD_NAME, KewlSlugpupNames.Slot9Pup, 5));
            Awesom9.foodToHibernate = 2;
            Awesom9.maxFood = 3;
            Awesom9.adultModule = new PupType.AdultModule(new SlugcatStats.Name("Slot9Adult", register: true), 50);
            Plugin.PupBase = true;
            ///
            PupType Awesom10 = PupManager.Register(new PupType(Plugin.MOD_NAME, KewlSlugpupNames.Slot10Pup, 5));
            Awesom10.foodToHibernate = 2;
            Awesom10.maxFood = 3;
            Awesom10.adultModule = new PupType.AdultModule(new SlugcatStats.Name("Slot10Adult", register: true), 50);
            Plugin.PupBase = true;
            ///
            PupType Awesom11 = PupManager.Register(new PupType(Plugin.MOD_NAME, KewlSlugpupNames.Slot11Pup, 5));
            Awesom11.foodToHibernate = 2;
            Awesom11.maxFood = 3;
            Awesom11.adultModule = new PupType.AdultModule(new SlugcatStats.Name("Slot11Adult", register: true), 50);
            Plugin.PupBase = true;
            ///
            PupType Awesom12 = PupManager.Register(new PupType(Plugin.MOD_NAME, KewlSlugpupNames.Slot12Pup, 5));
            Awesom12.foodToHibernate = 2;
            Awesom12.maxFood = 3;
            Awesom12.adultModule = new PupType.AdultModule(new SlugcatStats.Name("Slot12Adult", register: true), 50);
            Plugin.PupBase = true;
            ///
            PupType Awesom13 = PupManager.Register(new PupType(Plugin.MOD_NAME, KewlSlugpupNames.Slot13Pup, 5));
            Awesom13.foodToHibernate = 2;
            Awesom13.maxFood = 3;
            Awesom13.adultModule = new PupType.AdultModule(new SlugcatStats.Name("Slot13Adult", register: true), 50);
            Plugin.PupBase = true;
            ///
            PupType Awesom14 = PupManager.Register(new PupType(Plugin.MOD_NAME, KewlSlugpupNames.Slot14Pup, 5));
            Awesom14.foodToHibernate = 2;
            Awesom14.maxFood = 3;
            Awesom14.adultModule = new PupType.AdultModule(new SlugcatStats.Name("Slot14Adult", register: true), 50);
            Plugin.PupBase = true;
            ///
            PupType Awesom15 = PupManager.Register(new PupType(Plugin.MOD_NAME, KewlSlugpupNames.Slot15Pup, 5));
            Awesom15.foodToHibernate = 2;
            Awesom15.maxFood = 3;
            Awesom15.adultModule = new PupType.AdultModule(new SlugcatStats.Name("Slot15Adult", register: true), 50);
            Plugin.PupBase = true;
            ///
            PupType Awesom16 = PupManager.Register(new PupType(Plugin.MOD_NAME, KewlSlugpupNames.Slot16Pup, 5));
            Awesom16.foodToHibernate = 2;
            Awesom16.maxFood = 3;
            Awesom16.adultModule = new PupType.AdultModule(new SlugcatStats.Name("Slot16Adult", register: true), 50);
            Plugin.PupBase = true;
            ///
            PupType Awesom17 = PupManager.Register(new PupType(Plugin.MOD_NAME, KewlSlugpupNames.Slot17Pup, 5));
            Awesom17.foodToHibernate = 2;
            Awesom17.maxFood = 3;
            Awesom17.adultModule = new PupType.AdultModule(new SlugcatStats.Name("Slot17Adult", register: true), 50);
            Plugin.PupBase = true;
            ///
            PupType Awesom18 = PupManager.Register(new PupType(Plugin.MOD_NAME, KewlSlugpupNames.Slot18Pup, 5));
            Awesom18.foodToHibernate = 2;
            Awesom18.maxFood = 3;
            Awesom18.adultModule = new PupType.AdultModule(new SlugcatStats.Name("Slot18Adult", register: true), 50);
            Plugin.PupBase = true;
            ///
            PupType Awesom19 = PupManager.Register(new PupType(Plugin.MOD_NAME, KewlSlugpupNames.Slot19Pup, 5));
            Awesom19.foodToHibernate = 2;
            Awesom19.maxFood = 3;
            Awesom19.adultModule = new PupType.AdultModule(new SlugcatStats.Name("Slot19Adult", register: true), 50);
            Plugin.PupBase = true;
            ///
            PupType Awesom20 = PupManager.Register(new PupType(Plugin.MOD_NAME, KewlSlugpupNames.Slot20Pup, 5));
            Awesom20.foodToHibernate = 2;
            Awesom20.maxFood = 3;
            Awesom20.adultModule = new PupType.AdultModule(new SlugcatStats.Name("Slot20Adult", register: true), 50);
            Plugin.PupBase = true;

        }
        public static bool CheckPupCompatibility(global::Player player)
        {
            bool result;
            try
            {
                PupType pupType;
                bool flag = PupManager.TryGetPupType(KewlSlugpupNames.Slot1Pup, out pupType) && player.PupType() == pupType;
                if (flag)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }

            catch (Exception ex)
            {
                Plugin.ModLogger.LogError(ex);
                result = false;
            }
            return result;
        }

        /// PUT YOUR OWN INFO BELOW!!!

        public const string MOD_ID = "MySlugpup.PupBaseMod";

            public static readonly bool LogOutPut = true;

            public const string MOD_NAME = "ModNameHere";

            public const string VERSION = "1.1.8";

            public const string AUTHORS = "YOURNAMEHERE";

            public static bool PupBase = false;

            public static ManualLogSource ModLogger;
        }
    }
