using BepInEx;
using PieceManager;
using HarmonyLib;


namespace MissingPieces
{
    [BepInPlugin(ModGuid, ModName, ModVersion)]
    public class MissingPieces : BaseUnityPlugin
    {
        private const string ModName = "MissingPieces";
        private const string ModVersion = "1.1.0";
        private const string Author = "Bento";
        private const string ModGuid = Author + "." + ModName;

        private void Awake()
        {
            Harmony harmony = new Harmony(ModGuid);
            harmony.PatchAll();
            
            // Stone Blocks:

            BuildPiece stonewall1X1Triangular = new("missing_pieces", "stone_wall_1x1_triangular");
            stonewall1X1Triangular.Name.English("Triangular 1x1 Stone Wall");
            stonewall1X1Triangular.Description.English("You're welcome!");
            stonewall1X1Triangular.RequiredItems.Add("Stone", 2, true);
            MaterialReplacer.RegisterGameObjectForMatSwap(stonewall1X1Triangular.Prefab);

            BuildPiece stonewall2X1Triangular = new("missing_pieces", "stone_wall_2x1_triangular");
            stonewall2X1Triangular.Name.English("Triangular 2x1 Stone Wall");
            stonewall2X1Triangular.Description.English("Should come in handy!");
            stonewall2X1Triangular.RequiredItems.Add("Stone", 2, true);
            MaterialReplacer.RegisterGameObjectForMatSwap(stonewall2X1Triangular.Prefab);

            BuildPiece stoneStairCorner = new("missing_pieces", "stone_stair_corner");
            stoneStairCorner.Name.English("Stone Corner Stair");
            stoneStairCorner.Description.English("How was this not a thing already?");
            stoneStairCorner.RequiredItems.Add("Stone", 6, true);
            MaterialReplacer.RegisterGameObjectForMatSwap(stoneStairCorner.Prefab);

            // Wood floors

            BuildPiece woodFloorTriangular1 = new("missing_pieces", "wood_floor_triangular1");
            woodFloorTriangular1.Name.English("Triangular Wood Floor (1)");
            woodFloorTriangular1.Description.English("The other one is different, I swear!");
            woodFloorTriangular1.RequiredItems.Add("Wood", 1, true);
            MaterialReplacer.RegisterGameObjectForMatSwap(woodFloorTriangular1.Prefab);

            BuildPiece woodFloorTriangular2 = new("missing_pieces", "wood_floor_triangular2");
            woodFloorTriangular2.Name.English("Triangular Wood Floor (2)");
            woodFloorTriangular2.Description.English("See? I told you.");
            woodFloorTriangular2.RequiredItems.Add("Wood", 1, true);
            MaterialReplacer.RegisterGameObjectForMatSwap(woodFloorTriangular2.Prefab);

            // Better stepladder

            BuildPiece finerstepladder = new("missing_pieces", "wood_finerstepladder");
            finerstepladder.Name.English("Finer Wood Ladder");
            finerstepladder.Description.English("Oh no. What are you doing step-ladder?");
            finerstepladder.RequiredItems.Add("Wood", 3, true);
            MaterialReplacer.RegisterGameObjectForMatSwap(finerstepladder.Prefab);

            // Wood Stair (1m wide)

            BuildPiece woodStair1M = new("missing_pieces", "wood_stair_1m");
            woodStair1M.Name.English("1m Wide Stair");
            woodStair1M.Description.English("Are you on a diet?");
            woodStair1M.RequiredItems.Add("Wood", 1, true);
            MaterialReplacer.RegisterGameObjectForMatSwap(woodStair1M.Prefab);

            // Wood roofs:

            BuildPiece rightWoodRoof26Triangular = new("missing_pieces", "roof_wood_26_right");
            rightWoodRoof26Triangular.Name.English("Right Triangular Wood Roof (26°)");
            rightWoodRoof26Triangular.Description.English("W o o d");
            rightWoodRoof26Triangular.RequiredItems.Add("Wood", 1, true);
            MaterialReplacer.RegisterGameObjectForMatSwap(rightWoodRoof26Triangular.Prefab);

            BuildPiece leftWoodRoof26Triangular = new("missing_pieces", "roof_wood_26_left");
            leftWoodRoof26Triangular.Name.English("Left Triangular Wood Roof (26°)");
            leftWoodRoof26Triangular.Description.English("Vood");
            leftWoodRoof26Triangular.RequiredItems.Add("Wood", 1, true);
            MaterialReplacer.RegisterGameObjectForMatSwap(leftWoodRoof26Triangular.Prefab);

            BuildPiece rightWoodRoof45Triangular = new("missing_pieces", "roof_wood_45_right");
            rightWoodRoof45Triangular.Name.English("Right Triangular Wood Roof (45°)");
            rightWoodRoof45Triangular.Description.English("Woody");
            rightWoodRoof45Triangular.RequiredItems.Add("Wood", 1, true);
            MaterialReplacer.RegisterGameObjectForMatSwap(rightWoodRoof45Triangular.Prefab);

            BuildPiece leftWoodRoof45Triangular = new("missing_pieces", "roof_wood_45_left");
            leftWoodRoof45Triangular.Name.English("Left Triangular Wood Roof (45°)");
            leftWoodRoof45Triangular.Description.English("Wud");
            leftWoodRoof45Triangular.RequiredItems.Add("Wood", 1, true);
            MaterialReplacer.RegisterGameObjectForMatSwap(leftWoodRoof45Triangular.Prefab);

            // Darkwood roofs:

            BuildPiece rightDarkwoodRoof26Triangular = new("missing_pieces", "roof_darkwood_26_right");
            rightDarkwoodRoof26Triangular.Name.English("Right Triangular Darkwood Roof (26°)");
            rightDarkwoodRoof26Triangular.Description.English("The right one.");
            rightDarkwoodRoof26Triangular.RequiredItems.Add("Wood", 1, true);
            rightDarkwoodRoof26Triangular.RequiredItems.Add("Tar", 1, true);
            MaterialReplacer.RegisterGameObjectForMatSwap(rightDarkwoodRoof26Triangular.Prefab);

            BuildPiece leftDarkwoodRoof26Triangular = new("missing_pieces", "roof_darkwood_26_left");
            leftDarkwoodRoof26Triangular.Name.English("Left Triangular Darkwood Roof (26°)");
            leftDarkwoodRoof26Triangular.Description.English("Maybe this is the one");
            leftDarkwoodRoof26Triangular.RequiredItems.Add("Wood", 1, true);
            leftDarkwoodRoof26Triangular.RequiredItems.Add("Tar", 1, true);
            MaterialReplacer.RegisterGameObjectForMatSwap(leftDarkwoodRoof26Triangular.Prefab);

            BuildPiece rightDarkwoodRoof45Triangular = new("missing_pieces", "roof_darkwood_45_right");
            rightDarkwoodRoof45Triangular.Name.English("Right Triangular Darkwood Roof (45°)");
            rightDarkwoodRoof45Triangular.Description.English("Nope, not this one either.");
            rightDarkwoodRoof45Triangular.RequiredItems.Add("Wood", 1, true);
            rightDarkwoodRoof45Triangular.RequiredItems.Add("Tar", 1, true);
            MaterialReplacer.RegisterGameObjectForMatSwap(rightDarkwoodRoof45Triangular.Prefab);

            BuildPiece leftDarkwoodRoof45Triangular = new("missing_pieces", "roof_darkwood_45_left");
            leftDarkwoodRoof45Triangular.Name.English("Left Triangular Darkwood Roof (45°)");
            leftDarkwoodRoof45Triangular.Description.English("Is this the right one?");
            leftDarkwoodRoof45Triangular.RequiredItems.Add("Wood", 1, true);
            leftDarkwoodRoof45Triangular.RequiredItems.Add("Tar", 1, true);
            MaterialReplacer.RegisterGameObjectForMatSwap(leftDarkwoodRoof45Triangular.Prefab);

        }
    }
    
