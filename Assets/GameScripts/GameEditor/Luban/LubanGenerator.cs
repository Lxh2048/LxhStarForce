using System;
using System.IO;
using UnityEditor;
using UnityEngine;

public class LubanGenerator
{
    public static System.Diagnostics.Process CreateShellExProcess(string cmd, string args, string workingDir = "")
    {
        var pStartInfo = new System.Diagnostics.ProcessStartInfo(cmd);
        pStartInfo.Arguments = args;
        pStartInfo.CreateNoWindow = false;
        pStartInfo.UseShellExecute = true;
        pStartInfo.RedirectStandardError = false;
        pStartInfo.RedirectStandardInput = false;
        pStartInfo.RedirectStandardOutput = false;

        if (!string.IsNullOrEmpty(workingDir))
            pStartInfo.WorkingDirectory = workingDir;

        return System.Diagnostics.Process.Start(pStartInfo);
    }
    public static string FormatPath(string path)
    {
        path = path.Replace("/", "\\");

        if (Application.platform == RuntimePlatform.OSXEditor)
            path = path.Replace("\\", "/");

        return path;
    }

    private static void ProcessRun(string batName)
    {
        string toolsPath = FormatPath(Application.dataPath +  "/../LxhConfig/");
        string path = Path.Combine(toolsPath, batName);
        if (!File.Exists(toolsPath + batName))
        {
            Debug.LogError("当前的bat执行文件不存在" + path);
        }
        else
        {
            var process = CreateShellExProcess(batName, "", toolsPath);
            process.Close();
        }
    }

    [MenuItem("LxhTools/Luban/生成Binary文件")]
    private static void GenCodeBin()
    {
        ProcessRun("gen_code_bin_client_server.bat");
    }

    [MenuItem("LxhTools/Luban/生成json文件")]
    private static void GenCodeJson()
    {
        ProcessRun("gen_code_json_client_server.bat");
    }
    
    [MenuItem("LxhTools/Luban/生成cs配置文件名数组")]
    private static void GenCodeJsonConfigName()
    {
        ProcessRun("py_json_configNames.bat");
    }
}