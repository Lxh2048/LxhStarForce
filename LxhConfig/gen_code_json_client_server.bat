set WORKSPACE=.

set LUBAN_DLL=%WORKSPACE%\Luban\Luban.dll
set CONF_ROOT=%WORKSPACE%

dotnet %LUBAN_DLL% ^
    -t all ^
    -c cs-simple-json ^
    -d json  ^
    --conf %CONF_ROOT%\luban.conf ^
    -x outputCodeDir=../Assets/GameScripts/GameHotfix/LubanTables ^
    -x outputDataDir=..\Assets\GameRes\LubanTables\JsonNoAB ^
	

pause