    [HarmonyPatch(typeof(ZNetScene),nameof(ZNetScene.Awake))]
    static class ZNetScene_Awake_Patch
    {
        static void Postfix(ZNetScene __instance)
        {
            __instance.GetPrefab("wood_finerstepladder").GetComponent<Piece>().m_craftingStation = __instance.GetPrefab("piece_workbench").GetComponent<CraftingStation>();
            __instance.GetPrefab("wood_stair_1m").GetComponent<Piece>().m_craftingStation = __instance.GetPrefab("piece_workbench").GetComponent<CraftingStation>();
            __instance.GetPrefab("roof_darkwood_45_left").GetComponent<Piece>().m_craftingStation = __instance.GetPrefab("piece_workbench").GetComponent<CraftingStation>();
            __instance.GetPrefab("roof_darkwood_26_left").GetComponent<Piece>().m_craftingStation = __instance.GetPrefab("piece_workbench").GetComponent<CraftingStation>();
            __instance.GetPrefab("roof_darkwood_45_right").GetComponent<Piece>().m_craftingStation = __instance.GetPrefab("piece_workbench").GetComponent<CraftingStation>();
            __instance.GetPrefab("roof_darkwood_26_right").GetComponent<Piece>().m_craftingStation = __instance.GetPrefab("piece_workbench").GetComponent<CraftingStation>();
            __instance.GetPrefab("wood_floor_triangular1").GetComponent<Piece>().m_craftingStation = __instance.GetPrefab("piece_workbench").GetComponent<CraftingStation>();
            __instance.GetPrefab("wood_floor_triangular2").GetComponent<Piece>().m_craftingStation = __instance.GetPrefab("piece_workbench").GetComponent<CraftingStation>();
            __instance.GetPrefab("roof_wood_45_left").GetComponent<Piece>().m_craftingStation = __instance.GetPrefab("piece_workbench").GetComponent<CraftingStation>();
            __instance.GetPrefab("roof_wood_26_left").GetComponent<Piece>().m_craftingStation = __instance.GetPrefab("piece_workbench").GetComponent<CraftingStation>();
            __instance.GetPrefab("roof_wood_45_right").GetComponent<Piece>().m_craftingStation = __instance.GetPrefab("piece_workbench").GetComponent<CraftingStation>();
            __instance.GetPrefab("roof_wood_26_right").GetComponent<Piece>().m_craftingStation = __instance.GetPrefab("piece_workbench").GetComponent<CraftingStation>();
            __instance.GetPrefab("stone_wall_2x1_triangular").GetComponent<Piece>().m_craftingStation = __instance.GetPrefab("piece_stonecutter").GetComponent<CraftingStation>();
            __instance.GetPrefab("stone_wall_1x1_triangular").GetComponent<Piece>().m_craftingStation = __instance.GetPrefab("piece_stonecutter").GetComponent<CraftingStation>();
            __instance.GetPrefab("stone_stair_corner").GetComponent<Piece>().m_craftingStation = __instance.GetPrefab("piece_stonecutter").GetComponent<CraftingStation>();
        }
    }
}
