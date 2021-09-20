﻿using System.Collections.Generic;

namespace Core_BetterPenetration
{
#if HS2 || AI
    static class LookTargets
    {
        internal const string HeadTarget = "k_f_head_00";
        internal const string KokanTarget = "k_f_kokan_00";
        internal const string BPKokanTarget = "cf_J_Vagina_root";
        internal const string AnaTarget = "k_f_ana_00";
        internal const string InnerTarget = "cf_J_Kosi01";
        internal const string InnerHeadTarget = "cf_J_FaceBase";
    }

    static class BoneNames
    {

        internal const string KokanBone = "cf_J_Kokan";
        internal const string TamaTop = "cm_J_dan_f_top";
        internal const string BPBone = "cf_J_Vagina";
        internal const string BPDanBone = "cm_J_dan";
        internal const string BPDanEnd = "cm_J_dan119_00";
        internal const string mouthPullBone = "cf_J_MouthMove";

        internal const string BPKokanTarget = "cf_J_Vagina_root";
        internal const string AnaTarget = "cf_J_Ana";
        internal const string InnerTarget = "cf_J_Kosi01";
        internal const string HeadTarget = "cf_J_MouthLow";
        internal const string InnerHeadTarget = "cf_J_FaceBase";
        internal const string BPDanEntryTarget = "k_f_dan_entry";
        internal const string BPDanEndTarget = "k_f_dan_end";

        internal static readonly List<string> KokanPullBones = new List<string> { "cf_J_Vagina_L.011", "cf_J_Vagina_R.011", "cf_J_Vagina_L.012", "cf_J_Vagina_R.012", "cf_J_Vagina_L.013", "cf_J_Vagina_R.013",
                                                                                  "cf_J_Vagina_L.014", "cf_J_Vagina_L.015", "cf_J_Vagina_R.014", "cf_J_Vagina_R.015", "cf_J_Vagina_B.010" };
        internal static readonly List<string> DanBones = new List<string> { "cm_J_dan101_00", "cm_J_dan102_00", "cm_J_dan103_00", "cm_J_dan104_00", "cm_J_dan105_00", "cm_J_dan106_00", "cm_J_dan107_00", "cm_J_dan108_00", "cm_J_dan109_00" };
        internal static readonly List<string> TamaBones = new List<string> { "cm_J_dan_Pivot_f_top", "cm_J_dan_Pivot_f_L", "cm_J_dan_Pivot_f_R"};
        internal static readonly List<string> FingerColliders = new List<string> { "cf_J_Hand_Index02_R", "cf_J_Hand_Index03_R", "cf_J_Hand_Middle02_R", "cf_J_Hand_Middle03_R", "cf_J_Hand_Ring02_R", "cf_J_Hand_Ring03_R" };
        internal static readonly List<string> MidSectionColliders = new List<string> { "cf_hit_Kosi02_s", "cf_hit_LegUp01_s_L", "cf_hit_LegUp01_s_R"};
        internal static readonly List<string> BodyColliders = new List<string> { "cf_hit_Kosi02_s", "cf_hit_LegLow02_s_L", "cf_hit_LegLow02_s_R", "cf_hit_LegUp01_s_L", "cf_hit_LegUp01_s_R", 
                                                                                 "cf_J_Spine01_s", "cf_J_Spine02_s", "cf_J_Spine03_s", "cf_hit_Mune02_s_L", "cf_hit_Mune02_s_R", 
                                                                                 "ColFace01", "ColFace02", "cf_J_Neck_s", "cf_J_ArmUp02_s_L", "cf_J_ArmUp02_s_R" };
        internal static readonly List<string> frontCollisionList = new List<string> { LookTargets.KokanTarget, "N_Waist_f"};
        internal static readonly List<string> backCollisionList = new List<string> { LookTargets.AnaTarget, "N_Waist_b"};
        internal static readonly List<string> animationAdjustmentList = new List<string> { "ais_f_00", "ais_f_01", "ais_f_12", "ais_f_19", "ais_f_20" };

        internal static readonly List<string> vibeBones = new List<string> { "J_vibe_00", "J_vibe_01", "J_vibe_02", "J_vibe_03", "J_vibe_04", "J_vibe_05"};
        internal static readonly List<string> vibe2Bones = new List<string> { "j_ai_hi_hitem02_02", "j_ai_hi_hitem02_03", "j_ai_hi_hitem02_04", "j_ai_hi_hitem02_05", "j_ai_hi_hitem02_06", "j_ai_hi_hitem02_07" };
        internal static readonly List<string> dildoBones = new List<string> { "J_dildo_00", "J_dildo_01", "J_dildo_02", "J_dildo_03", "J_dildo_04", "J_dildo_05" };
        internal static readonly List<string> tentacleBones = new List<string> { "j_S_kokan_01", "j_S_kokan_02", "j_S_kokan_03", "j_S_kokan_04", "j_S_kokan_05" };

        internal static readonly List<string> vibeAnimationNames = new List<string> { "ait_f_14", "aia_f_15", "aia_f_16", "aia_f_20" };
        internal static readonly List<string> vibe2AnimationNames = new List<string> {"ait_f_13" };
        internal static readonly List<string> dildoAnimationNames = new List<string> {"ait_f_02" };
        internal static readonly List<string> tentacleAnimationNames = new List<string> {"h2t_f_09", "h2t_f_10" };

