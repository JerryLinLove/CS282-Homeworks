
set /p var=請輸入變更簡易說明:
git add .
git commit -m %var%
git push origin master
pause
