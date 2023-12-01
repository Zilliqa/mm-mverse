using UnityEngine;
using UnityEditor;

public class NewBehaviourScript : MonoBehaviour
{
public class Example : MonoBehaviour
{
    //Creates a new menu (Build Asset Bundles) and item (Normal) in the Editor
    [MenuItem("Build Asset Bundles/Normal")]
    static void BuildABsNone()
    {
        //Create a folder to put the Asset Bundle in.
        // This puts the bundles in your custom folder (this case it's "MyAssetBuilds") within the Assets folder.
        //Build AssetBundles with no special options
        BuildPipeline.BuildAssetBundles("Assets/AssetBuilds", BuildAssetBundleOptions.None, BuildTarget.WebGL);
    }

    //Creates a new item (Chunk Based Compression) in the new Build Asset Bundles menu
    [MenuItem("Build Asset Bundles/Chunk Based Compression ")]
    static void BuildABsChunk()
    {
        //Build the AssetBundles in this mode
        BuildPipeline.BuildAssetBundles("Assets/AssetBuilds", BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.WebGL);
    }
}
}