        internal static readonly List<string> maleFingerAnimationNames = new List<string> { "aia_f_03", "aia_f_05", "aia_f_14", "aia_f_21", "h2a_f_00", "h2_mf2_f1_02", "h2_mf2_f2_05" };
        internal static readonly List<string> femaleSelfFingerAnimationNames = new List<string> { "ait_f_01", "ait_f_03", "ait_f_04", "ait_f_05", "ait_f_06", "ait_f_08", "ait_f_09"};
        internal static readonly List<string> firstFemaleFingerAnimationNames = new List<string> { "ail_f2_01" };
        internal static readonly List<string> secondFemaleFingerAnimationNames = new List<string> { "ail_f1_01" };
    }
#endif

#if KK
    static class LookTargets
    {
        internal const string HeadTarget = "k_f_head_00";
        internal const string KokanTarget = "k_f_kokan_00";
        internal const string BPKokanTarget = "cf_J_Vagina_root";
        internal const string AnaTarget = "k_f_ana_00";
        internal const string InnerTarget = "cf_j_waist01";
        internal const string InnerHeadTarget = "cf_J_FaceBase";
    }

    static class BoneNames
    {
        internal const string KokanBone = "cf_j_kokan";
        internal const string TamaTop = "cm_J_dan_f_top";
        internal const string BPBone = "cf_J_Vagina";
        internal const string BPDanBone = "cm_J_dan";
        internal const string BPDanEnd = "cm_J_dan119_00";
        internal const string mouthPullBone = "cf_J_MouthMove";

        internal const string BPKokanTarget = "cf_J_Vagina_root";
        internal const string AnaTarget = "cf_j_ana";
        internal const string InnerTarget = "cf_j_waist01";
        internal const string HeadTarget = "cf_J_MouthLow";
        internal const string InnerHeadTarget = "cf_J_FaceBase";
        internal const string BPDanEntryTarget = "k_f_dan_entry";
		internal const string BPDanEndTarget = "k_f_dan_end";

        internal static readonly List<string> KokanPullBones = new List<string> { "cf_J_Vagina_L.011", "cf_J_Vagina_R.011", "cf_J_Vagina_L.012", "cf_J_Vagina_R.012", "cf_J_Vagina_L.013", "cf_J_Vagina_R.013",
                                                                                  "cf_J_Vagina_L.014", "cf_J_Vagina_L.015", "cf_J_Vagina_R.014", "cf_J_Vagina_R.015", "cf_J_Vagina_B.010" };
        internal static readonly List<string> DanBones = new List<string> { "cm_J_dan101_00", "cm_J_dan102_00", "cm_J_dan103_00", "cm_J_dan104_00", "cm_J_dan105_00", "cm_J_dan106_00", "cm_J_dan107_00", "cm_J_dan108_00", "cm_J_dan109_00" };
        internal static readonly List<string> TamaBones = new List<string> { "cm_J_dan_Pivot_f_L", "cm_J_dan_Pivot_f_R" };
        internal static readonly List<string> FingerColliders = new List<string> { "cf_j_index02_R", "cf_j_index03_R", "cf_j_middle02_R", "cf_j_middle03_R", "cf_j_ring02_R", "cf_j_ring03_R" };
        internal static readonly List<string> MidSectionColliders = new List<string> { "cm_J_dan101_00", "cm_J_dan103_00", "cf_hit_waist02", "cf_hit_LegLow02_s_L", "cf_hit_LegLow02_s_R" };
        internal static readonly List<string> BodyColliders = new List<string> { "cf_hit_thigh01_L", "cf_hit_thigh01_R", "cf_hit_thigh02_L", "cf_hit_thigh02_R", 
                                                                                 "cf_hit_waist_L", "cf_hit_berry", "cf_hit_waist01", "cf_hit_waist02",
                                                                                 "cf_hit_spine01", "cf_hit_spine02", "cf_hit_spine03", "cf_hit_spine03_2", 
                                                                                 "cf_hit_bust00", "cf_hit_bust02_L", "cf_hit_bust02_R",
                                                                                 "cf_hit_neck", "cf_hit_head", 
                                                                                 "cf_hit_arm_L", "cf_hit_arm_R", "cf_hit_shoulder_L", "cf_hit_shoulder_R" };

        internal static readonly List<string> frontCollisionList = new List<string> { LookTargets.KokanTarget, "a_n_waist_f", "a_n_bust_f" };
        internal static readonly List<string> backCollisionList = new List<string> { LookTargets.AnaTarget, "a_n_waist_b", "a_n_back" };
        internal static readonly List<string> animationAdjustmentList = new List<string> { "ais_f_00", "ais_f_01", "ais_f_12", "ais_f_19", "ais_f_20" };

        internal static readonly List<string> maleFingerAnimationNames = new List<string> { "aia_f_03", "aia_f_05", "aia_f_14", "aia_f_21", "h2a_f_00", "h2_mf2_f1_02", "h2_mf2_f2_05" };
        internal static readonly List<string> femaleSelfFingerAnimationNames = new List<string> { "ait_f_01", "ait_f_03", "ait_f_04", "ait_f_05", "ait_f_06", "ait_f_08", "ait_f_09"};
        internal static readonly List<string> firstFemaleFingerAnimationNames = new List<string> { "ail_f2_01" };
        internal static readonly List<string> secondFemaleFingerAnimationNames = new List<string> { "ail_f1_01" };
    }
#endif
}
