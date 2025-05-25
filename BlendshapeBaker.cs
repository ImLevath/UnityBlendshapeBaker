using UnityEngine;
using UnityEditor;

public class BlendshapeBaker : EditorWindow
{
    [MenuItem("Tools/Bake Blendshapes Into Mesh")]
    static void BakeSelectedMesh()
    {
        GameObject selected = Selection.activeGameObject;
        if (selected == null)
        {
            EditorUtility.DisplayDialog("No Selection", "Please select a GameObject with a SkinnedMeshRenderer.", "OK");
            return;
        }

        SkinnedMeshRenderer smr = selected.GetComponent<SkinnedMeshRenderer>();
        if (smr == null)
        {
            EditorUtility.DisplayDialog("No SkinnedMeshRenderer", "Selected GameObject does not have a SkinnedMeshRenderer.", "OK");
            return;
        }

        Mesh bakedMesh = new Mesh();
        smr.BakeMesh(bakedMesh);

        // Save mesh asset
        string path = EditorUtility.SaveFilePanelInProject(
            "Save Baked Mesh",
            selected.name + "_Baked.asset",
            "asset",
            "Save baked mesh as asset"
        );
        if (!string.IsNullOrEmpty(path))
        {
            AssetDatabase.CreateAsset(bakedMesh, path);
            AssetDatabase.SaveAssets();
            Debug.Log("Baked mesh saved to: " + path);

            // Optionally, create a new GameObject with the baked mesh
            GameObject go = new GameObject(selected.name + "_Baked");
            MeshFilter mf = go.AddComponent<MeshFilter>();
            MeshRenderer mr = go.AddComponent<MeshRenderer>();
            mf.sharedMesh = bakedMesh;
            mr.sharedMaterials = smr.sharedMaterials;
            go.transform.position = selected.transform.position;
            go.transform.rotation = selected.transform.rotation;
            go.transform.localScale = selected.transform.localScale;
            Selection.activeGameObject = go;
        }
    }
    // Levath - 26/05/2025 - Made with the help of GPT-4.1
}