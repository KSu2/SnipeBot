using UnityEditor;
using UnityEngine;
using System.IO;

public class CreateAssetBundles
{
	[MenuItem("Assets/Build AssetBundles")]
	static void BuildAllAssetBundles()
	{
  	string assetBundleDirectory = "../HenryMod";
  	if (!Directory.Exists(Application.streamingAssetsPath))
  	{
    	Directory.CreateDirectory(assetBundleDirectory);
  	}
  	BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions.None, EditorUserBuildSettings.activeBuildTarget);
	}
}