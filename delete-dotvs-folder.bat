@echo off
title Delete .vs Folder
echo This tool will delete all .vs project folders.
pause
echo Deleting...
rmdir KeyServer\.vs /s /q
rmdir KeyServer\KeyServer\.vs /s /q
rmdir KeyServer\KeyServerManager\.vs /s /q
echo.
echo Done!
pause
exit