import os

if '__main__' == __name__:

    # 客户端
    is_client = True
    # 绝对路径
    # 绝对路径
    json_paths = r"C:\D\UnityWorkSpace\LxhStarForce\Assets\GameRes\LubanTables\JsonNoAB"
    # 绝对路径
    config_path = r"C:\D\UnityWorkSpace\LxhStarForce\Assets\GameScripts\GameHotfix\Definition\Constant\Constant.LubanTable.cs"

    lxhName = "aa"

    # 逻辑
    print("")
    paths = os.walk(json_paths)

    config = open(config_path, 'w')
    config.write("namespace Game.Hotfix\n")
    config.write("{\n")
    config.write("\tpublic static class LubanTable\n")
    config.write("\t{\n")
    config.write("\t\tpublic static readonly string[] LubanTableNames = new string[]\n")
    config.write("\t\t{\n")

    for path, dir_lst, file_lst in paths:
        for file_name in file_lst:
            file_name_str = file_name.split('.')
            if file_name_str[1] != 'json':
                continue
            
            if lxhName != file_name_str[0]:
                lxhName = file_name_str[0]
                config.write("\t\t\t\"" + file_name_str[0] + "\",\n")
            # 生成config
            # config.write("\t\"" + file_name_str[0] + "\",\n")

        # 如果不遍历子文件夹，则 break
        break

    config.write("\t\t};\n")
    config.write("\t}\n")
    config.write("}\n")
    config.close()

    print("")
    input('按任意键退出')
